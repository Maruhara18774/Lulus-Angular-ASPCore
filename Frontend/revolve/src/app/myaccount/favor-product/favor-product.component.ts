import { Component, OnInit } from '@angular/core';
import { FavoriteProductApi } from 'src/app/api/favoriteProductApi';
import { AddFavoriteProductRequest } from 'src/app/model/favoriteProduct/addFavoriteProductRequest';
import { GetAllFavoriteProductRequest } from 'src/app/model/favoriteProduct/getAllFavoriteProductRequest';
import { Product } from 'src/app/model/Product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-favor-product',
  templateUrl: './favor-product.component.html',
  styleUrls: ['./favor-product.component.css'],
  providers: [ProductService]
})
export class FavorProductComponent implements OnInit {
  baseURL: String = "http://localhost:4200";
  productList: Product[] = new Array<Product>();
  currentPage:number = 1;
  token: String = "";

  constructor(private productService:ProductService) {}

  ngOnInit(): void {
    if (localStorage.getItem('token') != undefined && localStorage.getItem('token') != null){
      this.token = localStorage.getItem('token')!;
      this.loadProduct();
    }
  }

  async loadProduct() {
    var api = new FavoriteProductApi();
    var result = await api.get(new GetAllFavoriteProductRequest(this.token, this.currentPage));
    if (result.status === 200) {
      this.productList = this.productService.convertJSONtoProductList(result.body);
    }
    else {
      console.log('Error: ' + result.body);
    }
  }
  async remove(productID: number){
    var api = new FavoriteProductApi();
    var result = await api.remove(new AddFavoriteProductRequest(this.token, productID));
    if (result.status === 200) {
      await this.loadProduct();
    }
    else {
      console.log('Error: ' + result.body);
    }
  }
}
