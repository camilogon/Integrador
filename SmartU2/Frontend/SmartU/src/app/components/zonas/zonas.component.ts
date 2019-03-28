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

  public Zonas: Array<any>;
  public Zona: any;

  zonas: Zona[] = [];
  constructor(private _zonasService: ZonasService){ 
    _zonasService.get().subscribe((data: any) => this.Zonas = data);
  }

  ngOnInit() {
    this.zonas = this._zonasService.getZonas()
    for (var _i = 0; _i < this.Zonas.length; _i++) {
      this.zonas[_i].nombre=this.Zonas[_i].nombre;
      this.zonas[_i].espacios=this.Zonas[_i].capaccidad;
  }
    console.log(this.zonas)
  }
}



  
