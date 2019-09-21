import { Component, OnInit } from '@angular/core';
import {ProductService} from './../product.service';
import {ActivatedRoute, Params} from '@angular/router'
import { Subscription } from 'rxjs';
@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {
  
  constructor(private productService:ProductService,private route:ActivatedRoute) { }
  public productDetails;
  public subscription;
  ngOnInit() {
    var id:any;
    this.subscription= this.route.params.subscribe((params:Params)=>{
        this.productService.GetProductById(params.id).subscribe(data=>this.productDetails=data);
    });

  }
  ngOnDestroy()
  {
    this.subscription.unsubscribe();
  }

}
