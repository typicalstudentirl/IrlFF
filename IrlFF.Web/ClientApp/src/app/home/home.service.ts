import { Inject, Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelper } from 'angular2-jwt';
import { HttpClient, HttpParams, HttpHeaderResponse, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';

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

  public navToAdd(position) {
    this.router.navigate(["/" + position]);
  }

  public removePlayer(playerId) {
    // Check JWT token exists in cache
    var token = localStorage.getItem("jwt");
    // if token == null decodeToken throws a console error here.
    var decodedToken = this.jwtHelper.decodeToken(token)
    let userId = decodedToken.UserId;

    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
      }),
      body: {
        playerId: playerId,
        teamId: userId,
      },
    };

    return this.http.delete<boolean>(this.baseUrl + 'api/TeamPlayer/', options)
      .subscribe(
        result =>
          this.refresh()
     )
  }

  refresh(): void {
    window.location.reload();
  }

  addToTeam(playerId) {
    // Check JWT token exists in cache
    var token = localStorage.getItem("jwt");
    // if token == null decodeToken throws a console error here.
    var decodedToken = this.jwtHelper.decodeToken(token)
    let userId = decodedToken.UserId;

    const body = {
      teamId: userId,
      playerId: playerId
    };

    return this.http.post<TeamPlayer>(this.baseUrl + 'api/TeamPlayer/', body, {
      headers: new HttpHeaders({
        //"Authorization": "Bearer " + token,
        "Content-Type": "application/json"
      })
    }).subscribe(
      result => {
        this.router.navigate(["/"]);
      }
    ), error => console.log(error)
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
