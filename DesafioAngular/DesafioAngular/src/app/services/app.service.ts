import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { CalculoCdb } from '../models/calculo-cdb';
import { Observable } from 'rxjs';

var httpOptions = { headers: new HttpHeaders({ "Content-Type": "application/json" }) };

@Injectable({
  providedIn: 'root'
})

export class AppService {
  calculoCdbUrl = 'http://localhost:32740/api/CalculoCDB?';

  constructor(private http: HttpClient) { }

  getCalculoCDB(valorAplicacao: number, meses: number): Observable<CalculoCdb>  {
    const apiUrl = `${this.calculoCdbUrl}valorAplicacao=${valorAplicacao}&meses=${meses}`;
    return this.http.get<CalculoCdb>(apiUrl);
  }
}
