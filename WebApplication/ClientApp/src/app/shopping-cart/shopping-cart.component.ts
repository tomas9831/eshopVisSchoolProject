import { Component, OnInit } from "@angular/core";
import { OrderItem } from "../_models/orderitem";
import { Router, ActivatedRoute } from "@angular/router";
import { Game } from "../_models/game";

@Component({
  selector: "app-shopping-cart",
  templateUrl: "./shopping-cart.component.html",
  styleUrls: ["./shopping-cart.component.css"]
})
export class ShoppingCartComponent implements OnInit {
  orderItem: OrderItem;
  orderItems: OrderItem[];
  game: Game;
  totalPrice: number;
  price: number;
  buyNew: boolean;
  deliveryType: string;
  itemType: string;
  constructor(private router: Router, private route: ActivatedRoute) {}

  ngOnInit() {
    const param = this.route.snapshot.paramMap.get("buy");
    this.buyNew = JSON.parse(param);
    console.log(this.buyNew);
  }
  onContinue() {}
  onBack() {
    this.router.navigate(["/"]);
  }
  prepareOrders() {
    this.orderItem.name = this.game.name;
    this.orderItem.gameId = this.game.id;
    this.orderItem.deliveryType = this.deliveryType;
    this.orderItem.itemType = this.itemType;
    this.orderItem.price = this.totalPrice;
  }
}
