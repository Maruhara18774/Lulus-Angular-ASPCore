import { LineQuantity } from "./LineQuantity";
import { ProductImage } from "./ProductImage";

export class ProductLine{
    public id: number;
    public textureName: String;
    public textureImage: String;
    public productID: number;
    public images: ProductImage[];
    public sizes: LineQuantity[];
    

    constructor(id:number, textureName: String, textureImage:String, productID: number){
        this.id = id;
        this.textureName = textureName;
        this.textureImage = textureImage;
        this.productID = productID;
        this.images = new Array<ProductImage>();
        this.sizes = new Array<LineQuantity>();
    }
    
}