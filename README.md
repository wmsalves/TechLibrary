<h1 align="center">Tech Library API</h1>

**Tech Library** is a RESTful API developed in C# with ASP.NET Core, designed to manage books, users, and checkouts in a library. The application follows modern development practices, including JWT authentication, pagination, use cases, and dependency injection.

## 🛠️ Technologies Used

- **C# .NET Core**: Primary framework and language.
- **ASP.NET Core**: Web framework for building the API.
- **Entity Framework Core**: ORM for database management.
- **BCrypt.Net**: Secure password hashing.
- **JWT (JSON Web Tokens)**: Token-based authentication and authorization.

## 🔮 Features

- **JWT Authentication**: Protects endpoints and manages user sessions.
- **Book Management**: Create, update, and remove books.
- **User Management**: Secure user registration and password handling using BCrypt.
- **Checkout Management**: Track book checkouts and returns, including dates.
- **Pagination**: Pagination support for large datasets to improve performance.

## 📊 Entity Structure

### Book
- **Attributes**: `Id`, `Title`, `Author`, `Amount`
- **Description**: Represents a book in the library.

### User
- **Attributes**: `Id`, `Name`, `Email`, `Password`
- **Description**: Represents a user with login credentials.

### Checkout
- **Attributes**: `Id`, `CheckoutDate`, `UserId`, `BookId`, `ExpectedReturnDate`, `ReturnedDate`
- **Description**: Tracks the borrowing process of books.

## 📂 Project Structure

The project follows a layered architecture:

- **LibraryTechFlow.Api**: Manages API controllers and HTTP requests.
- **LibraryTechFlow.Communication**: Handles data transfer contracts (requests and responses).
- **LibraryTechFlow.Domain**: Core business logic and domain entities.
- **LibraryTechFlow.Exception**: Custom exception handling.
- **LibraryTechFlow.Security**: Manages JWT token generation and password hashing.

## 📚 API Documentation

The API is documented using **Swagger**. To view it, navigate to:

[http://localhost:7097/swagger/index.html](http://localhost:7097/swagger/index.html)

## 🚀 Installation and Setup

To run the project locally, follow these steps:

1. **Clone the repository:**
```bash
git clone https://github.com/wmsalves/TechLibrary
cd TechLibrary
```
2. **Restore dependencies:**
```bash
dotnet restore
```
3. **Configure the appsettings.json file with database and JWT settings:**
```json
{
  "ConnectionStrings": {
    "SqlLiteDatabase": "Data Source=path_to_db.sqlite"
  },
  "JwtSettings": {
    "Secret": "your_secret_key_for_jwt"
  }
}
```
4. **Start the application**
```bash
dotnet run
```
The API will be available at https://localhost:7097.
    
    
