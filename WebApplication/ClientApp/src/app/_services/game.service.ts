import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import {  throwError } from "rxjs";
import { catchError } from "rxjs/operators";
import { Game } from '../_models/Game';


@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor(
    private http: HttpClient
  ) {
     this.getGames()
          .subscribe(data => this.games = data);
          console.log(this.games);
  }

  games: any;

  getGames() {
    return this.http.get('https://localhost:44364/api/Game');
  }
}
