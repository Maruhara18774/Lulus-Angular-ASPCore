export class GetProductPagingRequest{
    public pageIndex: number;
    public pageSize: number;
    public id:number;

    constructor(index:number, size: number, id:number){
        this.pageIndex = index;
        this.pageSize = size;
        this.id = id;
    }
}