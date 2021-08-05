export class FormInput {
  domainOrIp: string;
  services: Array<string>;
  generatedQuery: string;
  selectedItemsList: Array<object>;
  checkedIDs: Array<string>;

  constructor() {
    this.domainOrIp = "";
    this.services = [];
    this.generatedQuery = "";
    this.selectedItemsList = [];
    this.checkedIDs = [];
  }
}
