import { Component, OnInit, Inject } from '@angular/core';
import { Game } from '../_models/game';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-buyout',
  templateUrl: './buyout.component.html',
  styleUrls: ['./buyout.component.css']
})
export class BuyoutComponent implements OnInit {

  public gameList: Game[];
  GameID: number;
  BuyoutPrice: number;
  GameName: string;
  constructor(private http: HttpClient,@Inject("BASE_URL") baseUrl: string) { 
    http.get<Game[]>(baseUrl + "api/Game").subscribe(
      result => {
        this.gameList = result;
      },
      error => console.error(error)
    );
  }

  ngOnInit() {
  }
  submitSearch(){
    this.gameList.forEach(element => {
      if(element.id == this.GameID){
        this.BuyoutPrice = element.pricePurchase;
        this.GameName = element.name;
      }
      
    });
      
  }

}
