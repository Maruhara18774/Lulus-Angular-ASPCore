export class Add2CartRequest{
    public token: String;
    public lineID:number;
    public quantity:number;

    constructor(token: String, line: number, quantity: number){
        this.token = token;
        this.lineID = line;
        this.quantity = quantity;
    }
}