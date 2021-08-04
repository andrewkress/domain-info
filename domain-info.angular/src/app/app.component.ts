import { Component, OnInit } from '@angular/core';
import { FormInput } from './FormInput';
import { Query } from './query';
import { QueryService } from './query.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [QueryService]
})
export class AppComponent implements OnInit {
  title = 'Domain Info';
  formInput: FormInput = {
    domainOrIp: "",
    services: []
  };
  generatedQuery: string;

  constructor(private queryService: QueryService) {
    this.generatedQuery = "";
  }

  ngOnInit() {
  }

  onSelect(): void {
    this.generatedQuery = "Loading...";
    this.queryService.getQuery(this.formInput.domainOrIp, this.formInput.services).subscribe(generatedQuery => this.generatedQuery = JSON.stringify(generatedQuery), err => { console.log(err)});
  }
}
