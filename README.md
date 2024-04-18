# University Tuition Payment Web Service

This web service provides RESTful APIs for querying tuition details, making tuition payments, and allowing administrators to update tuition information.

**API Project Youtube Link**: [Youtube](#)

## Features

### QUERY TUITION

- Query available tuition based on date, period, student number, and class.
- Supports paging for the list of tuition fees.
- No authentication required.

### PAY TUITION

- Perform a tuition payment transaction using date, period, student number, and payment amount.
- Reduce the outstanding tuition amount by making a payment for the selected tuition fee.
- Returns the transaction status.
- Requires authentication with username/password.

## ER Model

For a visual representation of the underlying data structure, refer to the ER Model:

(https://github.com/Atacanpo/University-pay/blob/main/ER%20Diagram.png))

## API Endpoints

### PAY TUITION

#### Request
- **Method**: POST
- **Parameters**:
  - date: Date of the tuition fee.
  - period: Period of the tuition fee.
  - student_number: Student number.
  - payment_amount: Payment amount.
  - username: User's username.
  - password: User's password.

#### Response
- Returns a JSON object with the transaction status.

## Authentication

The PAY TUITION endpoint requires authentication using a valid username and password.
