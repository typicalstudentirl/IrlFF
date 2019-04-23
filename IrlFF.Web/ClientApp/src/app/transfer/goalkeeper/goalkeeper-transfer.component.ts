import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { HomeService } from '../../home/home.service'

@Component({
  selector: 'app-goalkeeper',
  templateUrl: './goalkeeper-transfer.component.html'
})

export class GoalkeeperTransferComponent implements OnInit {
  public goalkeepers: Player[];

  constructor(private http: HttpClient, private router: Router, @Inject('BASE_URL') public baseUrl: string, public svc: HomeService) { }
  ngOnInit() {
    this.goalkeepers = [];
    this.svc.getGoalkeepers()
      .subscribe(result => {
        this.goalkeepers = result;
      }
    ), error => { console.log(error) }
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
