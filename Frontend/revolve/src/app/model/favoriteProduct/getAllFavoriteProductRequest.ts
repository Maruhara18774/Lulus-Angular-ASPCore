export class GetAllFavoriteProductRequest{
    public token:String
    public page: number;

    constructor(token:String, page: number){
        this.token = token;
        this.page = page;
    }
}