import { Routes } from '@angular/router';
import { DonutsComponent } from './donuts/donuts.component';
import { DevsComponent } from './famous-people/famous-people.component';

export const routes: Routes = [
    {path: '', component:DonutsComponent},
    {path: '', component:DevsComponent}
];
