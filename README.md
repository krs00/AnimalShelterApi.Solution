# Animal Shelter API

### By Kymani Stephens

## Description

The Animal Shelter API is a RESTful web service designed to manage animal data for an animal shelter. It provides a set of endpoints to perform various operations related to animals, such as creating new animals, retrieving animal details, updating animal information, and deleting animals.

## Technologies

- C#
- .NET
- SQL
- MySQL
- Entity Framework Core

## Instructions to set up database

- Clone this repository.
- Open your terminal (e.g. Terminal or GitBash) and navigate to this project's directory called "AnimalShelterApi".

* Set up the project:
  - Create a file called 'appsettings.json' in the production directory "AnimalShelterApi".
  - Add the following code to the appsettings.json file:
  ```
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=[USERNAME];pwd=[PASSWORD];"
    }
  }
  ```

- Update the connection string with your MySQL username and password.

- To be sure EF Core Migrations is installed on your computer, run `dotnet tool install --global dotnet-ef --version 6.0.0`.
- Within the production folder "AnimalShelterApi" run:

```
dotnet ef database update
```

- The `animal_shelter` schema will appear in your _Schemas_ tab of MySQL Workbench.

## Using This Api

- Endpoints for this API are:

```
GET http://localhost:5000/api/animals
GET http://localhost:5000/api/animals{id}
PUT http://localhost:5000/api/animals{id}
DELETE http://localhost:5000/api/animals{id}

```

## Known bugs

## License

[MIT](https://opensource.org/license/mit)

Copyright (c) 2023 Kymani Stephens
