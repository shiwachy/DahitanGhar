import { Component, Input } from '@angular/core';

@Component({
  selector: 'service-card',
  imports: [],
  templateUrl: './service-card.component.html',
  styleUrl: './service-card.component.css'
})
export class ServiceCardComponent {
  @Input() cardIconPath: string = "";
  @Input() cardTitle: string = "";
  @Input() cardDescription = "";
}
