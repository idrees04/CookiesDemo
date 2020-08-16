# CookiesDemo
COOKIES IN ASP.NET MVC
	Cookies are one of the State Management techniques, so that we can store information for later use. Cookies are small files that are created in the web browser's memory (if they're temporary) or on the client's hard drive (if they're permanent).
	Cookies are used to store small pieces of information related to a user’s computer, such as its IP address, browser type, operating system, and Web pages last visited.
	The purpose of storing this information is to offer a personalized experience to the user.
	Cookies are sent to a client computer along with the page output.
	These cookies are stored on the client’s computer.
	When a browser requests the same page the next time, it sends the cookie along with the request information.
	The Web server reads the cookie and extracts its value.
	It then, process the Web page according to the information contained in the cookie and renders it on the Web browser.
There are two types of cookies:
1.	SESSION OR NON-PERSISTENT COOKIE. (TEMPORARY)
2.	PERSISTENT COOKIE (PERMANENT)
SESSION OR NON-PERSISTENT COOKIE:
•	The first one is the session cookies that are stored in the browser’s memory that are transmitted through the header during every request.
•	Session cookies are temporary cookies and remain saved for current session only.
PERSISTENT COOKIE:
•	The other type of cookie is the persistent cookies that are stored in text files on a user’s computer. This type of cookie is useful when you need to store information for a longtime.
•	Persistent cookies are created for the duration, which is set in the cookie file.
DIFFERENCE BETWEEN COOKIES AND SESSION
COOKIES
1. Cookies are used for client side state management.
2. It means cookies are stored in the client machine browser.
SESSION
1. Sessions are used for server side state management.
2. It means sessions are stored in the server machine.
