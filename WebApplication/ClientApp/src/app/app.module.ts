import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ProductListComponent } from './product-list/product-list.component';
import { SearchFilterPipe } from './pipes/search-filter.pipe';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { StarComponent } from './star/star.component';
import { FooterComponent } from './footer/footer.component';
import { NavigationComponent } from './navigation/navigation.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ShoppingCartComponent } from './shopping-cart/shopping-cart.component';
import { VerifyComponent } from './verify/verify.component';
import { BuyoutComponent } from './buyout/buyout.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProductListComponent,
    SearchFilterPipe,
    StarComponent,
    ShoppingCartComponent,
    VerifyComponent,
    ProductDetailComponent,
    WelcomeComponent,
    FooterComponent,
    NavigationComponent,
    LoginComponent,
    RegisterComponent,
    BuyoutComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: ProductListComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'products', component: ProductListComponent },
      { path: 'register', component: RegisterComponent },
      { path: 'login' , component: LoginComponent },
      { path: 'products/:id', component: ProductDetailComponent },
      { path: 'welcome', component: WelcomeComponent },
      { path: 'cart', component: ShoppingCartComponent },
      { path: 'cart/:buy', component: ShoppingCartComponent },
      { path: 'verify', component: VerifyComponent },
      { path: 'buyout', component: BuyoutComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
