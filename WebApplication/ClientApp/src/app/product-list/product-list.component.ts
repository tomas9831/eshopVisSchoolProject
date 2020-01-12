import { Component, OnInit, Inject } from "@angular/core";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import { HttpClient, HttpResponse } from "@angular/common/http";
import { FormGroup, FormControl, FormBuilder } from "@angular/forms";
import { Game } from "../_models/game";
import { ProductOrderService } from "../_services/product-order.service";
import { chosenGame } from "../_models/chosenGame";
import { ProductOrder } from "../_models/productOrder";
import { singleOrder } from "../_models/singleOrder";
import { sample, delay } from "rxjs/operators";

@Component({
  selector: "app-product-list",
  templateUrl: "./product-list.component.html",
  styleUrls: ["./product-list.component.css"]
})
export class ProductListComponent implements OnInit {
  public gameList: Game[];
  singleOrder: singleOrder[];
  chosenGames: chosenGame[] = new Array();
  title: string = "Our products";
  imageWidth: number = 50;
  showImage: boolean = true;
  showTable: boolean = true;
  buyNew: boolean = true;
  itemAdded = false;
  loaded: boolean = false;
  filterText: string;
  errMessage: string;
  totalPrice: number = 0;
  deliveryB = true;
  shopB = false;
  cashB = false;
  cardB = true;
  verified = false;

  toggleImage(): void {
    this.showImage = !this.showImage;
  }
  toggleTable(): void {
    this.showTable = !this.showTable;
  }

  onProduct(productId: string): void {
    this.router.navigate(["/products", productId]);
  }
  constructor(
    private productService: ProductOrderService,
    private http: HttpClient,
    @Inject("BASE_URL") baseUrl: string,
    private router: Router
  ) {
    http.get<Game[]>(baseUrl + "api/Game").subscribe(
      result => {
        this.gameList = result;
      },
      error => console.error(error)
    );
    http.get<singleOrder[]>(baseUrl + "api/SingleOrder").subscribe(
      result => {
        this.singleOrder = result;
      },
      error => console.error(error)
    );
  }
  public ngOnInit() {}

  onBuy(item: Game, arg: String, pegi: Number) {
    if(pegi>17 && this.verified == false){
      this.router.navigate(['/verify']);
    }
    if(this.verified == true || pegi<18){
    this.itemAdded = true;
    let game = new chosenGame();
    game.id = item.id;
    game.name = item.name;
    game.availability = item.availability;
    if (arg == "new") {
      game.price = item.priceNew;
    }
    if (arg == "old") {
      game.price = item.priceOld;
    }

    this.chosenGames.push(game);
    this.calculatePrice();
    console.log(this.chosenGames);
  }
  }
  onOrder() {
    let total = this.calculatePrice();
    let n = localStorage.getItem("login");
    let id = +n;
    let sOrder: singleOrder = new singleOrder();

    sOrder.customerId = id;
    if (this.cardB == true) {
      sOrder.paymentType = "card";
    }
    if (this.cashB == true) {
      sOrder.paymentType = "cash";
    }
    sOrder.adress = localStorage.getItem("adress");
    if (this.deliveryB == true) {
      sOrder.deliveryType = "home";
    }
    if (this.shopB == true) {
      sOrder.deliveryType = "shop";
    }
    sOrder.price = total;
    console.log(sOrder);
    this.productService.saveUser(sOrder, "api/SingleOrder");
    
  }
  onOrder2() {
    let pOrder: ProductOrder = new ProductOrder();
    let orderId;
    let tmp = this.productService.getSingleOrder();
    tmp.forEach(e => {
      orderId = e.id;
    });
    orderId += 1;
    console.log("order id");
    console.log(orderId);
    this.chosenGames.forEach(game => {
      pOrder.productId = game.id;
      pOrder.orderId = orderId;
      this.productService.saveUser(pOrder, "api/ProductOrder");
    });
  }
  calculatePrice() {
    let total = 0;
    this.chosenGames.forEach(e => {
      total = total + e.price;
    });
    this.totalPrice = total;
    console.log(total);
    return total;
  }

  toggleCash() {
    this.cashB = true;
    this.cardB = false;
  }
  toggleCard() {
    this.cashB = false;
    this.cardB = true;
  }
  toggleDelivery() {
    this.deliveryB = true;
    this.shopB = false;
  }
  toggleShop() {
    this.deliveryB = false;
    this.shopB = true;
  }
}
