# Domain Info

## Install Instructions

1. git clone https://github.com/andrewkress/domain-info.git
2. cd domain-info\domain-info.angular
3. npm install
4. ng serve
5. Open domain-info\domain-info.sln in Visual Studio
6. Right Click on domain-info.api -> Manage User Secrets
7. Enter your API keys in the following format
```
{
  "whoisxmlapi": "whoisxmlapikey",
  "ipstack": "ipstackapikey",
  "virustotal": "virustotalapikey"
}
```
8. Start the API using Kestrel
9. Use the Angular frontend or the Swagger UI test page