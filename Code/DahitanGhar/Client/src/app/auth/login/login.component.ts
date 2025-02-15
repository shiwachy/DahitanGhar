import { Component } from '@angular/core';
import { IconFieldModule } from 'primeng/iconfield';
import { InputIconModule } from 'primeng/inputicon';
import { InputTextModule } from 'primeng/inputtext';
import { CheckboxModule } from 'primeng/checkbox';
import { AuthClient, LoginCommand } from '../../dgApiClient';

@Component({
  selector: 'login',
  standalone: true,
  imports: [IconFieldModule, InputIconModule, InputTextModule, CheckboxModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  constructor(private _authClient: AuthClient) {

  }


  LogIn() {
    let cmd = new LoginCommand({
      userName: "admin@gmail.com",
      password: "pass@123"
    });
    this._authClient.auth_Login(cmd).subscribe({
      next: res => {
        console.log(res);
      }
    })
  }
}
