import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-forward',
  templateUrl: './forward-transfer.component.html'
})
export class ForwardTransferComponent { private router: Router }
