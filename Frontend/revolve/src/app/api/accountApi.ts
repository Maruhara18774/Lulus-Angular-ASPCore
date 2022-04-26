import { LoginRequest } from "../request/loginRequest";
import { HttpClient } from "@angular/common/http";

export class AccountApi{
    url = "https://localhost:44354/api/User";

    constructor(private httpClient: HttpClient){}

    login(body: LoginRequest){
        var currentUrl = this.url + "/Authenticate";
        return this.httpClient.post(currentUrl,JSON.stringify(body));
    }
}