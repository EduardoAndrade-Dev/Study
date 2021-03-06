import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';

import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';
import { HeroesComponent } from './components/heroes/heroes.component';
import { HeroeComponent } from './components/heroe/heroe.component';
import { HeroesResultComponent } from './components/heroes-result/heroes-result.component';
import { PipesComponent } from './components/pipes/pipes.component';


const APP_ROUTES: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'about', component: AboutComponent },
    { path: 'pipes', component: PipesComponent },
    { path: 'heroes', component: HeroesComponent },
    { path: 'heroe/:id', component: HeroeComponent },
    { path: 'heroeResult/:termino', component: HeroesResultComponent },
    { path: '**', pathMatch: 'full', redirectTo: 'home' },
];


export const APP_ROUTING =  RouterModule.forRoot(APP_ROUTES);
