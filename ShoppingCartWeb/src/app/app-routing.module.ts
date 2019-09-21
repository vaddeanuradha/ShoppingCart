import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ProductsListComponent} from './products-list/products-list.component'
import {ProductDetailsComponent} from './product-details/product-details.component'
import {CarouselComponent} from './carousel/carousel.component'
const routes: Routes = [
 // {path:"pr",pathMatch:"prefix",redirectTo:"products"},
  {path:"",pathMatch:"full",component:CarouselComponent},
  {path:"Product/:id",component:ProductsListComponent},
  {path:"productDetails/:id",component:ProductDetailsComponent} 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
