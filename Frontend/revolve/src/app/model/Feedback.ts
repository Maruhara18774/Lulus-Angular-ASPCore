export class Feedback{
    public id: number;
    public name: String;
    public star: number;
    public isAnonymous: boolean;
    public content: String;
    public createdDate:Date;
    public starLeft: number[];
    public starRight: number[];

    constructor(id:number, name: String, star: number, isAno: boolean, content:String, created: Date){
        this.id = id;
        this.name = name;
        this.star = star;
        this.isAnonymous = isAno;
        this.content = content;
        this.createdDate = created
        this.starLeft = Array(star).fill(4);
        this.starRight = Array(5 - star).fill(4)
    }
}