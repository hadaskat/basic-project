import { Component } from '@angular/core';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent {
  constructor(private prodService:ProductService){
     this.getProducts();  
}

getProducts() {
  this.prodService.getP().subscribe((data) => {
    console.log(data);
  });
}}
