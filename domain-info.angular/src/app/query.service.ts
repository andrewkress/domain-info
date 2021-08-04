import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from "rxjs/operators";


import { Query } from './query';

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
    console.log(query);
    let results = this.http.get(query);
    console.log(results);
    return results;
      //.pipe(map(res => res.json()))
      //.catch((error: any) => Observable.throw(error.json().error || 'Server error'))
  }
}
