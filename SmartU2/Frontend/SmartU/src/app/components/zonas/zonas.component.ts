import { Component, OnInit } from '@angular/core';
import { ZonasService, Zona } from '../services/zonas.service'

/*export interface Zona {
  cols: number;
  rows: number;
  text: string;
  border: string;
}*/

@Component({
  selector: 'app-zonas',
  templateUrl: './zonas.component.html',
  styleUrls: ['./zonas.component.css']
})
export class ZonasComponent implements OnInit{

  

  zonas: Zona[] = [];
  constructor(private _zonasService: ZonasService) { }

  ngOnInit() {
    this.zonas = this._zonasService.getZonas()
    console.log(this.zonas)
  }
}



  
