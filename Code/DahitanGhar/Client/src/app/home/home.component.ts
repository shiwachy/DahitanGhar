import { Component, OnInit } from '@angular/core';
import { CarouselModule } from 'primeng/carousel';
import { ServiceCardComponent } from "./service-card/service-card.component";
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
  imports: [CarouselModule, ServiceCardComponent]
})
export class HomeComponent implements OnInit {
  products: string[] = ["img1.jpg", "img2.jpg", "img3.jpg", "img4.jpg"];

  responsiveOptions: any[] | undefined;

  ngOnInit(): void {

  }
}
