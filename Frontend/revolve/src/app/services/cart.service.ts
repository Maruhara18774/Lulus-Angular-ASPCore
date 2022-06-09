import { Cart } from "../model/Cart";
import { CartItem } from "../model/CartItem";
import { City } from "../model/City";
import { Country } from "../model/Country";
import { Province } from "../model/Province";

export class CartService {
    convertJSONtoCart(body: any) {
        var cart = new Cart(body.id, body.lineCount, body.total);
        for (let i = 0; i < body.items.length; i++) {
            var item = new CartItem(
                body.items[i].id,
                body.items[i].total,
                body.items[i].color,
                body.items[i].lineID,
                body.items[i].name,
                body.items[i].price,
                body.items[i].quantity,
                body.items[i].stocking
                );
            cart.items.push(item);
        }
        return cart;
    }
    convertJSONtoListCountry(body: any) {
        var result = new Array<Country>();
        for (let i = 0; i < body.length; i++) {
            var item = new Country(
                body[i].id,
                body[i].name);
            result.push(item);
        }
        return result;
    }
    convertJSONtoListCity(body: any) {
        var result = new Array<City>();
        for (let i = 0; i < body.length; i++) {
            var item = new City(
                body[i].id,
                body[i].name);
            result.push(item);
        }
        return result;
    }
    convertJSONtoListProvince(body: any) {
        var result = new Array<Province>();
        for (let i = 0; i < body.length; i++) {
            var item = new Province(
                body[i].id,
                body[i].name);
            result.push(item);
        }
        return result;
    }
}