import { BasicResponse } from "../model/common/basicResponse";

export class SizeApi{
    url = "https://localhost:44354/api/Size";

    constructor(){}

    async getAll(){
        return await fetch(this.url,{
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