import { Injectable } from '@angular/core'
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class ZonasService {
  private headers: HttpHeaders;
  private accessPointUrl: string = 'https://localhost:44317/api/Zonas';

  public get() {
    // Get all jogging data
    return this.http.get(this.accessPointUrl, {headers: this.headers});
  }

  public add(payload) {
    return this.http.post(this.accessPointUrl, payload, {headers: this.headers});
  }

  public remove(payload) {
    return this.http.delete(this.accessPointUrl + '/' + payload.id, {headers: this.headers});
  }

  public update(payload) {
    return this.http.put(this.accessPointUrl + '/' + payload.id, payload, {headers: this.headers});
  }
  private zonas: Zona[] = [
    {
      nombre: "Principial",
      espacios: 10,
      img: "../../assets/Principal.png"

    },
    {
      nombre: "",
      espacios: 0,
      img: "../../assets/Entrada.png"
   
    },
    {
      nombre: "",
      espacios: 0,
      img: "../../assets/BloqueC1.png"
     },
    {
      nombre: "",
      espacios: 0,
      img: "../../assets/BloqueC2.png"
    },
    {
      nombre: "",
      espacios: 0,
      img: "../../assets/BloqueC2.png"
    },
    {
      nombre: "",
      espacios: 0,
      img: "../../assets/BloqueC2.png"
    }
  ];


  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
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
