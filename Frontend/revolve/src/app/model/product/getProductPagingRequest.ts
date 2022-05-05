export class GetProductPagingRequest{
    public pageIndex: String;
    public pageSize: String;
    public id:String;

    constructor(index:String, size: String, id:String){
        this.pageIndex = index;
        this.pageSize = size;
        this.id = id;
    }
}