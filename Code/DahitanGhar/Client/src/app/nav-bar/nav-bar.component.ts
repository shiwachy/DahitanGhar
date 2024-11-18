import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { MenuModule } from 'primeng/menu';
import { ToastModule } from 'primeng/toast';
import { SidebarModule } from 'primeng/sidebar';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'app-nav-bar',
  standalone: true,
  imports: [MenuModule, SidebarModule, ToastModule, ButtonModule],
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.css',

})
export class NavBarComponent implements OnInit {
  menuItems: MenuItem[] | undefined;
  panelMenu: MenuItem[] | undefined;
  ngOnInit() {
    this.InitializeMenuItems();
  };

  InitializeMenuItems() {
    this.menuItems = [
      {
        label: 'Home',
        icon: 'pi pi-home',
      },
      {
        label: 'Menus',
        icon: 'pi pi-book'
      },
      {
        label: 'Our Services',
        icon: 'pi pi-star'
      },
      {
        label: 'Gallery',
        icon: 'pi pi-images'
      },
      {
        label: 'Contact Us',
        icon: 'pi pi-phone'
      },
      {
        label: 'Admin',
        icon: 'pi pi-user'
      },
    ]
  }





}
