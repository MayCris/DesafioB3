import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class AppService {
  calculoCdbUrl = 'http://localhost:3000/calculocdb';

  constructor(private http: HttpClient) { }

  GetCalculoCDB() {
    return this.http.get<Array<any>>(this.calculoCdbUrl);
  }
}
