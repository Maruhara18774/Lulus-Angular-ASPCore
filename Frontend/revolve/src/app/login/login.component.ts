import { Component, OnInit} from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AccountApi } from '../api/accountApi';
import { LoginRequest } from '../model/login/loginRequest';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  providers: [UserService]
})
export class LoginComponent implements OnInit {

  constructor(private userService: UserService,private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
  }
  async login(form: NgForm){
    var value = form.value;
    var request = new LoginRequest(value.username,value.password, value.remember === "" ? false:value.remember);
    var api = new AccountApi();
    var result = await api.login(request);
    if(result.status === 200){
      this.userService.setToken(result.body);
      alert("Login success")
      location.reload();
    }
    else{
      console.log('Error: ' + result.body);
    }
  }
}
