import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsListComponent } from './products-list/products-list.component';
import {HttpClientModule} from '@angular/common/http';
import {ProductService} from './product.service';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { OptionsSectionComponent } from './options-section/options-section.component';
import { CategoryComponent } from './category/category.component';
import {CategoryService} from './category.service';
import { CarouselComponent } from './carousel/carousel.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsListComponent,
    ProductDetailsComponent,
    OptionsSectionComponent,
    CategoryComponent,
    CarouselComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [ProductService,CategoryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
