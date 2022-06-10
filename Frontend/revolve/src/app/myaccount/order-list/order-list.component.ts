import { Component, OnInit } from '@angular/core';
import { OrderApi } from 'src/app/api/orderApi';
import { Order } from 'src/app/model/Order';
import { GetAllOrderRequest } from 'src/app/model/order/getAllOrderRequest';
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
    var result = await api.getAll(new GetAllOrderRequest(localStorage.getItem('token')!,""));
    if(result.status == 200){
      this.orders = this.orderService.convertJSONtoListOrder(result.body);
    }
  }
  async selectTypeOrder(e: any){
    var val = e.target.value;
    if(val == "All"){
      await this.loadOrders();
    }
    else{
      var api = new OrderApi();
      var result = await api.getAll(new GetAllOrderRequest(localStorage.getItem('token')!,val));
      if(result.status == 200){
        this.orders = this.orderService.convertJSONtoListOrder(result.body);
        console.log(this.orders);
      }
    }
  }
}
