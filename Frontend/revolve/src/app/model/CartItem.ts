export class CartItem{
    public id: number;
    public total: number;
    public color: String;
    public lineID:number;
    public name: String;
    public price: number;
    public quantity:number;
    public stocking: Boolean;

    constructor(id:number, total: number, color: String, line: number,name:String,price:number,quantity: number, stocking: Boolean){
        this.id = id;
        this.total = total;
        this.color = color;
        this.lineID = line;
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.stocking = stocking;
    }
}