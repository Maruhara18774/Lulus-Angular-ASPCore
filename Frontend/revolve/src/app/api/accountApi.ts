import { BasicResponse } from "../model/common/basicResponse";
import { GetInfoRequest } from "../model/header/GetInfoRequest";
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

    async info(body: GetInfoRequest){
        console.log(JSON.stringify(body));
        var currentUrl = this.url + "/Info?token="+body.token;
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
}