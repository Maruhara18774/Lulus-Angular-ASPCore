import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CartApi } from '../api/cartApi';
import { Cart } from '../model/Cart';
import { Add2CartRequest } from '../model/cart/Add2CartRequest';
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
    this.loadCart();
  }
  async loadCart() {
    if (localStorage.getItem('token') != undefined && localStorage.getItem('token') != null) {
      var api = new CartApi();
      var result = await api.get(new GetInfoRequest(localStorage.getItem('token')!));
      if (result.status == 200) {
        this.cart = this.cartService.convertJSONtoCart(result.body);
      }
    }
  }
  async updateQuantity(form: NgForm, id: number) {
    var value = form.value;
    if (value.quantity != undefined && value.quantity > 0) {
      if (localStorage.getItem('token') != undefined && localStorage.getItem('token') != null) {
        var api = new CartApi();
        var result = await api.update(new Add2CartRequest(localStorage.getItem('token')!,id,value.quantity));
        if (result.status == 200) {
          this.loadCart();
        }
      }
    }
  }
  async clear(){
    if (localStorage.getItem('token') != undefined && localStorage.getItem('token') != null) {
      var api = new CartApi();
      var result = await api.clear(new GetInfoRequest(localStorage.getItem('token')!));
      if (result.status == 200) {
        this.loadCart();
      }
    }
  }
}
