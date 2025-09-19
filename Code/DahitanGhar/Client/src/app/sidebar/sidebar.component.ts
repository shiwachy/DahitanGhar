import { Component, EventEmitter, Output } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { MenuModule } from 'primeng/menu';
@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css',
  imports: [MenuModule]
})
export class SidebarComponent {

  //This event emitter is used to hide navbar when an action button is clicked.
  @Output() OnClickNavigationAction: EventEmitter<boolean> = new EventEmitter<boolean>();

  items: MenuItem[];
  constructor() {
    this.items = [
      {
        items: [
          {
            icon: 'pi pi-angle-double-left',
            id: 'icon_Action_ToggleMenu',
            command: () => this.NavigationActionClicked()
          },
          {
            label: 'Home',
            icon: 'pi pi-home',
            routerLink: '/home'
          },
          {
            label: 'About',
            icon: 'pi pi-question-circle',
            routerLink: '/about'
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

  NavigationActionClicked() {
    this.OnClickNavigationAction.emit(true);
  }
}
