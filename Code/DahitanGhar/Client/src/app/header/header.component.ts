import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { MenubarModule } from 'primeng/menubar';
@Component({
  selector: 'header-section',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
  imports: [MenubarModule]
})
export class HeaderComponent implements OnInit {
  items: MenuItem[] | undefined;

  ngOnInit() {
    this.items = [
      {
        label: 'Home',
        icon: 'pi pi-home'
      },
      {
        label: 'Dinning',
        icon: 'pi pi-star'
      },
      {
        label: 'About',
        icon: 'pi pi-envelope'
      }
    ]
  }
}
