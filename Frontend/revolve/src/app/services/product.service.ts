import { Designer } from "../model/Designer";
import { Feedback } from "../model/Feedback";
import { Product } from "../model/Product";
import { ProductImage } from "../model/ProductImage";
import { ProductLine } from "../model/ProductLine";

export class ProductService {
    convertJSONtoProductList(body: any) {
        var productList: Product[] = new Array<Product>();
        for (let i = 0; i < body.length; i++) {
            const product = new Product(
                parseInt(body[i].id),
                body[i].name,
                parseFloat(body[i].price),
                body[i].description,
                body[i].category_ID,
                body[i].designerID,
                body[i].status,
                parseFloat(body[i].averageStar)
            );
            for (let j = 0; j < body[i].listProductLines.length; j++) {
                const productLine = new ProductLine(
                    body[i].listProductLines[j].id,
                    body[i].listProductLines[j].texture_Name,
                    body[i].listProductLines[j].texture_Image_Url,
                    body[i].listProductLines[j].product_ID,
                    body[i].listProductLines[j].quantity
                );

                for (let k = 0; k < body[i].listProductLines[j].listImages.length; k++) {
                    const image = new ProductImage(
                        body[i].listProductLines[j].listImages[k].id,
                        body[i].listProductLines[j].listImages[k].image_Url,
                        body[i].listProductLines[j].listImages[k].productLine_ID
                    );
                    productLine.images.push(image);
                }
                product.productLines.push(productLine);
            }
            productList.push(product);
        }
        return productList;
    }
    convertJSONtoProduct(body: any) {
        const product = new Product(
            parseInt(body.id),
            body.name,
            parseFloat(body.price),
            body.description,
            body.category_ID,
            body.designerID,
            body.status,
            parseFloat(body.averageStar)
        );
        for (let j = 0; j < body.listProductLines.length; j++) {
            const productLine = new ProductLine(
                body.listProductLines[j].id,
                body.listProductLines[j].texture_Name,
                body.listProductLines[j].texture_Image_Url,
                body.listProductLines[j].product_ID,
                body.listProductLines[j].quantity
            );

            for (let k = 0; k < body.listProductLines[j].listImages.length; k++) {
                const image = new ProductImage(
                    body.listProductLines[j].listImages[k].id,
                    body.listProductLines[j].listImages[k].image_Url,
                    body.listProductLines[j].listImages[k].productLine_ID
                );
                productLine.images.push(image);
            }
            product.productLines.push(productLine);
        }
        for(let i = 0; i< body.listFeedbacks.length;i++){
            var feedback = new Feedback(
                body.listFeedbacks[i].id,
                body.listFeedbacks[i].name,
                body.listFeedbacks[i].star,
                body.listFeedbacks[i].isAnonymous,
                body.listFeedbacks[i].content,
                this.convertStringtoDate(body.listFeedbacks[i].createdDate)
            );
            product.feedbacks.push(feedback);
        }
        return product;
    }
    convertJSONtoDesignerList(body:any){
        var designerList: Designer[] = new Array<Designer>();
        for (let i = 0; i < body.length; i++){
            var designer = new Designer(parseInt(body[i].id),body[i].name,body[i].description);
            designerList.push(designer);
        }
        return designerList;
    }
    convertStringtoDate(body: String) {
        var date = new Date(
            parseInt(body.substring(0, 4)),
            parseInt(body.substring(5, 7)),
            parseInt(body.substring(8, 10)),
            parseInt(body.substring(11, 13)),
            parseInt(body.substring(14, 16)),
            parseInt(body.substring(17, 19)),
        );
        return date;
    }
}