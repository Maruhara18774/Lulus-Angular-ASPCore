import { Order } from "../model/Order";
import { OrderItem } from "../model/OrderItem";

export class OrderService {
    convertJSONtoListOrder(body: any) {
        var result = new Array<Order>();
        for (let i = 0; i < body.length; i++) {
            var orderData = body[i];
            var order = new Order(orderData.id, orderData.status, orderData.total, this.convertStringtoDate(orderData.datePurchase));
            for (let j = 0; j < orderData.items.length; j++) {
                var itemData = orderData.items[j];
                var item = new OrderItem(itemData.id, itemData.name, itemData.price, itemData.quantity, itemData.total, itemData.isFeedback);
                order.items.push(item);
            }
            result.push(order);
        }
        return result;
    }
    convertJSONtoOrder(body: any) {
        var order = new Order(body.id, body.status, body.total, this.convertStringtoDate(body.datePurchase));
        for (let j = 0; j < body.items.length; j++) {
            var itemData = body.items[j];
            var item = new OrderItem(itemData.id, itemData.name, itemData.price, itemData.quantity, itemData.total, itemData.isFeedback);
            order.items.push(item);
        }
        return order;
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