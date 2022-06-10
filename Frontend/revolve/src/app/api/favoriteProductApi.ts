import { BasicResponse } from "../model/common/basicResponse";
import { AddFavoriteProductRequest } from "../model/favoriteProduct/addFavoriteProductRequest";
import { GetAllFavoriteProductRequest } from "../model/favoriteProduct/getAllFavoriteProductRequest";
import { UploadFeedbackRequest } from "../model/product/uploadFeedbackRequest";

export class FavoriteProductApi{
    url = "https://localhost:44354/api/FavoriteProduct";

    constructor(){}

    async create(body: AddFavoriteProductRequest){
        return await fetch(this.url + "/Create",{
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
    async remove(body: AddFavoriteProductRequest){
        return await fetch(this.url +"/Remove",{
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
    async get(body: GetAllFavoriteProductRequest){
        return await fetch(this.url+"/Get",{
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