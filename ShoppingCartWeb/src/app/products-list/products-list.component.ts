import { Component, OnInit } from '@angular/core';
import {ProductService} from './../product.service';
import {ActivatedRoute, Params} from '@angular/router' 
import { Subscription } from 'rxjs';
@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.css']
})
export class ProductsListComponent implements OnInit {

  constructor(private _productService:ProductService,private _route:ActivatedRoute){}
  public ProductList:any;
  public subscription:Subscription;
  ngOnInit() {
    var id:any;
    this.subscription=this._route.params.subscribe((params:Params)=>{
      console.log(params);
      this._productService.GetProductsList(params.id).subscribe(data=>this.ProductList=data);
    });
  }
  ngOnDestroy()
  {
     this.subscription.unsubscribe();
  }
}
