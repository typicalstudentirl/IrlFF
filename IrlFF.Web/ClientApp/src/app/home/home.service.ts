import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Inject } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable()
export class HomeService {

  public goalkeepers: Player[]
  public defenders: Player[]
  public midfielders: Player[]
  public forwards: Player[]


  constructor(private http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

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
}

interface Player {
  id: number;
  forename: string;
  surname: string;
  totalPoints: number;
  position: Position;
}
