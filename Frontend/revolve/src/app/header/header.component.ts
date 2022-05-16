import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { AccountApi } from '../api/accountApi';
import { CartApi } from '../api/cartApi';
import { GetInfoRequest } from '../model/header/GetInfoRequest';
import { User } from '../model/User';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  providers: [UserService]
})
export class HeaderComponent implements OnInit {
  token:String = localStorage.getItem('token')!=null ? localStorage.getItem('token')!.toString(): '';
  currentUser?: User = undefined;
  cartCount = 0;
  cartTotal = 0;
  @Output() featureSelected = new EventEmitter<string>(); 
  constructor(private userService: UserService) {
   }

  
  ngOnInit(): void {
    if(this.token != '' && this.token){
      this.loadUser();
      this.loadCartCount();
    }
  }

  async loadUser(){
    var api = new AccountApi();
    var result = await api.info(new GetInfoRequest(this.userService.getToken()!));
    if(result.status == 200){
      this.currentUser = this.userService.convertJSONtoUser(result.body);
    }
  }
  async loadCartCount(){
    var api = new CartApi();
    var result = await api.get(new GetInfoRequest(this.userService.getToken()!));
    if(result.status == 200){
      this.cartCount = result.body.lineCount;
      this.cartTotal = result.body.total;
    }
  }
}
