import { Component, OnInit } from '@angular/core';
import { AllMatModules } from '../../all-mat-modules.module';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-menu',
  imports: [
    AllMatModules,
    RouterModule
  ],
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.scss'
})
export class MenuComponent implements OnInit {

  ngOnInit(): void {}

}