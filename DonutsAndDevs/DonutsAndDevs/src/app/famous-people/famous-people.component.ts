import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { DevsService } from '../devs.service';
import { Devs } from '../models/devs';


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

  ngOnInit(){
    this.loadDevs();
  }

  devList:Devs[] = [];
  
  loadDevs() : void {
    this.devService.getDevs().subscribe(      //subscribe is making the call to the API
      (devs) => {
      this.devList = devs.results;
      console.log(devs); 
    } 
    )
  }

}
