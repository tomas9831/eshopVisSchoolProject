import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';
import { Game } from './../_models/game';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private productUrl = 'https://localhost:44364/api/Game';

  constructor(private http: HttpClient) {}

  getProducts(): Observable<Game[]> {
    return this.http.get<Game[]>(this.productUrl).pipe(
      tap(data => console.log('All: ' + JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  getProduct(id: string): Observable<Game | undefined> {
    return this.getProducts().pipe(
      map((products: Game[]) => products.find(p => p.name === id))
    );
  }

  private handleError(err: HttpErrorResponse) {
    let errMessage = '';
    if (err.error instanceof ErrorEvent) {
      errMessage = 'An error occurred: ${err.error.message}';
    } else {
      errMessage =
        'Server returned code: ${err.status}, error message is: ${err.message}';
    }
    return throwError(errMessage);
  }
}
