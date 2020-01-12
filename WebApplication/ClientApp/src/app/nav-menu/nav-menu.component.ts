import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  loggedEmail = '';

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  ngOnInit(){
    this.loggedEmail = localStorage.getItem('email');
  }
  logout(){
    localStorage.removeItem('id');
    localStorage.removeItem('email');
    location.reload(); 
  }
  
}
