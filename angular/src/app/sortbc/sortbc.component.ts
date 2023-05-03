import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sortbc',
  templateUrl: './sortbc.component.html',
  styleUrls: ['./sortbc.component.scss']
})
export class SortbcComponent {
  constructor(private router: Router) {        
  }
  open(){
    this.router.navigate(['/restaurant']);
  }
}
