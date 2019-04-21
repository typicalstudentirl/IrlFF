import { Component } from '@angular/core';
import { JwtHelper } from 'angular2-jwt';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

  constructor(private jwtHelper: JwtHelper) { }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  logOut() {
     localStorage.removeItem("jwt");
  }

  isUserAuthenticated() {
    let token: string = localStorage.getItem("jwt");
    if (token != null) {
      if (token && !this.jwtHelper.isTokenExpired(token)) {
        return true;
      }
      else {
        return false;
      }
    } else return false;

  }
}
