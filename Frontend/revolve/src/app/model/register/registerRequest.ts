export class RegisterRequest{
    public email: String;
    public username: String;
    public password:String;

    constructor(em:String, un: String, pw:String){
        this.email = em;
        this.username = un;
        this.password = pw;
    }
}