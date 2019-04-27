import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Router } from "@angular/router";
import { NgForm } from '@angular/forms';

@Component({
  selector: 'login',
  templateUrl: './login.component.html'
})
export class LoginComponent {
  invalidLogin: boolean;
  constructor(private router: Router, private http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  login(form: NgForm) {
    let credentials = JSON.stringify(form.value);
    this.http.post(this.baseUrl + "api/user/", credentials, {
      headers: new HttpHeaders({
        "Content-Type": "application/json"
      })
    }).subscribe(response => {
      let user = (<any>response);
      localStorage.setItem("currentUser", JSON.stringify(user));
      this.invalidLogin = false;
      this.router.navigate(["/"]);
    }, err => {
      this.invalidLogin = true;
    });
  }
}

