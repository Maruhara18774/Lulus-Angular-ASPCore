export class UpdateInfoRequest{
    public token: String;
    public username:String;
    public email:String;
    public phone:String;
    public password:String;
    public newPassword:String;

    constructor(token:String, username:String, email:String, phone:String, password:String, newPass:String){
        this.token = token;
        this.username = username;
        this.email = email;
        this.phone = phone;
        this.password = password;
        this.newPassword = newPass;
    }
}