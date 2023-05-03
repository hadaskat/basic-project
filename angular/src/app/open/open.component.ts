import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-open',
  templateUrl: './open.component.html',
  styleUrls: ['./open.component.scss']
})
export class OpenComponent {
  constructor(private router: Router) {        
  }
  sortbc(){
    this.router.navigate(['/sortbc']);
  }
}
