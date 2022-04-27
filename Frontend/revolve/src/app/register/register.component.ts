import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AccountApi } from '../api/accountApi';
import { RegisterRequest } from '../model/register/registerRequest';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  async regist(form: NgForm){
    var value = form.value;
    var request = new RegisterRequest(value.email, value.username,value.password);
    var api = new AccountApi();
    var result = await api.register(request);
    if(result.status === 200){
      console.log('Success: ' + result.body);
    }
    else{
      console.log('Error: ' + result.body);
    }
  }

}
