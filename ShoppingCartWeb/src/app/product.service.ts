import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private _http:HttpClient) { }
  GetProductsList(id:number){
    return this._http.get("http://localhost:2881/api/Product/GetProductsByCategory/"+id);
  }
  GetProductById(id:number)
  {
    return this._http.get("http://localhost:2881/api/productById/"+id);
  }
}
