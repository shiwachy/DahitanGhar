import { Component } from '@angular/core';
import { PanelMenuModule } from 'primeng/panelmenu';
@Component({
  selector: 'header-section',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
  imports: [PanelMenuModule]
})
export class HeaderComponent {

}
