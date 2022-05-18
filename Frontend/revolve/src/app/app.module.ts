import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomepageComponent } from './homepage/homepage.component';
import { HeaderComponent } from './header/header.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { FooterComponent } from './footer/footer.component';
import { ProductListComponent } from './product-list/product-list.component';
import { CategoryListComponent } from './category-list/category-list.component';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { MyaccountComponent } from './myaccount/myaccount.component';
import { CartComponent } from './cart/cart.component';
import { OrderListComponent } from './myaccount/order-list/order-list.component';
import { ProfileSettingComponent } from './myaccount/profile-setting/profile-setting.component';
import { FavorProductComponent } from './myaccount/favor-product/favor-product.component';
import { OrderDetailComponent } from './myaccount/order-detail/order-detail.component';
import { AboutComponent } from './about/about.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { HotListComponent } from './hot-list/hot-list.component';



@NgModule({
  declarations: [
    AppComponent,
    HomepageComponent,
    HeaderComponent,
    LoginComponent,
    RegisterComponent,
    FooterComponent,
    ProductListComponent,
    CategoryListComponent,
    ProductDetailComponent,
    MyaccountComponent,
    CartComponent,
    OrderListComponent,
    ProfileSettingComponent,
    FavorProductComponent,
    OrderDetailComponent,
    AboutComponent,
    CheckoutComponent,
    HotListComponent,
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
