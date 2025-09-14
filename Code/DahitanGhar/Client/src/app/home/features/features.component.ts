import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';

@Component({
  selector: 'features',
  templateUrl: './features.component.html',
  styleUrl: './features.component.css',
  imports: [CommonModule]
})
export class FeaturesComponent {
  @Input() imgPath: string = "";
  @Input() title: string = "";
  @Input() description = "";
  @Input() templateStyle = "ltr" //We have two options: ltr and rtl, which defines position of image and text in feature section.

}
