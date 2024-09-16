import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { DonutService } from '../donut.service';
import { Donut } from '../models/donut';
import { DevsComponent } from '../famous-people/famous-people.component';

@Component({
  selector: 'app-donuts',
  standalone: true,
  imports: [CommonModule, DevsComponent],
  templateUrl: './donuts.component.html',
  styleUrl: './donuts.component.css'
})
export class DonutsComponent {
  donutService = inject(DonutService)
  donuts: any;

  ngOnInit(){
    this.loadDonuts();
  }

  donutList:Donut[] = [];

  loadDonuts() : void {
    this.donutService.getDonuts().subscribe(      //subscribe is making the call to the API
      (donuts) => {
      this.donutList = donuts.results;
      console.log(donuts); 
    } 
    )
  }
}
