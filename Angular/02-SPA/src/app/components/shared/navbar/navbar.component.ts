import { Component, OnInit } from '@angular/core';
import { Heroe } from 'src/app/services/heroes.services';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor(private _router: Router) { }

  ngOnInit(): void {
  }

  // tslint:disable-next-line: typedef
  buscarHeroe(term: string){
    this._router.navigate(['/heroeResult', term]);
  }

}
