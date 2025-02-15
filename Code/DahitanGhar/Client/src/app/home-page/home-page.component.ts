import { Component } from '@angular/core';
import { AuthClient, IAuthClient } from '../dgApiClient';
import { HttpBackend, HttpClient } from '@angular/common/http';

@Component({
  selector: 'home-page',
  standalone: true,
  imports: [],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {
  homePageIntroText: string = "";

  constructor() {

  }

  //getUsers() {
  //  this.authClient.auth_GetUsers().subscribe();
  //}


}
