import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CartComponent } from './cart/cart.component';
import { CategoryListComponent } from './category-list/category-list.component';
import { HomepageComponent } from './homepage/homepage.component';
import { LoginComponent } from './login/login.component';
import { MyaccountComponent } from './myaccount/myaccount.component';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { ProductListComponent } from './product-list/product-list.component';
import { RegisterComponent } from './register/register.component';
import { OrderListComponent } from './myaccount/order-list/order-list.component';
import { ProfileSettingComponent } from './myaccount/profile-setting/profile-setting.component';
import { FavorProductComponent } from './myaccount/favor-product/favor-product.component';
import { OrderDetailComponent } from './myaccount/order-detail/order-detail.component';
import { AboutComponent } from './about/about.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { HotListComponent } from './hot-list/hot-list.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomepageComponent },
  { path: 'login', component: LoginComponent },
  { path: 'regist', component: RegisterComponent },
  { path: 'clothing-list', component: CategoryListComponent },
  { path: 'product/:id', component: ProductListComponent },
  { path: 'detail/:id', component: ProductDetailComponent },
  { path: 'myaccount', component: MyaccountComponent },
  { path: 'cart', component: CartComponent },
  { path: 'orderlist', component: OrderListComponent },
  { path: 'profileset', component: ProfileSettingComponent },
  { path: 'favorpro', component: FavorProductComponent },
  { path: 'orderdetail/:id', component: OrderDetailComponent },
  { path: 'about', component: AboutComponent },
  { path: 'checkout', component: CheckoutComponent },
  { path: 'hot', component: HotListComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
