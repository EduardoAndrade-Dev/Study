import { Component, OnInit } from '@angular/core';
import { HeroesService, Heroe } from '../../services/heroes.services';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-heroes-result',
  templateUrl: './heroes-result.component.html',
  styleUrls: ['./heroes-result.component.css']
})
export class HeroesResultComponent implements OnInit {

  heroes: Heroe[] = [];
  parametros: string = "";

  constructor(private _heroesService: HeroesService,
              private _activatedRoute: ActivatedRoute,
              private _router: Router) { }

  ngOnInit(): void {
    this._activatedRoute.params.subscribe(params => {
      this.parametros = params.termino;
      
      this.heroes = this._heroesService.buscarHeroes(params.termino);
    });
  }

  verHeroe(idx: number): void{
    this._router.navigate(['/heroe', idx]);
  }
}
