import { BasicResponse } from "../model/common/basicResponse";

export class OrderApi{
    url = "https://localhost:44354/api/Order";

    constructor(){}

    async getAll(token: String){
        var currentURL = this.url + "?token="+token;
        return await fetch(currentURL,{
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
              }
        }).then(async response => {
            return new BasicResponse(response.status,await response.json());
        });
    }
    async get(id: number){
        return await fetch(this.url+"/"+id.toString(),{
            method: 'GET',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
              }
        }).then(async response => {
            return new BasicResponse(response.status,await response.json());
        });
    }
}