import { Feedback } from './Feedback';
import {ProductLine} from './ProductLine';
export class Product{
    public id: number;
    public name: String;
    public price: number;
    public description:String;
    public categoryID: number;
    public designerID: number;
    public status: number;
    public averageStarLeft: number[];
    public averageStarRight: number[];
    public productLines: ProductLine[];
    public feedbacks: Feedback[];

    constructor(id:number, name: String, price: number, description: String, cateID: number, designerID: number,status: number, averageStar: number){
        this.id = id;
        this.name = name;
        this.price = price;
        this.description = description;
        this.categoryID = cateID;
        this.designerID = designerID;
        this.status = status;
        this.averageStarLeft = Array(averageStar).fill(4);
        this.averageStarRight = Array(5 - averageStar).fill(4)
        this.productLines = new Array<ProductLine>();
        this.feedbacks = new Array<Feedback>();
    }
}