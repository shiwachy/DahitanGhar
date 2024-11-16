import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api'; import { MenuModule } from 'primeng/menu';
import { SidebarModule } from 'primeng/sidebar';
import {
  trigger,
  style,
  animate,
  transition,
  // ...
} from '@angular/animations';
@Component({
  selector: 'app-nav-bar',
  standalone: true,
  imports: [MenuModule, SidebarModule],
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.css',
  animations: [
    trigger('slide', [
      transition(':enter', [
        // when ngif has true
        style({ transform: 'translateX(-100%)' }),
        animate(250, style({ transform: 'translateX(0)' }))
      ]),
      transition(':leave', [
        // when ngIf has false
        animate(250, style({ transform: 'translateX(-100%)' }))
      ])
    ])
  ]
})
export class NavBarComponent implements OnInit {
  menuItems: MenuItem[] | undefined;

  ngOnInit() {
    this.menuItems = [
      {
        label: 'Home',
        icon: 'pi pi-home',
      },
      {
        label: 'Our Services',
        icon: 'pi pi-star'
      },
      {
        label: 'Menus',
        icon: 'pi pi-star'
      },
      {
        label: 'Bookings',
        icon: 'pi pi-star'
      },
      {
        label: 'Gallery',
        icon: 'pi pi-star'
      },
      {
        label: 'Contact Us',
        icon: 'pi pi-star'
      },

    ]
  }
}
