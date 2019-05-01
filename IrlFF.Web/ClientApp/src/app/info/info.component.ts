import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html'
})
export class InfoComponent {



  getUrl() {
    return "url('https://i.imgur.com/mv8vgsl.jpg')";
  }
}
