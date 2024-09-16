import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../models/order';

@Injectable({
  providedIn: 'root'
})
export class RestaurantService {

  hostAddress = 'https://localhost:7258/api/'

  constructor(private http : HttpClient) { }

  getAllOrders(): Observable<Order[]>{
    return this.http.get<Order[]>(this.hostAddress + `Order`)
  }

  getOrderId(id : number): Observable<Order>{
    return this.http.get<Order>(this.hostAddress + `Order/${id}`)
  }

  createOrder(order : Order): Observable<Order>{
    const params = {
      id: order.id,
      description: order.description,
      restaurant: order.restaurant,
      rating: order.rating,
      orderAgain: order.orderAgain
    }

    return this.http.post<Order>(this.hostAddress + `Order/${order.id}`, {params})
  }

  updateOrder(order : Order): Observable<Order>{
    const params = {
      id: order.id,
      description: order.description,
      restaurant: order.restaurant,
      rating: order.rating,
      orderAgain: order.orderAgain
    }

    return this.http.put<Order>(this.hostAddress + `Order/${order.id}`, {params})
  }

  deleteOrder(order : Order) {
    return this.http.delete(this.hostAddress + `Order/${order.id}`)
  }
}

