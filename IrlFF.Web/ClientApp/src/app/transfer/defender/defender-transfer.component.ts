import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { HomeService } from '../../home/home.service'
import { JwtHelper } from 'angular2-jwt';

@Component({
  selector: 'app-defender',
  templateUrl: './defender-transfer.component.html'
})

export class DefenderTransferComponent implements OnInit {
  public defenders: Player[];

  constructor(private http: HttpClient, private router: Router, private jwtHelper: JwtHelper, @Inject('BASE_URL') public baseUrl: string, public svc: HomeService) { }


  ngOnInit() {
    this.defenders = [];
    this.svc.getDefenders()
      .subscribe(result => {
        this.defenders = result;
      }
    ), error => { console.log(error)}
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

interface TeamPlayer {
  teamId: number;
  playerId: number;
}
