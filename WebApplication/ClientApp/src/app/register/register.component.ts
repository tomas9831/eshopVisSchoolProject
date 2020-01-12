import { Component, OnInit, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { User } from '../_models/user';
import { UserserviceService } from '../_services/userservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user: User;
  registerForm: FormGroup;
  constructor(
    private _fb: FormBuilder,
    private router: Router,
    public http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private userService: UserserviceService,
  ) {
    this.registerForm = this._fb.group({
      id: 0,
      email: [''],
      name:[''],
      surname:[''],
      phone: [''],
      adress: [''],
      birthdate: [''],
      verified: false,
      password: [''],
      userType: ['customer'],
    })

   }

  ngOnInit() {
  }
  public addUser(user: User, url: string) {
    this.http.post<User>(url,user);
    console.log("posted");
  }


  get f() {
    return this.registerForm.controls;
  }
  public submitForm() {
    this.userService.saveUser(this.registerForm.value);
    this.router.navigate(['/']);
  }

}
