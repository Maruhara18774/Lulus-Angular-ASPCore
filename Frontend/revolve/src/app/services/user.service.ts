import { User } from "../model/User";

export class UserService {
    setToken(token: String){
        localStorage.setItem('token',token.toString());
    }
    getToken(){
        return localStorage.getItem('token');
    }
    removeToken(){
        localStorage.removeItem('token');
    }
    convertJSONtoUser(body: any){
        var user = new User(body.id, body.username, body.email,body.phone);
        return user;
    }
}