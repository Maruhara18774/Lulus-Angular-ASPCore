import {ProductLine} from './ProductLine';
export class Product{
    public id: number;
    public name: String;
    public price: number;
    public description:String;
    public categoryID: number;
    public designerID: number;
    public status: number;
    public productLines: ProductLine[];

    constructor(id:number, name: String, price: number, description: String, cateID: number, designerID: number,status: number){
        this.id = id;
        this.name = name;
        this.price = price;
        this.description = description;
        this.categoryID = cateID;
        this.designerID = designerID;
        this.status = status;
        this.productLines = new Array<ProductLine>();
    }
}