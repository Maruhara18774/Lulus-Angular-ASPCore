import { LineQuantity } from "../model/LineQuantity";
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
                body[i].status
            );
            for (let j = 0; j < body[i].listProductLines.length; j++) {
                const productLine = new ProductLine(
                    body[i].listProductLines[j].id,
                    body[i].listProductLines[j].texture_Name,
                    body[i].listProductLines[j].texture_Image_Url,
                    body[i].listProductLines[j].product_ID
                );

                for (let k = 0; k < body[i].listProductLines[j].listImages.length; k++) {
                    const image = new ProductImage(
                        body[i].listProductLines[j].listImages[k].id,
                        body[i].listProductLines[j].listImages[k].image_Url,
                        body[i].listProductLines[j].listImages[k].productLine_ID
                    );
                    productLine.images.push(image);
                }

                for (let k = 0; k < body[i].listProductLines[j].listSizes.length; k++) {
                    const size = new LineQuantity(
                        body[i].listProductLines[j].listSizes[k].id,
                        body[i].listProductLines[j].listSizes[k].key,
                        body[i].listProductLines[j].listSizes[k].quantity
                    );
                    productLine.sizes.push(size);
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
            body.status
        );
        for (let j = 0; j < body.listProductLines.length; j++) {
            const productLine = new ProductLine(
                body.listProductLines[j].id,
                body.listProductLines[j].texture_Name,
                body.listProductLines[j].texture_Image_Url,
                body.listProductLines[j].product_ID
            );

            for (let k = 0; k < body.listProductLines[j].listImages.length; k++) {
                const image = new ProductImage(
                    body.listProductLines[j].listImages[k].id,
                    body.listProductLines[j].listImages[k].image_Url,
                    body.listProductLines[j].listImages[k].productLine_ID
                );
                productLine.images.push(image);
            }

            for (let k = 0; k < body.listProductLines[j].listSizes.length; k++) {
                const size = new LineQuantity(
                    body.listProductLines[j].listSizes[k].id,
                    body.listProductLines[j].listSizes[k].key,
                    body.listProductLines[j].listSizes[k].quantity
                );
                productLine.sizes.push(size);
            }
            product.productLines.push(productLine);
        }
        return product;
    }
}