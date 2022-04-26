export class LoginRequest{
    public Username: String;
    public Password: String;
    public RememberMe:Boolean;

    constructor(un:String, pw: String,remember:Boolean){
        this.Username = un;
        this.Password = pw;
        this.RememberMe = remember;
    }
}