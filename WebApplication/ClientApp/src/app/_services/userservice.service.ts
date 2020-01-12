import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import {  throwError } from "rxjs";
import { catchError } from "rxjs/operators";


@Injectable({
  providedIn: "root"
})
export class UserserviceService {
  myAppUrl = "";

  constructor(private _http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    this.myAppUrl = baseUrl;
    this.getUsers()
    .subscribe(data => this.users = data);
    console.log(this.users);
  }

  saveUser(user) {
    return this._http
      .post(this.myAppUrl + "api/User", user)
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
  users: any;

  getUsers() {
    return this._http.get('https://localhost:44364/api/User');
  }
}
