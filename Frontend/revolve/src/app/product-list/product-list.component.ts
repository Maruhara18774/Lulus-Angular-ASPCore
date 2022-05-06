import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { ProductApi } from '../api/productApi';
import { LineQuantity } from '../model/LineQuantity';
import { Product } from '../model/Product';
import { GetProductPagingRequest } from '../model/product/getProductPagingRequest';
import { ProductImage } from '../model/ProductImage';
import { ProductLine } from '../model/ProductLine';
import { ProductService } from '../services/product.service';

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

  constructor(private route: ActivatedRoute, private router: Router, private productService:ProductService) {}

  ngOnInit(): void {
    this.route.params
      .subscribe(
        (params: Params) => {
          this.cateID = +params['id'];
        }
      );
    this.loadProduct();
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

}
