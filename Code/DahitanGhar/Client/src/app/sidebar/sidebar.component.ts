import { Component } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { MenuModule } from 'primeng/menu';
@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css',
  imports: [MenuModule]
})
export class SidebarComponent {
  items: MenuItem[];

  constructor() {
    this.items = [
      {
        items: [
          {
            label: 'Home',
            icon: 'pi pi-home'
          },
          {
            label: 'About',
            icon: 'pi pi-question-circle'
          }
        ]
      },
      {
        label: 'Admin',
        items: [
          {
            label: 'Settings',
            icon: 'pi pi-cog'
          },
          {
            label: 'Logout',
            icon: 'pi pi-sign-out'
          }
        ]
      }
    ];
  }
}
