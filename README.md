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
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
   "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=[USERNAME];pwd=[PASSWORD];
  },
  "JWT": {
    "ValidAudience": "http://localhost:4200",
    "ValidIssuer": "http://localhost:5000",
    "Secret": "JWTAuthenticationHIGHsecuredPasswordVVVp1OH7Xzyr" 
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

## JSON Web Tokens (JWT) - Accessing API

To access information from this API, you are required to authenticate using a JSON Web Token (JWT). Follow the steps below to register for an account, log in, and obtain a valid JWT token for accessing the API.

### 1. Register for an Account
To register for an account, send a POST request to the following endpoint:
```
http://localhost:5000/api/Authenticate/register
```

Include the following details in the request body, using raw JSON format:
```json
{
    "username" : "example",
    "email" : "example@gmail.com",
    "password" : "Password@123"
}
```

Replace the `username`, `email`, and `password` values with your desired registration details.

### 2. Log In
To log in and obtain a valid JWT token, send a POST request to the following endpoint:
```
http://localhost:5000/api/Authenticate/login
```

Provide your username and password in the request body, using raw JSON format:
```json
{
    "username" : "example",
    "password" : "Password@123"
}
```

Replace the `username` and `password` values with the credentials you used during registration.

### 3. Retrieve JWT Token
Upon successful login, the API will respond with a JWT token. Copy the JWT token value returned in the response.

### 4. Accessing API Endpoints
To access information from the API, use the JWT token you received after logging in. In Postman, navigate to the Authorization tab and select the "Bearer Token" type. Paste the copied JWT token into the token field.

Now you are authenticated and authorized to make requests to the API endpoints. Enjoy utilizing the Animal API for your desired functionality.

## Known bugs

## License

[MIT](https://opensource.org/license/mit)

Copyright (c) 2023 Kymani Stephens
