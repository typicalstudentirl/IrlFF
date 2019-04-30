import { Component } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  navbarOpen = false;

  toggleNavbar() {
    this.navbarOpen = !this.navbarOpen;
  }

  constructor(private jwtHelper: JwtHelperService) { }

  logOut() {
     localStorage.removeItem("currentUser");
  }

  isUserAuthenticated() {
    let token: string = localStorage.getItem("currentUser");
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
