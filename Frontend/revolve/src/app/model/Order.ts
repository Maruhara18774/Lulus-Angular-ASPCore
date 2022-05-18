import { OrderItem } from "./OrderItem";

export class Order {
    public id: number;
    public status: String;
    public total:number;
    public datePurchase:Date;
    public items: OrderItem[];

    constructor(id:number, status:string, total:number, datePurchase: Date) {
        this.id = id;
        this.status = status;
        this.total = total;
        this.datePurchase = datePurchase;
        this.items = new Array<OrderItem>();
    }
}