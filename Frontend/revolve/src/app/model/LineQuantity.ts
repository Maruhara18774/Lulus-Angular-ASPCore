export class LineQuantity{
    public id: number;
    public key: String;
    public quantity: number;
    

    constructor(id:number, key: String, quantity: number){
        this.id = id;
        this.key = key;
        this.quantity = quantity;
    }
}