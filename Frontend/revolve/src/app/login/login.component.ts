import { Component, OnInit} from '@angular/core';
import { NgForm } from '@angular/forms';
import { AccountApi } from '../api/accountApi';
import { LoginRequest } from '../request/loginRequest';

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
    console.log(result);
  }
}
