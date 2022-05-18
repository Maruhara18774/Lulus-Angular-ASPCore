import { Add2CartRequest } from "../model/cart/Add2CartRequest";
import { CheckoutRequest } from "../model/checkout/checkoutRequest";
import { BasicResponse } from "../model/common/basicResponse";
import { GetInfoRequest } from "../model/header/GetInfoRequest";
export class CartApi{
    url = "https://localhost:44354/api/Cart";
    token = localStorage.getItem('token');

    constructor(){}

    async get(body: GetInfoRequest){
        var currentUrl = this.url + "/Get?token="+this.token;
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
    async add(body: Add2CartRequest){
        var currentUrl = this.url + "/Add";
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
    async update(body: Add2CartRequest){
        var currentUrl = this.url + "/Update";
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
    async clear(body: GetInfoRequest){
        var currentUrl = this.url + "/Clear?token="+this.token;
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
    async checkout(body: CheckoutRequest){
        var currentUrl = this.url + "/Checkout";
        console.log(JSON.stringify(body));
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