import { ProductImage } from "./ProductImage";

export class ProductLine{
    public id: number;
    public textureName: String;
    public textureImage: String;
    public productID: number;
    public quantity: number;
    public images: ProductImage[];
    

    constructor(id:number, textureName: String, textureImage:String, productID: number, quantity: number){
        this.id = id;
        this.textureName = textureName;
        this.textureImage = textureImage;
        this.productID = productID;
        this.quantity = quantity;
        this.images = new Array<ProductImage>();
    }
    
}