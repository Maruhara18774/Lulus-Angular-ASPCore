import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CartApi } from '../api/cartApi';
import { CategoryApi } from '../api/categoryApi';
import { ProductApi } from '../api/productApi';
import { Add2CartRequest } from '../model/cart/Add2CartRequest';
import { Category } from '../model/Category';
import { Product } from '../model/Product';
import { GetAllProductPagingRequest } from '../model/product/getAllProductPagingRequest';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-hot-list',
  templateUrl: './hot-list.component.html',
  styleUrls: ['./hot-list.component.css'],
  providers: [ProductService]
})
export class HotListComponent implements OnInit {
  baseURL: String = "http://localhost:4200";
  cateList: Category[] = new Array<Category>();
  productList: Product[] = new Array<Product>();

  constructor(private route: ActivatedRoute, private router: Router, private productService:ProductService) { }

  ngOnInit(): void {
    this.loadCategory();
    this.loadProduct();
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
    var result = await api.getAllHot(new GetAllProductPagingRequest(1));
    if (result.status === 200) {
      this.productList = this.productService.convertJSONtoProductList(result.body);
    }
    else {
      console.log('Error: ' + result.body);
    }
  }
  async addToCart(lineID: number){
    if(localStorage.getItem('token') != undefined && localStorage.getItem('token') != null){
      var api = new CartApi();
      var result = await api.add(new Add2CartRequest(localStorage.getItem('token')!,lineID,1));
      if(result.status == 200){
        console.log(result.body);
      }
    }
  }
}
