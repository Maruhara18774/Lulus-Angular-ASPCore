import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CategoryApi } from '../api/categoryApi';
import { DesignerApi } from '../api/designerApi';
import { ProductApi } from '../api/productApi';
import { SizeApi } from '../api/sizeApi';
import { Category } from '../model/Category';
import { Designer } from '../model/Designer';
import { LineQuantity } from '../model/LineQuantity';
import { Product } from '../model/Product';
import { GetAllProductPagingRequest } from '../model/product/getAllProductPagingRequest';
import { ProductImage } from '../model/ProductImage';
import { ProductLine } from '../model/ProductLine';
import { Size } from '../model/Size';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css'],
  providers: [ProductService]
})
export class CategoryListComponent implements OnInit {
  baseURL: String = "http://localhost:4200";
  cateList: Category[] = new Array<Category>();
  productList: Product[] = new Array<Product>();
  designerList: Designer[] = new Array<Designer>();
  sizeList: Size[] = new Array<Size>();

  constructor(private productService:ProductService) { }

  ngOnInit(): void {
    this.loadCategory();
    this.loadProduct();
    this.loadDesigner();
    this.loadSize();
  }
  async loadCategory() {
    var api = new CategoryApi();
    var result = await api.getAll();
    if (result.status === 200) {
      for (let i = 0; i < result.body.length; i++) {
        const cate = new Category(parseInt(result.body[i].id), result.body[i].name);
        this.cateList.push(cate);
      }
    }
    else {
      console.log('Error: ' + result.body);
    }
  }

  async loadProduct() {
    var api = new ProductApi();
    var result = await api.getAll(new GetAllProductPagingRequest(1));
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
