import { Injectable, Inject } from '@angular/core';
import { catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DbService {


  myAppUrl = "";

  constructor(private _http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    this.myAppUrl = baseUrl;
    
  }
  saveData(data, url: string) {
    return this._http
      .post(this.myAppUrl + url, data)
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
 

}
