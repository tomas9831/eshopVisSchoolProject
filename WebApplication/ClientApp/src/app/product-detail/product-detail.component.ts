import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from '../_services/product.service';
import { Game } from '../_models/game';
@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {
  product: Game;
  errorMessage: string;
  buyNew: boolean = true;
  buyOld: boolean;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private productService: ProductService
  ) {}

  ngOnInit() {
    const param = this.route.snapshot.paramMap.get('id');
      this.getProduct(param);
  }

  getProduct(id: string) {
    this.productService.getProduct(id).subscribe({
      next: product => (this.product = product),
      error: err => (this.errorMessage = err)
    });
  }
  onBuy(){
    this.router.navigate(['/cart', this.buyNew]);
  }
  toggleNew(){
    this.buyNew = true;
  }
  toggleUsed(){
    this.buyNew = false;
  }

}
