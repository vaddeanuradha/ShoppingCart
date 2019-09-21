import { Component } from '@angular/core';
import {enableProdMode} from '@angular/core';
import { environment } from 'src/environments/environment';
if (environment.production){
  enableProdMode();
}
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ShoppingCartWeb';
}
