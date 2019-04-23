import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { JwtHelper } from 'angular2-jwt';
import { HomeService } from './home.service'
import { tap, map, switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})


export class HomeComponent implements OnInit {
  public players: Player[];
  public goalkeepers: Player[];
  public defenders: Player[];
  public midfielders: Player[];
  public forwards: Player[];
  public resolved: boolean;

  constructor(private http: HttpClient, @Inject('BASE_URL') public baseUrl: string, public svc: HomeService, private jwtHelper: JwtHelper) { }

  ngOnInit() {
    // Check JWT token exists in cache
    var token = localStorage.getItem("jwt");
    // if token == null decodeToken throws a console error here.
    var decodedToken = this.jwtHelper.decodeToken(token)
    // Get team where team.userid = token.userid
    this.http.get<Player[]>(this.baseUrl + 'api/TeamPlayer/' + decodedToken.UserId)
      .subscribe(result => {
        this.resolved = false;
        this.goalkeepers = [];
        this.defenders = [];
        this.midfielders = [];
        this.forwards = [];
        for (let i = 0; i < result.length; i++) {
          if (result[i].position == 1) {
            this.goalkeepers.push(result[i]);
          }

          if (result[i].position == 2) {
            this.defenders.push(result[i]);
          }

          if (result[i].position == 3) {
            this.midfielders.push(result[i]);
          }

          if (result[i].position == 4) {
            this.forwards.push(result[i]);
          }
        } this.resolved = true;
      }, error => console.error(error));
    }
}

interface Player {
  id: number;
  forename: string;
  surname: string;
  totalPoints: number;
  position: Position;
  club: Club;
}

interface Club {
  clubId: number;
  clubName: string;
}

enum Position {
  Goalkeeper = 1,
  Defender = 2,
  Midfielder = 3,
  Forward = 4
}
