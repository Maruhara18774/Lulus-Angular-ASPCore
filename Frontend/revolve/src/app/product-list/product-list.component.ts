import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { ProductApi } from '../api/productApi';
import { LineQuantity } from '../model/LineQuantity';
import { Product } from '../model/Product';
import { GetProductPagingRequest } from '../model/product/getProductPagingRequest';
import { ProductImage } from '../model/ProductImage';
import { ProductLine } from '../model/ProductLine';
import { ProductService } from '../services/product.service';
import { DesignerApi } from '../api/designerApi';
import { SizeApi } from '../api/sizeApi';
import { Designer } from '../model/Designer';
import { Size } from '../model/Size';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css'],
  providers: [ProductService]
})
export class ProductListComponent implements OnInit {
  baseURL: String = "http://localhost:4200";
  cateID:number;
  productList: Product[] = new Array<Product>();
  designerList: Designer[] = new Array<Designer>();
  sizeList: Size[] = new Array<Size>();

  constructor(private route: ActivatedRoute, private router: Router, private productService:ProductService) {}

  ngOnInit(): void {
    this.route.params
      .subscribe(
        (params: Params) => {
          this.cateID = +params['id'];
        }
      );
    this.loadProduct();
    this.loadDesigner();
    this.loadSize();
  }
  async loadProduct() {
    var api = new ProductApi();
    var result = await api.getByCateID(new GetProductPagingRequest(1,10,this.cateID));
    if (result.status === 200) {
      this.productList = this.productService.convertJSONtoProductList(result.body);
    }
    else {
      console.log('Error: ' + result.body);
    }
  }
  async loadDesigner(){
    var api = new DesignerApi();
    var result = await api.getAll();
    if(result.status === 200){
      this.designerList = this.productService.convertJSONtoDesignerList(result.body);
    }
    else{
      console.log('Error: ' + result.body);
    }
  }
  async loadSize(){
    var api = new SizeApi();
    var result = await api.getAll();
    if(result.status === 200){
      this.sizeList = this.productService.convertJSONtoSizeList(result.body);
    }
    else{
      console.log('Error: ' + result.body);
    }
  }

}
