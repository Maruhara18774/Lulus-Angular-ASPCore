import { Component, OnInit } from '@angular/core';
import { CartApi } from '../api/cartApi';
import { Cart } from '../model/Cart';
import { GetInfoRequest } from '../model/header/GetInfoRequest';
import { CartService } from '../services/cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css'],
  providers: [CartService]
})
export class CartComponent implements OnInit {
  cart: Cart;

  constructor(private cartService: CartService) { }

  ngOnInit(): void {
    if(localStorage.getItem('token') != undefined && localStorage.getItem('token') != null){
      this.loadCart();
    }
  }
  async loadCart(){
    var api = new CartApi();
    var result = await api.get(new GetInfoRequest(localStorage.getItem('token')!));
    if(result.status == 200){
      this.cart = this.cartService.convertJSONtoCart(result.body);
      console.log(this.cart)
    }
  }
}
