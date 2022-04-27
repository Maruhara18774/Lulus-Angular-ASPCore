export class LoginRequest{
    public username: String;
    public password: String;
    public rememberMe:Boolean;

    constructor(un:String, pw: String,remember:Boolean){
        this.username = un;
        this.password = pw;
        this.rememberMe = remember;
    }
}