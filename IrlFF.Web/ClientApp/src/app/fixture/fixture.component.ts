import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fixture',
  templateUrl: './fixture.component.html'
})
export class FixtureComponent {
  public fixtures: Fixture;
  public p: number = 15;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Fixture>(baseUrl + 'api/Fixture/').subscribe(result => {
      this.fixtures = result;
    }, error => console.error(error));
  }
}

interface Fixture {
  id: number;
  matches: Match[];
}

interface Match {
  id: number;
  homeClub: string;
  awayClub: string;
  date: Date;
  location: string;
  fixtureId: number;
}
