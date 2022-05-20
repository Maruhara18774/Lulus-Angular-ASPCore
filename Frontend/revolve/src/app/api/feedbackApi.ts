import { BasicResponse } from "../model/common/basicResponse";
import { UploadFeedbackRequest } from "../model/product/uploadFeedbackRequest";

export class FeedbackApi{
    url = "https://localhost:44354/api/Feedback";

    constructor(){}

    async create(body: UploadFeedbackRequest){
        return await fetch(this.url+"/CreateFeedback",{
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