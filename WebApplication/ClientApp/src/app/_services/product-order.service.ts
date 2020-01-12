import { Injectable, Inject } from '@angular/core';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { singleOrder } from '../_models/singleOrder';



@Injectable({
  providedIn: 'root'
})
export class ProductOrderService {

  myAppUrl = "";
  singleOrder: singleOrder[];
  constructor(private _http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    this.myAppUrl = baseUrl;
    _http.get<singleOrder[]>(baseUrl + 'api/SingleOrder').subscribe(
      result => {
        this.singleOrder = result;
        console.log(this.singleOrder);
      },
      error => console.error(error)
    );
  }
  saveUser(user, url: string) {
    return this._http
      .post(this.myAppUrl + url, user)
      .pipe(
        catchError(err => {
          console.log("Handling error locally and rethrowing it...", err);
          return throwError(err);
        })
      )
      .subscribe(
        res => console.log("HTTP response", res),
        err => console.log("HTTP Error", err),
        () => console.log("HTTP request completed.")
      );
  }
  getSingleOrder(){
    return this.singleOrder;
  }

}
