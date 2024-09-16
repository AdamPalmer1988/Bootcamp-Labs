import { Component, inject } from '@angular/core';
import { RestaurantService } from '../Services/restaurant-faves.service';
import { Order } from '../models/order';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-order-history',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule],
  templateUrl: './order-history.component.html',
  styleUrl: './order-history.component.css'
})
export class OrderHistoryComponent {
  restaurantFavesService = inject(RestaurantService)
  orders: Order[] = [];
id :number = 0;
description:string = '';
restaurant:string =  '';
rating:number = 0;
orderAgain:boolean = false;

ngOnInit(){
  this.getAllOrders();
}

  orderList:Order[] = [];

  getAllOrders() : void {
    this.restaurantFavesService.getAllOrders().subscribe(
      (orders) => {
        this.orderList = orders;
        console.log(orders);
      }
    )
  }

  deleteOrder(order:Order) : void {
    this.restaurantFavesService.deleteOrder(order);
  }

}
