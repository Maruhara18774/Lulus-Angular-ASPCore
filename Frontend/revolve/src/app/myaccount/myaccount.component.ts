import { Component, OnInit } from '@angular/core';
import { AccountApi } from '../api/accountApi';
import { GetInfoRequest } from '../model/header/GetInfoRequest';
import { User } from '../model/User';
import { UserService } from '../services/user.service';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-myaccount',
  templateUrl: './myaccount.component.html',
  styleUrls: ['./myaccount.component.css'],
  providers: [UserService]
})
export class MyaccountComponent implements OnInit {
  currentUser: User;
  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.loadUser();
  }
  async loadUser(){
    var api = new AccountApi();
    var result = await api.info(new GetInfoRequest(this.userService.getToken()!));
    if(result.status == 200){
      this.currentUser = this.userService.convertJSONtoUser(result.body);
    }
  }
}
