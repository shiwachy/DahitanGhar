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

  constructor(private authClient: AuthClient, private http: HttpClient) {

  }

  getUsers() {
    this.http.get("https://localhost:7030/api/Auth/GetUsers").subscribe({
      next: res => {
        console.log(res);
      }, error: err => {
        console.log(err);
      }
    })
  }

  // getUsers1(){
  //   this.http.get("").subscribe();

  // }



}
