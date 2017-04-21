# JWT-Web-Api
JWT Implementation for ASP.NET MVC 5 Web Api 2

Requirements:
Visual Studio 2012 (MVC 5 update installed) or above needed for build and execute.
Install Postman (https://www.getpostman.com/)

Steps:
1. Restore DB in SQL Server from the DB folder
2. Open Solution in Visual Studio and build the project
3. Execute (F5) to run. Browser will throw error page which is fine as this is only WEB-API implementation
4. Open Postman
5. First do a "POST" call (do not click on send untill you have added below headers) on localhost using "http://localhost:57136/api/account/login", and add headers 
  a. username administrator@gmail.com
  b. password admin123
  c. grant_type password
  d. Content-Type application/x-www-form-urlencoded
6. Click Send
7. A JSON response will be generated which will have dbUser and token data. Copy the token data.
8. As we have received a token we can use that token and make WEB API calls to secure methods.
9. Make a "GET" call on postman on localhost using "http://localhost:57136/api/Books" and add below headers
  a. Authorization Bearer token (token which you copied)
10. Click Send and you will access BooksController [Authorize] Get Method



