import { RouterModule, Routes } from '@angular/router'
import { Component } from '@angular/core';
import { ZonaComponent } from '../app/components/zona/zona.component';
import { ZonasComponent } from '../app/components/zonas/zonas.component';
import { HomeComponent } from "../app/home/home.component"
import { AuthGuardService } from "../app/components/services/auth-guard.service";

const APP_ROUTES: Routes = [

  {
    path: 'zonas',
    component: ZonasComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'zonas/zona/:id',
    component: ZonaComponent,
    canActivate: [AuthGuardService]
  },
  { path: '**', pathMatch: 'full', component: HomeComponent }
];

export const APP_ROUTING = RouterModule.forRoot(APP_ROUTES)
