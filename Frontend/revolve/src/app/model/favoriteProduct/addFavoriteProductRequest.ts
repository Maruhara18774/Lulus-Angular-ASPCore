export class AddFavoriteProductRequest{
    public token:String
    public productID: number;

    constructor(token:String, id: number){
        this.token = token;
        this.productID = id;
    }
}