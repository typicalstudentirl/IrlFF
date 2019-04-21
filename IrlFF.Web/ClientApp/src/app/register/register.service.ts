import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { Response } from "@angular/http";
import 'rxjs/operators';
import 'rxjs/add/operator/map'
import { switchMap } from 'rxjs/operators';
import { Router } from '@angular/router';

@Injectable()
export class RegisterService {
  users: User[];
  unique: boolean;
  newTeam: string;
  newUserId: number;


  constructor(private router: Router, private http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  getUsernames(): Observable<User[]> {
    return this.http.get<User[]>(this.baseUrl + 'api/User/');
  }

  register_User(UserTeam) {
    this.http.post(this.baseUrl + 'api/register/', UserTeam, {
      headers: new HttpHeaders({
        "Content-Type": "application/json"
      })
    })
      .pipe(
        switchMap(result => {
          /* do something with result */
         // Parse string output JSON Object
          var newTeam = JSON.parse(UserTeam);
         // Add UserId to JSON Object
         newTeam.userId = result;
         // Stringify JSON Object for POST
         newTeam = JSON.stringify(newTeam);
          // POST - Create team w/UserId
          return this.http.post(this.baseUrl + 'api/team/', newTeam, {
            headers: new HttpHeaders({
              "Content-Type": "application/json"
            })
          })
      })
    ).subscribe(result => {
      this.router.navigate(["/"]);
    })
  }
}

interface User {
  id: number;
  userName: string;
  password: string;
  surName: string;
  foreName: string;
  teamName: string;
}
