import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AccountApi } from 'src/app/api/accountApi';
import { GetInfoRequest } from 'src/app/model/header/GetInfoRequest';
import { UpdateInfoRequest } from 'src/app/model/myaccount/updateInfoRequest';
import { User } from 'src/app/model/User';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-profile-setting',
  templateUrl: './profile-setting.component.html',
  styleUrls: ['./profile-setting.component.css'],
  providers: [UserService]
})
export class ProfileSettingComponent implements OnInit {
  currentUser: User;

  constructor(private userService: UserService, private route: ActivatedRoute, private router: Router) { }

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
  async update(form: NgForm){
    var value = form.value;
    if(value.newpass != value.newpass_confirm){
      alert('Confirm new password wrong.')
    }
    else{
      var api = new AccountApi();
      var result = await api.update(new UpdateInfoRequest(
        this.userService.getToken()!,
        value.username,
        value.email,
        value.phone,
        value.password,
        value.newPass));
        if(result.status == 200){
          this.userService.removeToken();
          location.reload();
          this.router.navigate(['/home']);
        }
        else{
          alert(result.body);
        }
    }
  }
}
