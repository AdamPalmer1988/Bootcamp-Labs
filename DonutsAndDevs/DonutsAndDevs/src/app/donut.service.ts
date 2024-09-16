import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';
import { DonutResponse } from './models/DonutResponse';
import { DonutDetail } from './models/DonutDetails';

@Injectable({
  providedIn: 'root'
})
export class DonutService {

  constructor(private http:HttpClient) { }

  getDonuts() : Observable<DonutResponse> {
    return this.http.get<DonutResponse>("https://grandcircusco.github.io/demo-apis/donuts.json")
  }

  getDonutById(id:number) : Observable<DonutDetail> {
    return this.http.get<DonutDetail>(`https://grandcircusco.github.io/demo-apis/donuts/${id}.json`);
  }
}
