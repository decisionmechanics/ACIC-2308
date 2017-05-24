# ACIC API example (#2308)

Sample code based on the following requirement:

- The client will need to send two parameters to the API
  1. One string value (key for which calculation to perform)
  2. One List<string> with calculation input values. 
- The API will send back an object ListCalcResult

## Sample web service request

http://localhost/api/Home?key=foo&values=bar&values=blah