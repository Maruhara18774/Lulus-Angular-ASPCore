import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AccountApi } from '../api/accountApi';
import { CartApi } from '../api/cartApi';
import { CityApi } from '../api/cityApi';
import { CountryApi } from '../api/countryApi';
import { ProvinceApi } from '../api/provinceApi';
import { Cart } from '../model/Cart';
import { CheckoutRequest } from '../model/checkout/checkoutRequest';
import { City } from '../model/City';
import { Country } from '../model/Country';
import { GetInfoRequest } from '../model/header/GetInfoRequest';
import { Province } from '../model/Province';
import { User } from '../model/User';
import { CartService } from '../services/cart.service';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css'],
  providers: [CartService, UserService]
})
export class CheckoutComponent implements OnInit {
  cart: Cart;
  countries: Country[];
  cities: City[];
  provinces: Province[];
  currentUser: User;
  currentProvinceID: number;
  isPaypal = false;

  constructor(private cartService: CartService, private userService: UserService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.loadCart();
    this.loadCountry();
    this.loadUser();
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
  async loadCountry() {
    var api = new CountryApi();
    var result = await api.getAll();
    if (result.status == 200) {
      this.countries = this.cartService.convertJSONtoListCountry(result.body);
    }
  }

  async loadUser() {
    var api = new AccountApi();
    var result = await api.info(new GetInfoRequest(this.userService.getToken()!));
    if (result.status == 200) {
      this.currentUser = this.userService.convertJSONtoUser(result.body);
    }
  }

  async changeCountry(e: any) {
    if(e.target.value >= 0){
      var api = new CityApi();
      var result = await api.getAll(e.target.value);
      if (result.status == 200) {
        this.cities = this.cartService.convertJSONtoListCity(result.body);
      }
    }
  }
  async changeCity(e: any) {
    if(e.target.value >= 0){
      var api = new ProvinceApi();
      var result = await api.getAll(e.target.value);
      if (result.status == 200) {
        this.provinces = this.cartService.convertJSONtoListProvince(result.body);
      }
    }
  }
  async changeProvince(e: any) {
    if(e.target.value >= 0){
      this.currentProvinceID = e.target.value;
    }
  }
  async checkout(form: NgForm) {
    var value = form.value;
    if ((this.currentUser.phone == undefined || this.currentUser.phone == "") && (value.phone == undefined || value.phone == "")) {
      alert("Please input Receiver's phone number.")
    }
    else {
      if(this.isPaypal){
        var paypalConfig= {
          env: 'Sandbox',
          client: {
            sandbox: 'ARLgwDkiL4bhZjmXB9VFOtqrIW-UsDp8IRkRqAjqe0zcHsGC0-dJ_oAvVxPVpXVOegXx3xl_bpeWuWD-',
            production: 'production-key'
          },
          commit: true,
          payment: (data: any, actions: any) => {
            return actions.payment.create(
              {
                payment: {
                  transactions: [
                    {
                      amount: {
                        total: this.cart.total,
                        currency: 'USD'
                      }
                    }
                  ]
                }
              }
            );
          },
          onAuthorize: (data: any, actions: any) =>{
            return actions.payment.execute().then((payment: any)=>{
              this.router.navigate(['/home']);
            })
          }
        };
      }
      else{
        if (value.phone == undefined || value.phone == "") {
          var api = new CartApi();
          var result = await api.checkout(new CheckoutRequest(
            localStorage.getItem('token')!,
            value.name,
            this.currentProvinceID,
            this.currentUser.phone,
            value.password
          ));
          if(result.status == 200){
            window.scrollTo(0, 0);
            this.router.navigate(['/home']);
          }
          else{
            alert(result.body);
          }
        }
        else {
          var api = new CartApi();
          var result = await api.checkout(new CheckoutRequest(
            localStorage.getItem('token')!,
            value.name,
            this.currentProvinceID,
            value.phone,
            value.password
          ));
          if(result.status == 200){
            this.router.navigate(['/home']);
          }
          else{
            alert(result.body);
          }
        }
      }
      
    }
  }
}
