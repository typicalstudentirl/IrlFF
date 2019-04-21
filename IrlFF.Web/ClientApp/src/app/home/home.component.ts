import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { JwtHelper } from 'angular2-jwt';
import { HomeService } from './home.service'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})


export class HomeComponent implements OnInit {
  public players: Player[]
  public goalkeepers: Player[]
  public defenders: Player[]
  public midfielders: Player[]
  public forwards: Player[]

  constructor(private http: HttpClient, @Inject('BASE_URL') public baseUrl: string, public svc: HomeService, private jwtHelper: JwtHelper) { }

  ngOnInit() {
    // Check JWT token exists in cache
    var token = localStorage.getItem("jwt");
    // if token == null decodeToken throws a console error here.
    var decodedToken = this.jwtHelper.decodeToken(token)
    // Get team where team.userid = token.userid
    this.http.get<Player[]>(this.baseUrl + 'api/TeamPlayer/' + decodedToken.UserId)
      .subscribe(result => {
        this.players = result;
      }, error => console.error(error));

    this.svc.getGoalkeepers()
      .subscribe(gks => {
        this.goalkeepers = gks;
      }, error => console.log(error));

    this.svc.getDefenders()
      .subscribe(dfs => {
        this.defenders = dfs;
      }, error => console.log(error));

    this.svc.getMidfielders()
      .subscribe(mfs => {
        this.midfielders = mfs;
      }, error => console.log(error));

    this.svc.getForwards()
      .subscribe(frds => {
        this.forwards = frds;
      }, error => console.log(error));
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
