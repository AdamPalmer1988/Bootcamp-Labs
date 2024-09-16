import { Component } from '@angular/core';
import { inject } from '@angular/core/testing';
import { DevsService } from '../devs.service';
import { Devs } from '../models/devs';
import { CommonModule } from '@angular/common';

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
  
}
