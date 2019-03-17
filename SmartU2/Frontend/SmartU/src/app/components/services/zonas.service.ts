import { Injectable } from '@angular/core'

@Injectable()
export class ZonasService {

  private zonas: Zona[] = [
    {
      nombre: "Tía",
      espacios: 10,
      img: "../../assets/mapa.png"

    },
    {
      nombre: "El Parque",
      espacios: 20,
      img: "../../assets/mapa.png"
   
    },
    {
      nombre: "Parrilla",
      espacios: 15,
      img: "../../assets/mapa.png"
     },
    {
      nombre: "Entrada",
      espacios: 20,
      img: "../../assets/mapa.png"
    },
    {
      nombre: "Bloque C",
      espacios: 20,
      img: "../../assets/mapa.png"
    },
    {
      nombre: "Principal",
      espacios: 20,
      img: "../../assets/mapa.png"
    }
  ];


  constructor() {
    console.log('Servicio zonas listo')
  }

  getZonas() {
    return this.zonas
  }

  getZona(idx: string) {
    return this.zonas[idx]
  }

}

export interface Zona {
  nombre: string
  espacios: number
  img: string
  
}
