import { BasicResponse } from "../model/common/basicResponse";

export class DesignerApi{
    url = "https://localhost:44354/api/Designer";

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
    async getByID(id: number){
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