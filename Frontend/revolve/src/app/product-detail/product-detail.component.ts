import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { ProductApi } from '../api/productApi';
import { LineQuantity } from '../model/LineQuantity';
import { Product } from '../model/Product';
import { GetProductDetailRequest } from '../model/product/getProductDetailRequest';
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
}
