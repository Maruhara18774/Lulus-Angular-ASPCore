import { BasicResponse } from "../model/common/basicResponse";
import { GetAllOrderRequest } from "../model/order/getAllOrderRequest";

export class OrderApi{
    url = "https://localhost:44354/api/Order";

    constructor(){}

    async getAll(body: GetAllOrderRequest){
        var currentURL = this.url;
        return await fetch(currentURL,{
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
    async cancel(id: number){
        return await fetch(this.url+"/Cancel/"+id.toString(),{
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