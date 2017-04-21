# JWT-Web-Api
JWT Implementation for ASP.NET MVC 5 Web Api 2

<b>Requirements:</b> <br/>
Visual Studio 2012 (MVC 5 update installed) or above needed for build and execute.<br />
Install Postman (https://www.getpostman.com/) <br/>

<b>Steps:</b> <br/>
1. Restore DB in SQL Server from the DB folder <br/>
2. Open Solution in Visual Studio and build the project <br/>
3. Execute (F5) to run. Browser will throw error page which is fine as this is only WEB-API implementation <br/>
4. Open Postman <br/>
5. First do a "POST" call (do not click on send untill you have added below headers) on localhost using "http://localhost:57136/api/account/login", and add headers <br/>
  a. username  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;administrator@gmail.com <br/>
  b. password  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;admin123 <br/>
  c. grant_type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;password <br/>
  d. Content-Type application/x-www-form-urlencoded <br/>
6. Click Send <br/>
7. A JSON response will be generated which will have dbUser and token data. Copy the token data. <br/>
8. As we have received a token we can use that token and make WEB API calls to secure methods. <br/>
9. Make a "GET" call on postman on localhost using "http://localhost:57136/api/Books" and add below headers <br/>
  a. Authorization &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Bearer token (token which you copied) <br/>
10. Click Send and you will access BooksController [Authorize] Get Method <br/>



