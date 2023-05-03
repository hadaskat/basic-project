import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../models/Product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http:HttpClient) {  
  }
  apiUrl="https://localhost:7136/api/Product";
  
  getP(){
    return this.http.get(this.apiUrl);
  }
  addP(product:Product){
    return this.http.post(this.apiUrl,product);
  }
  updateP(product:Product,id:any){
    return this.http.put(this.apiUrl+"/"+id,product);
  }
  deleteP(id:any){
    return this.http.delete(this.apiUrl+"/"+id);
  }
}
