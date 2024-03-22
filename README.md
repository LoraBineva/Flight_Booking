# Flight_Booking
The Flight Booking System is designed to facilitate flight ticket booking for users. It provides functionalities such as searching for available flights and booking tickets. The system aims to be convenient and user-friendly. It implements a log_in and registration page as well. 

Description:
This program contains the base for building a succesful managment program for flight tickets. Although it is not conected to a real firm, it is easily customizable for every system. It is written in C# and uses SSMS for database managment. It contains 4 winforms: 
- Log_in Form - The user logs in from there.
- Registration - When the users don't have an account.
- Search_form (called Form1) - the user is able to search in teh database based on filters which are filled in through the database.
- Booking Form - last confirmation, booking info, etc. Possibility to implement a payment form from there. 

Installation:
All of the code is available on Github and it is to be used in Visual Studio. In addition, the user has to create they own database on their computer with the following fields:
- A table called Flights with fields: flightID, Departure, Destination, To_Date, From_Date, Price, Airline, Seats_Available
  - All fields are varchar except flightID which is an int (primary key).  
  
In addition the user has to change the reference to the database in ALL 3 forms (except the 1st, menu one) to the reference of their own databse. This is to be found in the Form_Load method.
Specific Line of Code:  sql = new SqlConnection(@"**(User's own server)**; Initial Catalog=**(Name of the databse)**; Integrated Security=True;");  



