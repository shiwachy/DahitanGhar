import { Component } from '@angular/core';
import { CarouselModule } from 'primeng/carousel';
import { AuthService } from '../shared/auth.service';


@Component({
  selector: 'home-page',
  standalone: true,
  imports: [CarouselModule],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {
  isAdminLoggedIn: boolean = false;
  homePageIntroText: string = "";
  products: any;

  responsiveOptions: any[] | undefined;

  constructor(private authService: AuthService) {
    this.isAdminLoggedIn = this.authService.isAdminLoggedIn;
  }

  //getUsers() {
  //  this.authClient.auth_GetUsers().subscribe();
  //}

  CarouselConfigurations() {
    this.responsiveOptions = [
      {
        breakpoint: '1199px',
        numVisible: 1,
        numScroll: 1
      },
      {
        breakpoint: '991px',
        numVisible: 2,
        numScroll: 1
      },
      {
        breakpoint: '767px',
        numVisible: 1,
        numScroll: 1
      }
    ];

  }

}