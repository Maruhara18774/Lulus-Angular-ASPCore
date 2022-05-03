import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class UserService {
    token: String = '';
    setToken(token: String){
        this.token = token;
    }
    getToken(){
        return this.token;
    }
}