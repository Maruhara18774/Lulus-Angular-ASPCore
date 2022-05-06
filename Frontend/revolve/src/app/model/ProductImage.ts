export class ProductImage{
    public id: number;
    public url: String;
    public productLineID: number;
    

    constructor(id:number, url: String, lineID: number){
        this.id = id;
        this.url = url;
        this.productLineID = lineID;
    }
}