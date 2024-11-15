import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { PanelMenuModule } from 'primeng/panelmenu';
@Component({
  selector: 'app-nav-bar',
  standalone: true,
  imports: [PanelMenuModule],
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.css'
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
