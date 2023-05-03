import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http:HttpClient) {  
  }
  apiUrl="http://localhost:61135/Product";
  
  getP(){
    return this.http.get(this.apiUrl);
  }
}
