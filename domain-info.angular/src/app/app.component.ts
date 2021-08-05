import { Component, OnInit } from '@angular/core';
import { FormInput } from './FormInput';
import { QueryService } from './query.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [QueryService]
})
export class AppComponent implements OnInit {
  title = 'Domain Info';

  checkboxesDataList = [
    {
      id: 'whois',
      label: 'Whois Lookup (Domain Only)',
      isChecked: true
    },
    {
      id: 'geo',
      label: 'Geographic IP Lookup (IP Only)',
      isChecked: true
    },
    {
      id: 'reverseip',
      label: 'Reverse DNS Lookup (IP Only)',
      isChecked: true
    },
    {
      id: 'virustotal',
      label: 'VirusTotal Lookup (Domain or IP)',
      isChecked: true
    }
  ];

  formInput: FormInput = {
    domainOrIp: "",
    services: [],
    generatedQuery: "",
    selectedItemsList: [],
    checkedIDs: []
  };
  

  constructor(private queryService: QueryService) {
    //this.formInput.
  }

  ngOnInit() {
    this.fetchSelectedItems();
    this.fetchCheckedIDs();
  }

  onSelect(): void {
    this.formInput.generatedQuery = "Loading...";
    this.queryService.getQuery(this.formInput.domainOrIp, this.formInput.checkedIDs).subscribe(generatedQuery => this.formInput.generatedQuery = JSON.stringify(generatedQuery, null, 2), err => {
      console.log(err);
      this.formInput.generatedQuery = "ERROR: " + err.Message;
    });
  }

  changeSelection() {
    this.fetchSelectedItems();
    console.log(this.fetchCheckedIDs());
  }

  fetchSelectedItems() {
    this.formInput.selectedItemsList = this.checkboxesDataList.filter((value, index) => {
      return value.isChecked
    });
  }

  fetchCheckedIDs() {
    this.formInput.checkedIDs = []
    this.checkboxesDataList.forEach((value, index) => {
      if (value.isChecked) {
        this.formInput.checkedIDs.push(value.id);
      }
    });
  }
}
