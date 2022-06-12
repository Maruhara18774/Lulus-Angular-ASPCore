import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CartApi } from '../api/cartApi';
import { CategoryApi } from '../api/categoryApi';
import { FavoriteProductApi } from '../api/favoriteProductApi';
import { ProductApi } from '../api/productApi';
import { Add2CartRequest } from '../model/cart/Add2CartRequest';
import { Category } from '../model/Category';
import { AddFavoriteProductRequest } from '../model/favoriteProduct/addFavoriteProductRequest';
import { Product } from '../model/Product';
import { GetAllProductPagingRequest } from '../model/product/getAllProductPagingRequest';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-new-list',
  templateUrl: './new-list.component.html',
  styleUrls: ['./new-list.component.css'],
  providers: [ProductService]
})
export class NewListComponent implements OnInit {
  baseURL: String = "http://localhost:4200";
  productList: Product[] = new Array<Product>();
  currentPage:number = 1;

  constructor(private route: ActivatedRoute, private router: Router, private productService:ProductService) { }

  ngOnInit(): void {
    this.loadProduct();
  }

  async loadProduct() {
    var api = new ProductApi();
    var result = await api.getAllNew(new GetAllProductPagingRequest(this.currentPage,"",""));
    if (result.status === 200) {
      var listPrd = this.productService.convertJSONtoProductList(result.body);
      listPrd.forEach(item => {
        this.productList.push(item);
      })
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
        location.reload();
      }
    }
    if(!(localStorage.getItem('token') != undefined && localStorage.getItem('token') != null)){
      alert("Please login.");
    }
  }
  async nextPage(){
    this.currentPage += 1;
    await this.loadProduct();
  }
  async addFavorite(productID: number){
    if(!(localStorage.getItem('token') != undefined && localStorage.getItem('token') != null)){
      alert("Please login.");
    }
    else{
      var api = new FavoriteProductApi();
      var token = localStorage.getItem('token')!.toString();
      var result = await api.create(new AddFavoriteProductRequest(token,productID));
      if(result.status == 200){
        alert("Added");
      }
      else{
        alert(result.body);
      }
    }
  }
}
