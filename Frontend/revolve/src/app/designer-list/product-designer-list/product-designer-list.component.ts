import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { CartApi } from 'src/app/api/cartApi';
import { FavoriteProductApi } from 'src/app/api/favoriteProductApi';
import { ProductApi } from 'src/app/api/productApi';
import { Add2CartRequest } from 'src/app/model/cart/Add2CartRequest';
import { AddFavoriteProductRequest } from 'src/app/model/favoriteProduct/addFavoriteProductRequest';
import { Product } from 'src/app/model/Product';
import { GetProductPagingRequest } from 'src/app/model/product/getProductPagingRequest';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product-designer-list',
  templateUrl: './product-designer-list.component.html',
  styleUrls: ['./product-designer-list.component.css'],
  providers: [ProductService]
})
export class ProductDesignerListComponent implements OnInit {
  baseURL: String = "http://localhost:4200";
  id: number;
  productList: Product[] = new Array<Product>();
  currentPage:number = 1;

  constructor(private route: ActivatedRoute, private router: Router, private productService:ProductService) { }

  ngOnInit(): void {
    this.route.params
      .subscribe(
        (params: Params) => {
          this.id = +params['id'];
        }
      );
      this.loadProduct();
  }

  async loadProduct() {
    var api = new ProductApi();
    var result = await api.getByDesignerID(new GetProductPagingRequest(this.currentPage,10,this.id));
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
