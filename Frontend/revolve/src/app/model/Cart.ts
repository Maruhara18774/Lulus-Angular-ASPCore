import { CartItem } from "./CartItem";

export class Cart{
    public id: number;
    public lineCount: number;
    public total: number;
    public items: CartItem[];

    constructor(id:number, count: number, total: number){
        this.id = id;
        this.lineCount = count;
        this.total = total;
        this.items = new Array<CartItem>();
    }
}