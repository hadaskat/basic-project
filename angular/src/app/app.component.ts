import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  displayMaximizable: boolean=false;
  constructor(private router: Router) {        
  }

  navigate() {
    this.open=true;
    this.enter=false;
    this.router.navigate(['/open']);
    this.displayMaximizable = false;
}

signin(){
  this.signin1=true;
  console.log(this.signin1);
}
signinClouse(){
  this.signin1=false;
  console.log(this.signin1);
}
signup(){
  this.signup1=true;
  this.signin1=false;
  console.log(this.signup1);
}
signupClouse(){
  this.signup1=false;
  console.log(this.signup1);
}

  open:boolean=false;
  enter:boolean=true;
  address1:boolean=false;
  signin1:boolean=false;
  signup1:boolean=false;
  value: string="";
  value2: string="";
  showMaximizableDialog() {
    this.displayMaximizable = true;
}
}
