import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from "./header/header.component";
import { SidebarComponent } from "./sidebar/sidebar.component";
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [HeaderComponent,
    SidebarComponent,
    CommonModule,
    RouterOutlet]
})
export class AppComponent {
  isSidebarVisible: boolean = false;

  ToggleSidebar() {
    this.isSidebarVisible = !this.isSidebarVisible;
  }
}
