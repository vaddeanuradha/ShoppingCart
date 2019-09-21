import { Component, OnInit } from '@angular/core';
import {CategoryService} from '../category.service';
@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  constructor(private categoryservice:CategoryService) { }
public CategoryList:any;
  ngOnInit() {
      this.categoryservice.GetCategories().subscribe((data)=>{
        this.CategoryList=data;
      });
     
    }

}
