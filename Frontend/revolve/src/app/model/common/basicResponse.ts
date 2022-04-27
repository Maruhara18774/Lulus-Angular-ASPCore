export class BasicResponse{
    public status: number;
    public body: any;

    constructor(status: number, body:any){
        this.status = status;
        this.body = body;
    }
}