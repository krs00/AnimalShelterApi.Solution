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

To set up the Animal Shelter API and the corresponding database, please follow the instructions below:

1. Clone this repository to your local machine.

2. Open your terminal or command prompt and navigate to the "AnimalShelterApi" directory.

3. In the "AnimalShelterApi" directory, create a file named `appsettings.json`.

4. Open the `appsettings.json` file and add the following code:

```json 
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

Replace `[USERNAME]` and `[PASSWORD]` with your MySQL username and password.

5. Make sure you have MySQL Server installed and running on your machine.

6. Create a new database named "animal_shelter" in MySQL.

7. Run the following command in the terminal or command prompt to apply the database migrations:

```
dotnet ef database update
```

8. Once the migrations are applied successfully, the "animal_shelter" database should be populated with the necessary tables.

## Using This API

The Animal Shelter API provides the following endpoints for interacting with animal data:

- GET /api/animals: Retrieves a list of all animals.
- GET /api/animals/{id}: Retrieves the details of a specific animal.
- PUT /api/animals/{id}: Updates the information of a specific animal.
- DELETE /api/animals/{id}: Deletes a specific animal.

To use these endpoints, you can send HTTP requests to the corresponding URLs using tools like Postman or cURL.

## Query Parameters

The Animal Shelter API supports the following query parameters for filtering the list of animals:

- species: Filters animals by species type. Valid values are "Dog" and "Cat".
- sex: Filters animals by sex. Valid values are "Male" and "Female".
- status: Filters animals by status.
- breed: Filters animals by breed.
- age: Filters animals by age.

You can include these query parameters in the URL when making a GET request to the /api/animals endpoint. Here's an example URL with query parameters:

```
GET http://localhost:5000/api/animals?species=Dog&sex=Male
```

This URL will retrieve a list of male dogs.

## JSON Web Tokens (JWT) - Accessing the API

To access information from this API, you need to authenticate using JSON Web Tokens (JWT). Follow the steps below to register for an account, log in, and obtain a valid JWT token for accessing the API:

1. Register for an Account:
   - Send a POST request to the following endpoint: `/api/Authenticate/register`
   - Include the following details in the request body:
     ```json
     {
       "username": "example",
       "email": "example@gmail.com",
       "password": "Password@123"
     }
     ```
     Replace the `username`, `email`, and `password` values with your desired registration details.

2. Log In:
   - Send a POST request to the following endpoint: `/api/Authenticate/login`
   - Provide your username and password in the request body:
     ```json
     {


       "username": "example",
       "password": "Password@123"
     }
     ```
     Replace the `username` and `password` values with the credentials you used during registration.

3. Retrieve JWT Token:
   - Upon successful login, the API will respond with a JWT token. Copy the JWT token value returned in the response.

4. Accessing API Endpoints:
   - To access the API endpoints, you need to include the JWT token in the request headers.
   - Set the `Authorization` header to `Bearer [JWT_TOKEN]`, replacing `[JWT_TOKEN]` with the JWT token you received after logging in.
   - Now you can make requests to the API endpoints with the required authentication.

## Known bugs

Currently, there are no known bugs in the Animal Shelter API. However, if you encounter any issues or have any suggestions, please feel free to report them in the GitHub repository for this project.

## License

[MIT](https://opensource.org/licenses/MIT). 

Copyright (c) 2023 Kymani Stephens