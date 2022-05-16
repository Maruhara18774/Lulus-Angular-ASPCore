import { Cart } from "../model/Cart";
import { CartItem } from "../model/CartItem";

export class CartService {
    /*
    convertJSONtoSizeList(body: any){
        var sizeList: Size[] = new Array<Size>();
        for (let i = 0; i < body.length; i++){
            var size = new Size(parseInt(body[i].id),body[i].key);
            sizeList.push(size);
        }
        return sizeList;
    }
    */
   convertJSONtoCart(body:any){
       var cart = new Cart(body.id, body.lineCount,body.total);
       for (let i = 0; i< body.items.length;i++){
           var item = new CartItem(
               body.items[i].id,
               body.items[i].total,
               body.items[i].color,
               body.items[i].lineID,
               body.items[i].name,
               body.items[i].price,
               body.items[i].quantity);
            cart.items.push(item);
       }
       return cart;
   }
}