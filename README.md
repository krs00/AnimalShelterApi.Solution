# Animal Shelter API 🐕 🐱 🐶 🐾

### By Kymani Stephens

## Description

The Animal Shelter API is a RESTful web service designed to manage animal data for an animal shelter. It provides a set of endpoints to perform various operations related to animals, such as creating new animals, retrieving animal details, updating animal information, and deleting animals.

## Technologies

- C#
- .NET
- SQL
- MySQL
- Entity Framework Core

## Instructions for database setup

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

  - Create a file called 'appsettings.Development.json' in the production directory "AnimalShelterApi".
  - Add the following code to the appsettings.Development.json file:

```
{
 "Logging": {
   "LogLevel": {
     "Default": "Information",
     "Microsoft": "Trace",
     "Microsoft.AspNetCore": "Information",
     "Microsoft.Hosting.Lifetime": "Information"
    }
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
GET http://localhost:5000/api/animals/{id}
PUT http://localhost:5000/api/animals/{id}
DELETE http://localhost:5000/api/animals/{id}

```

## Query Parameters

| Parameter | Type   | Required     | Description                                   | Example Url                                         |
| --------- | ------ | ------------ | --------------------------------------------- | --------------------------------------------------- |
| Animals   | List   | not required | Returns all animals in the database           | http://localhost:5000/api/animals                   |
| Species   | String | not required | Returns matching species type, "Dog" or "Cat" | http://localhost:5000/api/animals?species=[SPECIES] |
| Sex       | String | not required | Returns matching sex type, "Male" or "Female" | http://localhost:5000/api/animals?sex=[SEX]         |
| Status    | String | not required | Returns animals with a matching status        | http://localhost:5000/api/animals?status=[STATUS]   |
| Breed     | String | not required | Returns animals of the matching breed         | http://localhost:5000/api/animals?breed=[BREED]     |
| Age       | Int    | not required | Returns animals of the matching age           | http://localhost:5000/api/animals?age=[AGE]         |

Please note that you can replace [SPECIES], [SEX], [STATUS], [BREED], and [AGE] with the actual values you want to search for in the URLs. For example, if you want to search for dogs, the URL would be: http://localhost:5000/api/animals?species=Dog.

## Known bugs

Ran out of time for roles but will fix later!!!

## License

[MIT](https://opensource.org/license/mit)

Copyright (c) 2023 Kymani Stephens
