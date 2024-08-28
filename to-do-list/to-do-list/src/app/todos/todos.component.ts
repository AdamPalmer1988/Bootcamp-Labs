import { Component } from '@angular/core';
import { Todo } from '../models/todo';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-todos',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './todos.component.html',
  styleUrl: './todos.component.css'
})
export class TodosComponent {
todo:Todo[] = [

  {id: 1, task: "Brush Teeth", duration: 2},
  {id: 2, task: "Get Dressed", duration: 5},
  {id: 3, task: "Make Breakfast", duration: 8},
  {id: 4, task: "Eat Breakfast", duration: 15}

];

removeTask(id:number): void{
  this.todo = this.todo.filter(todo => todo.id !== id);
}

onComplete(todo:Todo): void {
  this.todo = this.todo.filter(t => t !== todo)
}
}
