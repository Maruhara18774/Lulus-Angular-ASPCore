import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { OrderApi } from 'src/app/api/orderApi';
import { Order } from 'src/app/model/Order';
import { OrderService } from 'src/app/services/order.service';

@Component({
  selector: 'app-order-detail',
  templateUrl: './order-detail.component.html',
  styleUrls: ['./order-detail.component.css'],
  providers: [OrderService]
})
export class OrderDetailComponent implements OnInit {
  id: number;
  order: Order;

  constructor(private route: ActivatedRoute, private router: Router, private orderService:OrderService) { }

  ngOnInit(): void {
    this.route.params
      .subscribe(
        (params: Params) => {
          this.id = parseInt(params['id']);
          this.loadOrder();
        }
      );
  }
  async loadOrder(){
    var api = new OrderApi();
    var result = await api.get(this.id);
    if(result.status == 200){
      this.order = this.orderService.convertJSONtoOrder(result.body);
    }
  }
  async cancelOrder(){
    var api = new OrderApi();
    var result = await api.cancel(this.id);
    if(result.status == 200){
      await this.loadOrder();
    }
  }
}
