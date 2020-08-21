# _Animal Shelter API_

#### _Browse available cats and dogs at a shelter, August 21, 2020_

#### By _**Ben White**_

## Description

_This api lets a user search a shelter for dogs and cats, and also allows a user to filter their search, as well as, allow them to add, wdit, and remove entries from the api

## Setup/Installation Requirements

Setting up the database:

1. In order for this program to work you will need to create an appsettings.json file, after you do that enter this code in it:

  ```{
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=Animal_Shelter;uid=root;pwd={ _password_ };"
    }
  }
  ```
  * Replacing password with your server password

2. Run this command in the terminal: `dotnet ef database update`

Software Requirements:

1. This program utilizes .NET version 2.2, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and install the SDK version 2.2 or
      greater patch version, but do not upgrade to a higher minor version number.

2. Clone this repository onto your computer: https://github.com/...

3. In your preferred terminal window, navigate into AnimalShelter.Solution/AnimalShelter using cd (i.e. cd
   desktop/AnimalShelter.Solution/AnimalShelter) and open the project with your preferred code editor.

4. Run the following terminal command: $ dotnet restore

5. To initiate this application, run the command: $ dotnet run

Http Request
  ```
  Get /api/animals
  Post /api/animals'
  Get /api/animals/{id}
  Put /api/animals/{id}
  Delete /api/animals/{id}
  ```

## Known Bugs

_No bugs known at this time_

## Support and contact details

_Ben White: bwhite2140@outlook.com_

## Technologies Used

_Git, C#, Dotnet, SQL, Entity_

### License

*MIT License*

Copyright (c) 2020 **_Ben White_**