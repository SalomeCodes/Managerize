import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-hour-register',
  templateUrl: './hour-register.component.html',
  styleUrls: ['./hour-register.component.scss']
})
export class HourRegisterComponent {

  hourRegistrationForm;

  constructor(
    private formBuilder: FormBuilder
  ) {
    this.hourRegistrationForm = this.formBuilder.group({
      starttime: '',
      endtime: '',
      break: '',
      description: ''
    });
  }

  registerHours(hourRegistrationForm){
    console.log(hourRegistrationForm);
  }
}
