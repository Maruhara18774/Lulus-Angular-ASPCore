import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CategoryApi } from '../api/categoryApi';
import { ProductApi } from '../api/productApi';
import { Category } from '../model/Category';
import { LineQuantity } from '../model/LineQuantity';
import { Product } from '../model/Product';
import { GetAllProductPagingRequest } from '../model/product/getAllProductPagingRequest';
import { ProductImage } from '../model/ProductImage';
import { ProductLine } from '../model/ProductLine';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css'],
  providers: [ProductService]
})
export class CategoryListComponent implements OnInit {
  cateList: Category[] = new Array<Category>();
  productList: Product[] = new Array<Product>();

  constructor(private productService:ProductService) { }

  ngOnInit(): void {
    this.loadCategory();
    this.loadProduct();
  }
  async loadCategory() {
    var api = new CategoryApi();
    var result = await api.getAll();
    if (result.status === 200) {
      console.log('Success: ' + result.body);
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
}
