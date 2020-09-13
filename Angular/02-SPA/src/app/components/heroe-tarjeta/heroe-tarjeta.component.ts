import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-heroe-tarjeta',
  templateUrl: './heroe-tarjeta.component.html',
  styleUrls: ['./heroe-tarjeta.component.css']
})
export class HeroeTarjetaComponent implements OnInit {

  @Input() heroe: any = {};
  @Input() index: number;

  @Output() heroesSelecionado: EventEmitter<number>;

  constructor(private _router: Router)
  {
    this.heroesSelecionado = new EventEmitter();
   }

  ngOnInit(): void {
  }

  verHeroe(idx: number): void{
     this._router.navigate(['/heroe', idx]);
    
  }

}
