import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Pipe, PipeTransform } from '@angular/core';

@Component({
  selector: 'app-league',
  templateUrl: './league.component.html'
})
export class LeagueComponent {
  public teams: Team[];
  public leagueSearch: string;
  public p: number = 1;

  constructor(private http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }
  ngOnInit() {
    let token = localStorage.getItem("jwt");
    this.http.get<Team[]>(this.baseUrl + 'api/Team/?orderBy=TotalPoints', {
      headers: new HttpHeaders({
        "Authorization": "Bearer " + token,
        "Content-Type": "application/json"
      })
    }).subscribe(result => {
      this.teams = result;
      // set the rank to allow for pagination
      for (let i = 0; i < result.length; i++) {
        result[i].rank = i + 1;
      }
    }, error =>
          console.error(error));
  }
}

interface Team {
  id: number;
  foreName: string;
  surName: string;
  teamName: string;
  weekPoints: number;
  totalPoints: number;
  userId: number;
  rank: number;
}
