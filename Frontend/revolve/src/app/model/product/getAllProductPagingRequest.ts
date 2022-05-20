export class GetAllProductPagingRequest{
    public page: number;
    public keyword: String;
    public orderBy: String;

    constructor(page:number, keyword: String, orderBy: String){
        this.page = page;
        this.keyword = keyword;
        this.orderBy = orderBy;
    }
}