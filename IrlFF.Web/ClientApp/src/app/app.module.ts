import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

// App components
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FixtureComponent } from './fixture/fixture.component';
import { LeagueComponent } from './league/league.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';

// App services
import { AuthGuard } from './guards/auth-guard.service';
import { JwtHelper } from 'angular2-jwt';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgxPaginationModule } from 'ngx-pagination';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FixtureComponent,
    LeagueComponent,
    LoginComponent,
    RegisterComponent ,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    Ng2SearchPipeModule,
    NgxPaginationModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'fixture', component: FixtureComponent },
      { path: 'league', component: LeagueComponent, canActivate: [AuthGuard]},
      { path: 'login', component: LoginComponent },
      { path: 'register', component: RegisterComponent },
    ])
  ],
  providers: [AuthGuard, JwtHelper],
  bootstrap: [AppComponent]
})
export class AppModule { }
