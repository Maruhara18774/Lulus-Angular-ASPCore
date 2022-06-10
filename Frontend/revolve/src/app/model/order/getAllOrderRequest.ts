export class GetAllOrderRequest{
    public token: String;
    public status: String;

    constructor(token: String, status: String){
        this.token = token;
        this.status = status;
    }
}