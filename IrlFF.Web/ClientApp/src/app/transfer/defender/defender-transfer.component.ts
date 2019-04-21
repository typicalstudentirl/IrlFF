import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-defender',
  templateUrl: './defender-transfer.component.html'
})
export class DefenderTransferComponent { private router: Router }
