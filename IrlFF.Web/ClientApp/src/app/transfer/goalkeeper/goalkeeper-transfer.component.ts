import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-goalkeeper',
  templateUrl: './goalkeeper-transfer.component.html'
})
export class GoalkeeperTransferComponent { private router: Router }
