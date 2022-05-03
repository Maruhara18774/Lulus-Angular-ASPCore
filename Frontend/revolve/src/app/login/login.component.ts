import { Component, OnInit} from '@angular/core';
import { NgForm } from '@angular/forms';
import { AccountApi } from '../api/accountApi';
import { LoginRequest } from '../model/login/loginRequest';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  async login(form: NgForm){
    var value = form.value;
    var request = new LoginRequest(value.username,value.password, value.remember === "" ? false:value.remember);
    var api = new AccountApi();
    var result = await api.login(request);
    if(result.status === 200){
      //this.userService.setToken(result.body);
      console.log('Success: ' + result.body);
    }
    else{
      console.log('Error: ' + result.body);
    }
  }
}
