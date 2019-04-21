import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RegisterService } from './register.service'
import { Router } from "@angular/router";
import { HttpHeaders, HttpClient } from '@angular/common/http';
import 'rxjs/operators';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html'
})

export class RegisterComponent implements OnInit {
  registerForm: FormGroup;
  submitted = false;
  unique: boolean;
  users: User[];
  newUserId: number;

  constructor(private router: Router, private http: HttpClient, private formBuilder: FormBuilder, public svc: RegisterService, @Inject('BASE_URL') public baseUrl: string) { }

  ngOnInit() {


    this.svc.getUsernames()
      .subscribe(res => {
        this.users = res;
      }),
      error => console.error(error);

    this.registerForm = this.formBuilder.group({
      foreName: ['', Validators.required],
      surName: ['', Validators.required],
      userName: ['', [Validators.required, Validators.minLength(6)]],
      password: ['', [Validators.required, Validators.minLength(6)]],
      teamName: ['', [Validators.required, Validators.minLength(6)]]
    });
  }

  // getter for easy access to form fields
  get f() { return this.registerForm.controls; }

  onSubmit() {
    this.submitted = true;
    this.unique = true;

    for (let i = 0; i < this.users.length; i++) {
      if (this.users[i].userName.toLowerCase() === this.registerForm.value.username) {
        this.unique = false;
      }
    }

    if (this.registerForm.invalid) {
      return;
    }

    if (!this.unique) {
      alert('The username ' + this.registerForm.value.userName + ' is taken, please choose another');
      return;
    }
    else {
      // Post to register user
      // stringify Form details
      let credentials = JSON.stringify(this.registerForm.value);
      // http POST
      this.svc.register_User(credentials);
      //end post
    }
  }
}

interface User {
  id: number;
  userName: string;
  password: string;
  surName: string;
  foreName: string;
  teamName: string;
}

interface Team {
  foreName: string;
  surName: string;
  teamName: string;
}
