import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DonutResponse } from './models/DonutResponse';
import { DevsResponse } from './models/DevsResponse';
import { DevsDetail } from './models/DevsDetails';

@Injectable({
  providedIn: 'root'
})
export class DevsService {

  constructor(private http:HttpClient) { }

  getDevs() : Observable<DevsResponse> {
    return this.http.get<DevsResponse>("https://grandcircusco.github.io/demo-apis/computer-science-hall-of-fame.json")
  }

  getDevsById(id:number) : Observable<DevsDetail> {
    return this.http.get<DevsDetail>(`https://grandcircusco.github.io/demo-apis/computer-science-hall-of-fame/${id}.json`);
  }
}
