import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { DevsService } from '../devs.service';
import { DevsResponse } from '../models/DevsResponse';


@Component({
  selector: 'app-famous-people',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './famous-people.component.html',
  styleUrl: './famous-people.component.css'
})
export class DevsComponent {
  devService = inject(DevsService)
  devs: any;

  devList:DevsResponse = {
    complete : [],
    tiny : []
  };

  ngOnInit(){
    this.loadDevs();
  }

  loadDevs() : void {
    this.devService.getDevs().subscribe(      //subscribe is making the call to the API
      (devs) => {
      this.devList = devs;
      console.log("dev list",  this.devList);
    } 
    )
  }
}
