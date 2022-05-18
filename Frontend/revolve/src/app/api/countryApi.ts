import { BasicResponse } from "../model/common/basicResponse";

export class CountryApi{
    url = "https://localhost:44354/api/Country";

    constructor(){}

    async getAll(){
        var currentURL = this.url + "/Countries";
        return await fetch(currentURL,{
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