Flight Ticket Booking Web Service
This web service provides RESTful APIs for querying and purchasing flight tickets.

Api Project Youtube Link
Youtube.

Features
QUERY TICKET:

Query available flights based on date, origin, destination, and the number of passengers.
Supports paging for the list of flights.
No authentication required.
BUY TICKET:

Perform a ticket purchase transaction using date, origin, destination, and passenger name.
Books one seat from the selected flight, reducing the number of available seats.
Returns the transaction status.
Requires authentication with username/password.
ER Model
For a visual representation of the underlying data structure, refer to the ER Model.

API Endpoints
QUERY TICKET
Request
Method: GET
Parameters:
date: Date of the flight.
from: Origin airport code.
to: Destination airport code.
num_people: Number of people traveling.
page: Page number for paging.
Response
Returns a JSON array of flights with details (Date, FlightNumber, Price).
Supports paging with metadata in the response.
BUY TICKET
Request
Method: POST
Parameters:
date: Date of the flight.
from: Origin airport code.
to: Destination airport code.
passenger_name: Name of the passenger.
username: User's username.
password: User's password.
Response
Returns a JSON object with the transaction status.
Authentication
The BUY TICKET endpoint requires authentication using a valid username and password.
Getting Started
