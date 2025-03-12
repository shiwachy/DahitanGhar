import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { NavBarComponent } from "./nav-bar/nav-bar.component";
import { AvatarModule } from 'primeng/avatar';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DialogModule } from 'primeng/dialog';
import { LoginComponent } from "./auth/login/login.component";
import { AuthClient } from './dgApiClient';
import { HttpClient } from '@angular/common/http';
import { AuthService } from './shared/auth.service';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ButtonModule, NavBarComponent,
    AvatarModule,
    CommonModule,
    FormsModule,
    DialogModule, LoginComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  providers: [AuthClient, AuthService]
})
export class AppComponent {
  public isMenubarVisible: boolean = false;
  isLoginPageVisible: boolean = false;

  ToggleMenuBar() {
    this.isMenubarVisible = !this.isMenubarVisible;
  }

  OnClickBodyPage() {
    this.isMenubarVisible = false;
  }

  ShowLoginPage() {
    this.isLoginPageVisible = true;
  }
}
