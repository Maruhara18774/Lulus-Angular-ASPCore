export class OrderItem {
    public id: number;
    public name:String;
    public price: number;
    public quantity:number;
    public total: number;
    public isFeedback: boolean;
    constructor(id: number, name:String,price:number, quantity:number,total:number, isFeedback:boolean) {
        this.id = id;
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.total = total;
        this.isFeedback = isFeedback;
    }
}