import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },
    { path: 'about', loadComponent: () => import("./about-us/about-us.component").then(m => m.AboutUsComponent) }
];
