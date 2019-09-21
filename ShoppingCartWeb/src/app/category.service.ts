import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private httpClient:HttpClient) { }
 GetCategories(){

     return this.httpClient.get("http://localhost:2881/api/Category");
  }
}
