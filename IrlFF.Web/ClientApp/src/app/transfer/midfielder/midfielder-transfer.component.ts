import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { HomeService } from '../../home/home.service'
import { Pipe, PipeTransform } from '@angular/core';

@Component({
  selector: 'app-midfielder',
  templateUrl: './midfielder-transfer.component.html'
})

export class MidfielderTransferComponent implements OnInit {
  public midfielders: Player[];
  public searchMfs: string;
  public p: number = 1;

  constructor(private http: HttpClient, private router: Router, @Inject('BASE_URL') public baseUrl: string, public svc: HomeService) { }
  ngOnInit() {
    this.midfielders = [];
    this.svc.getMidfielders()
      .subscribe(result => {
        this.midfielders = result;
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
