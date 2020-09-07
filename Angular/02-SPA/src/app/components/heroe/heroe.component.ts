import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Heroe, HeroesService } from '../../services/heroes.services';
import { Router } from '@angular/router';

@Component({
  selector: 'app-heroe',
  templateUrl: './heroe.component.html',
  styleUrls: ['./heroe.component.css']
})
export class HeroeComponent implements OnInit {
  heroe: Heroe;

  // tslint:disable-next-line: variable-name
  constructor(private _activatedRoute: ActivatedRoute,
              private _heroesService: HeroesService,
              private _router: Router) {
    this._activatedRoute.params.subscribe(params => {
      this.heroe = this._heroesService.getHeroe(params.id);
      console.log(this.heroe);
    });


  }

  ngOnInit(): void {
  }

  gotoHeroes(): void{
    this._router.navigate(['heroes']);
  }

}
