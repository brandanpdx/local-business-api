# Epicodus Independent Project - April 3, 2020

### Created by: Brandan Sayarath

## Description

This is the Epicodus independent end-of-week assignment for Friday, April 3, 2020.  

## User stories
* User is able to get the list of all businesses in the databse
* User is able to view a specific business using the business id
* User is able to filter their search using parameters of:
  * BusinessName
  * BusinessType
  * Opening Hour
  * Closing Hour
* User is able to post a new business in the database
* User is able to edit an existing business in the database using the BusinessId 
* User is able to delete an existing business in the database


## Setup/Installation Requirements

Clone this repository via Terminal using the following commands:
* ```$ cd desktop```
* ```$ git clone https://github.com/brandanpdx/local-business-api```
* ```$ cd local-business-api```

To run the program, first navigate to the LocalBusinessAPI production folder by typing the following into the terminal: 

* ```$ cd LocalBusinessAPI```

Then restore dependencies by typing:
* ```$ dotnet restore```

Then update your MySQL database by typing: 
* ```$ dotnef ef database update```

You can now run the program by typing:
* ```$ dotnet run```

## API Documentation

This project was built using a custom API.  To view the detailed routes of the API, please visit: https://app.swaggerhub.com/apis-docs/brandanpdx/my-title/1.0.0#/


## Support and Contact

Please email Brandan Sayarath: brandan@brandan.tech for any questions.

## Technologies Used

This program was created with:

* C#
* ASP.NET Core MVC 2.2
* Entity Framework
* NSwag  
* MySQL
* MySQL Workbench 

## License

This code is licensed under MIT permissive free software license

Copyright (c) 2020 Brandan Sayarath

