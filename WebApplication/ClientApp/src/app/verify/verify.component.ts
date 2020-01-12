import { Component, OnInit } from '@angular/core';
import { RequestModel } from '../_models/verify';
import { DbService } from '../_services/db.service';
import { Router } from '@angular/router';
import { FormGroup, FormBuilder } from '@angular/forms';
import { ProductOrderService } from '../_services/product-order.service';

@Component({
  selector: 'app-verify',
  templateUrl: './verify.component.html',
  styleUrls: ['./verify.component.css']
})
export class VerifyComponent implements OnInit {

  constructor(private router: Router,private productService: ProductOrderService) {
   
  }
  ngOnInit() {
  }
  onVerify(){

    let requestData: RequestModel = new RequestModel();
    let id = localStorage.getItem('login');
    requestData.id = 0;
    requestData.userid = +id;
    requestData.request = 'verify';
    console.log(requestData);
    this.productService.saveUser(requestData,'api/Requests');
    this.router.navigate(['/']);
  }

}
