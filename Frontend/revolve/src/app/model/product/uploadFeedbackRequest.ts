export class UploadFeedbackRequest{
    public star: number;
    public content: String;
    public token: String;
    public productID: number

    constructor(star: number, content: String, token:String, productID: number){
        this.star = star;
        this.content = content;
        this.token = token;
        this.productID = productID;
    }
}