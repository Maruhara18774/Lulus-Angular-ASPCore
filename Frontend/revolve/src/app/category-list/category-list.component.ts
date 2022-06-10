import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
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
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css'],
  providers: [ProductService]
})
export class CategoryListComponent implements OnInit {
  baseURL: String = "http://localhost:4200";
  cateList: Category[] = new Array<Category>();
  productList: Product[] = new Array<Product>();
  currentPage:number = 1;
  keyword: String = "";
  orderBy:String = "New";

  constructor(private productService:ProductService) { }

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
    var result = await api.getAll(new GetAllProductPagingRequest(this.currentPage,this.keyword,this.orderBy));
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
  async search(form: NgForm){
    this.keyword = form.value.keyword;
    await this.loadProductReset();
  }
  async loadProductReset() {
    var api = new ProductApi();
    var result = await api.getAll(new GetAllProductPagingRequest(this.currentPage,this.keyword,this.orderBy));
    if (result.status === 200) {
      this.productList = this.productService.convertJSONtoProductList(result.body);
    }
    else {
      console.log('Error: ' + result.body);
    }
  }
  async changeOrderBy(e: any){
    this.orderBy = e.target.value;
    await this.loadProductReset();
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
