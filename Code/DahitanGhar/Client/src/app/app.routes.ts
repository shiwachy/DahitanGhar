import { Routes } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },

    //TODO: This is for testing only. Need to remove it later.
    { path: 'header', component: HeaderComponent }
];
