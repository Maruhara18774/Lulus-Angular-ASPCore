import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { ProductApi } from '../api/productApi';
import { Product } from '../model/Product';
import { GetProductPagingRequest } from '../model/product/getProductPagingRequest';
import { ProductService } from '../services/product.service';
import { DesignerApi } from '../api/designerApi';
import { Designer } from '../model/Designer';
import { GetFilterProductPagingRequest } from '../model/product/getFilterProductPagingRequest';
import { CartApi } from '../api/cartApi';
import { Add2CartRequest } from '../model/cart/Add2CartRequest';
import { FavoriteProductApi } from '../api/favoriteProductApi';
import { AddFavoriteProductRequest } from '../model/favoriteProduct/addFavoriteProductRequest';

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
  filterRequest: GetFilterProductPagingRequest;

  constructor(private route: ActivatedRoute, private router: Router, private productService:ProductService) {
  }

  ngOnInit(): void {
    this.route.params
      .subscribe(
        (params: Params) => {
          this.cateID = +params['id'];
          this.filterRequest = new GetFilterProductPagingRequest(1,10,this.cateID,0,0,0,0);
        }
      );
    this.loadProduct();
    this.loadDesigner();
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
    var result = await api.getAllByCate(this.cateID);
    if(result.status === 200){
      this.designerList = this.productService.convertJSONtoDesignerList(result.body);
    }
    else{
      console.log('Error: ' + result.body);
    }
  }
  resetFilter(){
    this.filterRequest = new GetFilterProductPagingRequest(1,10,this.cateID,0,0,0,0);
    this.refreshProductByFilter();
  }
  async refreshProductByFilter(){
    var api = new ProductApi();
    var result = await api.getByCateIDFilter(this.filterRequest);
    if (result.status === 200) {
      this.productList = this.productService.convertJSONtoProductList(result.body);
    }
    else {
      console.log('Error: ' + result.body);
    }
  }
  pickDesigner(id: number){
    this.filterRequest.designer = id;
    this.refreshProductByFilter();
  }
  pickRangePrice(min:number, max: number){
    this.filterRequest.min = min;
    this.filterRequest.max = max;
    this.refreshProductByFilter();
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
