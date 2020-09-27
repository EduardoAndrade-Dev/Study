import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AlertController } from '@ionic/angular';
import { Lista } from 'src/app/models/lista.model';
import { DeseosService } from '../../services/deseos.service';

@Component({
  selector: 'app-listas',
  templateUrl: './listas.component.html',
  styleUrls: ['./listas.component.scss'],
})
export class ListasComponent implements OnInit {

  @Input() selectedTab = '1';

  constructor(public deseosService: DeseosService,
              private router: Router) { }

  ngOnInit() {}

  listaSeleccionada(lista: Lista){
    this.router.navigateByUrl(`/tabs/tab${this.selectedTab}/agregar/${lista.id}`);

  }

}
