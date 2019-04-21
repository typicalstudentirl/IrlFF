import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-fixture',
  templateUrl: './midfielder-transfer.component.html'
})
export class MidfielderTransferComponent { private router: Router }
