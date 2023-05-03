import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { DividerModule } from 'primeng/divider';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './components/products/products.component';
import {HttpClient, HttpClientModule} from '@angular/common/http';
import { HomepageComponent } from './homepage/homepage.component';
import {InputTextModule} from 'primeng/inputtext';
import {ButtonModule} from 'primeng/button';
import {FormsModule} from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { OpenComponent } from './open/open.component';
import { RouterModule } from '@angular/router';
import {DialogModule} from 'primeng/dialog';
import { AvatarModule } from 'primeng/avatar';
import { SortbcComponent } from './sortbc/sortbc.component';
import { RestaurantComponent } from './restaurant/restaurant.component';
import { CardModule } from 'primeng/card';
import {AvatarGroupModule} from 'primeng/avatargroup';
import {AccordionModule} from 'primeng/accordion';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    HomepageComponent,
    OpenComponent,
    SortbcComponent,
    RestaurantComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    InputTextModule,
    ButtonModule,
    FormsModule,
    BrowserAnimationsModule,
    DividerModule,
    DialogModule,
    AvatarModule,
    CardModule,
    AvatarGroupModule,
    AccordionModule,
    RouterModule.forRoot([
      {path: 'open', component: OpenComponent},
      {path:"", component:HomepageComponent},
      {path: 'sortbc', component: SortbcComponent},
      {path: 'restaurant', component: RestaurantComponent}
    ]),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
