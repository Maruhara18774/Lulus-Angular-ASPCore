import { BasicResponse } from "../model/common/basicResponse";
import { GetAllProductPagingRequest } from "../model/product/getAllProductPagingRequest";
import { GetFilterProductPagingRequest } from "../model/product/getFilterProductPagingRequest";
import { GetProductDetailRequest } from "../model/product/getProductDetailRequest";
import { GetProductPagingRequest } from "../model/product/getProductPagingRequest";

export class ProductApi{
    url = "https://localhost:44354/api/Product";

    constructor(){}

    async getAll(body: GetAllProductPagingRequest){
        var currentUrl = this.url + "/GetAll?page="+body.page;
        return await fetch(currentUrl,{
            method: 'GET',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
              }
        }).then(async response => {
            return new BasicResponse(response.status,await response.json());
        });
    }

    async getByCateID(body: GetProductPagingRequest){
        var currentUrl = this.url + "/GetByCateID";
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

    async getDetail(body: GetProductDetailRequest){
        var currentUrl = this.url + "/GetDetailByID";
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

    async getByCateIDFilter(body: GetFilterProductPagingRequest){
        var currentUrl = this.url + "/GetByCateIDFilter";
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
    async getAllHot(body: GetAllProductPagingRequest){
        var currentUrl = this.url + "/GetAllHot?page="+body.page;
        return await fetch(currentUrl,{
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