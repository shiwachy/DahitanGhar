import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { NavBarComponent } from "./nav-bar/nav-bar.component";
import { AvatarModule } from 'primeng/avatar';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ButtonModule, NavBarComponent, AvatarModule, CommonModule, FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  public isMenubarVisible: boolean = false;


  ToggleMenuBar() {
    this.isMenubarVisible = !this.isMenubarVisible;
  }

  OnClickBodyPage() {
    this.isMenubarVisible = false;
  }
}
