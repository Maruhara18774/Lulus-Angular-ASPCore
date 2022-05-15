export class GetFilterProductPagingRequest{
    public pageIndex: number;
    public pageSize: number;
    public id:number;
    public designer: number;
    public min: number;
    public max:number;
    public size: number;

    constructor(index:number, psize: number, id:number, designer:number, min:number, max:number, size: number){
        this.pageIndex = index;
        this.pageSize = psize;
        this.id = id;
        this.designer = designer;
        this.min = min;
        this.max = max;
        this.size = size;
    }
}