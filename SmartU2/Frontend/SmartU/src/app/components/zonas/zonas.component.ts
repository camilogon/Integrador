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
  constructor(private zonasService: ZonasService){ 
    zonasService.get().subscribe((data: any) => this.Zonas = data);
  }

  ngOnInit() {
    this.zonas = this.zonasService.getZonas()
   /* for (var i = 0; i < this.Zonas.length; i++) {
      this.zonas[i].nombre=this.Zonas[i].nombre;
      this.zonas[i].espacios=this.Zonas[i].capaccidad;
    }*/
    console.log(this.zonas)
  }

}



  
