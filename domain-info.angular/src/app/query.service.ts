import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class QueryService {
  //

  constructor(private http: HttpClient) { }

  getQuery(domainOrIp: string, services: Array<string>): Observable<Object> {
    let subQuery = "";
    services.forEach((service) => {
      subQuery += "&services=" + service;
    });
    let query = "https://localhost:5001/query?domainOrIp=" + domainOrIp + subQuery;
    return this.http.get(query);
  }
}
