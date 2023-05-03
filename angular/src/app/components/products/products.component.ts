import { Component, Input,OnInit } from '@angular/core';
import { Product } from 'src/app/models/Product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit{
  constructor(private prodService:ProductService){
    //  this.getProducts();  
}
  ngOnInit(){
    this.getProducts();
  }
prod:Product=new Product();
add1:boolean=false;
update1:boolean=false;
products:any;
ind:number=-1;

add(){
  this.add1=true;
 this.prod=new Product();
  console.log("add")
}

update(product:Product,i:number){
 this.update1=true;
 let tempProd = new Product(product.id,product.nameProduct,product.price,product.desc,product.date);
 this.prod = tempProd;
 this.ind = this.products.indexOf(product);
}

getProducts() {
  this.prodService.getP().subscribe((data) => {
    console.log(data);
    this.products=data;
  });
}

addProducts() {
  this.add1=false;
  this.prodService.addP(this.prod).subscribe((data) => {
    console.log(data);
    this.products.push(this.prod);
  });
}

updateProducts() {
  this.update1=false;
  this.prodService.updateP(this.prod,this.prod.id).subscribe((data) => {

  });
  this.products[this.ind] = this.prod;
}

deleteProducts(pro:Product) {

  let index = this.products.indexOf(pro);
  this.products.splice(index, 1);
  this.prodService.deleteP(pro.id).subscribe((data) => {
    console.log(data);
  });
}
}
