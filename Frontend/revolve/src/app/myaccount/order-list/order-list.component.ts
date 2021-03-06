import { Component, OnInit } from '@angular/core';
import { OrderApi } from 'src/app/api/orderApi';
import { Order } from 'src/app/model/Order';
import { OrderService } from 'src/app/services/order.service';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css'],
  providers: [OrderService]
})
export class OrderListComponent implements OnInit {
  orders: Order[];
  constructor(private orderService: OrderService) { }

  ngOnInit(): void {
    this.loadOrders();
  }
  async loadOrders(){
    var api = new OrderApi();
    var result = await api.getAll(localStorage.getItem('token')!);
    if(result.status == 200){
      this.orders = this.orderService.convertJSONtoListOrder(result.body);
      console.log(this.orders);
    }
  }
}
