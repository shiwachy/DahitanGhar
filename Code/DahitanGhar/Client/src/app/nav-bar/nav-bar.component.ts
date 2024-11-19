import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { MenuModule } from 'primeng/menu';
import { ToastModule } from 'primeng/toast';
import { SidebarModule } from 'primeng/sidebar';
import { ButtonModule } from 'primeng/button';
import { PanelMenuModule } from 'primeng/panelmenu';
@Component({
  selector: 'nav-bar',
  standalone: true,
  imports: [MenuModule, SidebarModule, ToastModule, ButtonModule, PanelMenuModule],
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.css',

})
export class NavBarComponent implements OnInit {
  publicNavBarItems: MenuItem[] | undefined;
  adminNavBarItems: MenuItem[] | undefined;
  ngOnInit() {
    this.InitializePublicMenuItems();
    this.InitializeAdminMenuItems();
  };

  InitializePublicMenuItems() {
    this.publicNavBarItems = [
      {
        label: 'Home',
        icon: 'pi pi-home',
        routerLink: 'home-page'
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
    ]
  }

  InitializeAdminMenuItems() {
    this.adminNavBarItems = [
      {
        label: 'Admin',
        icon: 'pi pi-user',
        items: [
          {
            label: 'Order Management',
            icon: 'pi pi-clipboard'
          },
          {
            label: 'Configuration',
            icon: 'pi pi-cog'
          },
          {
            label: 'Upload',
            icon: 'pi pi-cloud-upload'
          },
          {
            label: 'User Management',
            icon: 'pi pi-users'
          },
          {
            label: 'Log-Out',
            icon: 'pi pi-sign-out'
          }
        ]
      },
    ]
  }



}
