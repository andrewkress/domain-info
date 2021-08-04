export class FormInput {
  domainOrIp: string;
  services: Array<string>;

  constructor() {
    this.domainOrIp = "";
    this.services = [];
  }
}
