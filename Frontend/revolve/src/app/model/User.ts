export class User{
    public id: String;
    public username: String;
    public email: String;
    public phone: String;

    constructor(id:String, un: String, email: String, phone: String){
        this.id = id;
        this.username = un;
        this.email = email;
        this.phone = phone;
    }
}