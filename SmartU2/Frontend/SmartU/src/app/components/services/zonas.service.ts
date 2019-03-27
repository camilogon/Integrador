import { Injectable } from '@angular/core'

@Injectable()
export class ZonasService {

  private zonas: Zona[] = [
    {
      nombre: "Principial",
      espacios: 10,
      img: "../../assets/Principal.png"

    },
    {
      nombre: "Entrada",
      espacios: 20,
      img: "../../assets/Entrada.png"
   
    },
    {
      nombre: "BLoque C1",
      espacios: 15,
      img: "../../assets/BloqueC1.png"
     },
    {
      nombre: "BloqueC2",
      espacios: 20,
      img: "../../assets/BloqueC2.png"
    },
    {
      nombre: "BloqueC2",
      espacios: 20,
      img: "../../assets/BloqueC2.png"
    },
    {
      nombre: "BloqueC2",
      espacios: 20,
      img: "../../assets/BloqueC2.png"
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
