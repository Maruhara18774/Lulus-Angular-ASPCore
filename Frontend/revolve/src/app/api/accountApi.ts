import { BasicResponse } from "../model/common/basicResponse";
import { LoginRequest } from "../model/login/loginRequest";
import { RegisterRequest } from "../model/register/registerRequest";

export class AccountApi{
    url = "https://localhost:44354/api/User";

    constructor(){}

    async login(body: LoginRequest){
        var currentUrl = this.url + "/Authenticate";
        return await fetch(currentUrl,{
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
              },
            body: JSON.stringify(body)
        }).then(async response => {
            return new BasicResponse(response.status,await response.json());
        });
    }

    async register(body:RegisterRequest){
        var currentUrl = this.url + "/Register";
        return await fetch(currentUrl,{
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
              },
            body: JSON.stringify(body)
        }).then(async response => {
            return new BasicResponse(response.status,await response.json());
        });
    }

    async getTest(){
        var currentUrl = "https://localhost:44354/api/Category";
        //return await fetch(currentUrl).then(respond => respond.json())
        return await fetch(currentUrl,{
            method: 'GET',
        }).then(response => response.json());
    }
}