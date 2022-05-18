export class CheckoutRequest{
    public token:String
    public fullname: String;
    public provinceID: number;
    public phone: String;
    public password: String;

    constructor(token:String, name:String, province: number, phone:String, password:String){
        this.token = token;
        this.fullname = name;
        this.provinceID = province;
        this.phone = phone;
        this.password = password;
    }
}