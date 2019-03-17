import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router'
import { ZonasService } from '../services/zonas.service'

@Component({
  selector: 'app-zona',
  templateUrl: './zona.component.html',
  styleUrls: ['./zona.component.css']
})
export class ZonaComponent {

  zona: any = {}
  constructor(private activatedRoute: ActivatedRoute,
    private _zonasService: ZonasService) {
    
    this.activatedRoute.params.subscribe(params => {
      console.log(this.zona)
      this.zona = this._zonasService.getZona(params['id'])
    })
  }

  

}
