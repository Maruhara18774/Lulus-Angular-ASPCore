import { LoginRequest } from "../request/loginRequest";

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
        }).then(response => response.json());
    }
    async getTest(){
        var currentUrl = "https://localhost:44354/api/Category";
        //return await fetch(currentUrl).then(respond => respond.json())
        return await fetch(currentUrl,{
            method: 'GET',
        }).then(response => response.json());
    }
}