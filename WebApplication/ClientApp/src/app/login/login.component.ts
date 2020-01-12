import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Router } from '@angular/router';

import { from } from 'rxjs';
import { User } from '../_models/user';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;
  users: User[];
  loginError: boolean = false;

	constructor(
		private router: Router,
    http: HttpClient, 
    @Inject('BASE_URL') baseUrl: string, 
		) {
      http.get<User[]>(baseUrl + 'api/User').subscribe(result => {
        this.users = result;
        console.log(this.users);
      }, error => console.error(error));
    }

  ngOnInit() {
    this.initForm();
  }
  public initForm() {
    this.loginForm = new FormGroup({
      username: new FormControl(''),
			password: new FormControl(''),
    });
  }
  get f() {
    return this.loginForm.controls;
  }


  public submitForm() {
    console.log(this.loginForm.value);
    this.users.forEach(user => {
      if(user.email == this.loginForm.value.username && user.password == this.loginForm.value.password){
        console.log("sucess");
        let id = JSON.stringify(user.id);
        let email = JSON.stringify(user.email)
        let adress = JSON.stringify(user.adress)
        let verified = JSON.stringify(user.verified)
        localStorage.setItem('login', id);
        localStorage.setItem('email', email);
        localStorage.setItem('adress', adress);
        localStorage.setItem('verified',verified);
        console.log(localStorage.getItem('login'));
        console.log(localStorage.getItem('email'));
        this.redirect();
      }
      else{
        this.loginError=true;
      }
    });
    
  }

  private redirect() {
    this.router.navigate(["/"]);
  }
}
