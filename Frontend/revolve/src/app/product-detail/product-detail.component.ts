import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { CartApi } from '../api/cartApi';
import { FeedbackApi } from '../api/feedbackApi';
import { ProductApi } from '../api/productApi';
import { Add2CartRequest } from '../model/cart/Add2CartRequest';
import { LineQuantity } from '../model/LineQuantity';
import { Product } from '../model/Product';
import { GetProductDetailRequest } from '../model/product/getProductDetailRequest';
import { UploadFeedbackRequest } from '../model/product/uploadFeedbackRequest';
import { ProductImage } from '../model/ProductImage';
import { ProductLine } from '../model/ProductLine';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css'],
  providers: [ProductService]
})
export class ProductDetailComponent implements OnInit {
  id: number;
  product: Product;
  currentLine: number = 0;
  currentSize: number = 0;
  currentLineIndex: number = 0;
  token: String = "";


  constructor(private route: ActivatedRoute, private router: Router, private productService:ProductService) { }

  ngOnInit(): void {
    this.route.params
      .subscribe(
        (params: Params) => {
          this.id = +params['id'];
        }
      );
      if (localStorage.getItem('token') != undefined && localStorage.getItem('token') != null){
        this.token = localStorage.getItem('token')!;
      }
      this.loadProduct();
  }
  async loadProduct() {
    var api = new ProductApi();
    var result = await api.getDetail(new GetProductDetailRequest(this.id));
    if (result.status === 200) {
      this.product = this.productService.convertJSONtoProduct(result.body);
      this.currentLine = this.product.productLines[0].id;
    }
    else {
      console.log('Error: ' + result.body);
    }
  }
  selectProductLine(lineID: number){
    alert(lineID);
    this.currentLine = lineID;
    this.currentLineIndex = this.product.productLines.findIndex((e) => e.id == lineID);
  }
  async addToCart(form: NgForm){
    var value = form.value;
    if(localStorage.getItem('token') != undefined && localStorage.getItem('token') != null && value.quantity > 0){
      var api = new CartApi();
      var result = await api.add(new Add2CartRequest(localStorage.getItem('token')!,this.currentLine,value.quantity));
      if(result.status == 200){
        location.reload();
      }
    }
  }
  async updateFeedback(form: NgForm){
    var value = form.value;
    if(value.star <= 5 && value.star >= 1 && value.content != ""){
      var api = new FeedbackApi();
      var result = await api.create(new UploadFeedbackRequest(value.star,value.content,this.token,this.id));
      if(result.status == 200){
        await this.loadProduct();
      }
    }
  }
}
