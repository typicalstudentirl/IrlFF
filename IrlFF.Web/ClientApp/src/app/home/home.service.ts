import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Inject } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Router } from '@angular/router';
import { JwtHelper } from 'angular2-jwt';

@Injectable()
export class HomeService {

  public goalkeepers: Player[]
  public defenders: Player[]
  public midfielders: Player[]
  public forwards: Player[]
  public teamPlayer: TeamPlayer;


  constructor(private router: Router, private http: HttpClient, @Inject('BASE_URL') public baseUrl: string, private jwtHelper: JwtHelper) { }

  public getGoalkeepers(): Observable<any> {
    return this.http.get<Player[]>(this.baseUrl + 'api/Player/?orderby=Goalkeeper');
  }

  public getDefenders(): Observable<any> {
    return this.http.get<Player[]>(this.baseUrl + 'api/Player/?orderby=Defender')
  }

  public getMidfielders(): Observable<any> {
    return this.http.get<Player[]>(this.baseUrl + 'api/Player/?orderby=Midfielder')
  }

  public getForwards(): Observable<any> {
    return this.http.get<Player[]>(this.baseUrl + 'api/Player/?orderby=Forward')
  }

  public removePlayer(playerId) {
    // Check JWT token exists in cache
    var token = localStorage.getItem("jwt");
    // if token == null decodeToken throws a console error here.
    var decodedToken = this.jwtHelper.decodeToken(token)
    this.teamPlayer.playerId = playerId;
    this.teamPlayer.userId = decodedToken.UserId;
    return this.http.delete<boolean>(this.baseUrl + 'api/TeamPlayer/');
  }
}

interface Player {
  id: number;
  forename: string;
  surname: string;
  totalPoints: number;
  position: Position;
}

interface TeamPlayer {
  userId: number;
  playerId: number;
}
