import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './components/header/header.component';
import { ZonasComponent } from './components/zonas/zonas.component';
import { FooterComponent } from './components/footer/footer.component';
import { ZonaComponent } from './components/zona/zona.component';
import {
  MatButtonModule,
  MatCardModule,
  MatToolbarModule,
  MatGridList,
  MatGridListModule
} from '@angular/material';

//Routing
import { APP_ROUTING } from '../app/app.routes'

//Servicios
import { ZonasService } from '../app/components/services/zonas.service';
import { AuthService } from '../app/components/services/auth.service';
import { AuthGuardService } from '../app/components/services/auth-guard.service'
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    ZonasComponent,
    FooterComponent,
    ZonaComponent
  ],
  imports: [
    BrowserModule,
    APP_ROUTING,
    BrowserAnimationsModule,
    MatCardModule,
    MatToolbarModule,
    MatButtonModule,
    MatGridListModule,
    HttpClientModule
  ],
  providers: [
    ZonasService,
    AuthService,
    AuthGuardService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
