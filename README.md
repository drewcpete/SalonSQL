# Eau Claire's Salon!

### By &rew Peterson

This application is for a salon. It allows the user to add new stylists, edit/delete existing stylists, and create a list of clients for each stylist. All data is stored in a SQL database.  This project is for Week 4 of Epicodus' C# program.

### Prerequisites

You will need to have mySQL workbench and a web browser installed.

### Installation

- Clone the repository from https://github.com/drewcpete/SalonSQL.git
- Navigate to the cloned repository in your terminal
- Use terminal command ```dotnet restore``` in the HairSalon folder
- Use terminal command  ```dotnet run``` 
- Navigate to  http://localhost:5000/ 
- Open MySQL Workbench
- Create database  ```andrew_peterson``` 
- Create Table ```stylists```
- Add columns to ```stylists``` for ```id```, ```name```, ```price```, and ```clients```
- Create Table ```clients```
- Add columns to ```clients``` for ```clientid```, ```name```, and ```stylistid```

### Specs

| Behaviour | Input | Output |
|---|---|---|
| Enter a stylist | "Joan", 20 | "Joan" added to the name column of the stylist table. 20 added to price column |
| Edit a Stylist | "Joan", 30 | price column of stylist table changed to 30 |
| Delete a stylist | "Joan" | removes entire row from the stylist table |
| Add a client to a stylist | add client "gary" to stylist "Joan" | adds "gary" to the list stored in the "clients" column of the stylist table |


### Known Bugs
Delete client is not functioning.  Commented out link.

### Technologies USed
* C#
* HTML
* CSS
* Razor
* .NET
* SQL

### Liscense
This project is licensed under the MIT License 

