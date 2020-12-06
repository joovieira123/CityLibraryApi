# City Library Api

**Here is documented all the stack, tools, dependencies and scripts used to build and run this api.**

---

---

## After running 'dotnet run' in the CLI, visit the api [here](https://localhost:5001/api/Books/).

---

---

## Stack

Technologies used.

1. The api is built entirely with C# and ASP.NET Core.

2. The Git and remote Repository supplier is **Github**.

3. The database used was **SQLite**.

4. For Unit testing I tried using **MSTest**.

---

---

## Available Endpoints

In Postman, you can test the following endpoints:

### GET `https://localhost:5001/api/Readers`

This endpoint will return all readers and their associated books by id.

### GET `https://localhost:5001/api/Books`

This endpoint will return all books and their associated reader by id.

### GET `https://localhost:5001/api/Books/{id}`

This endpoint will return the book associated with id passed.

### GET `https://localhost:5001/api/Readers/{id}`

This endpoint will return the reader associated with id passed.

### GET `https://localhost:5001/api/Readers/?name={firstName}`

This endpoint will return the reader, and associated books, when passed the first name.

### GET `https://localhost:5001/api/Readers/?title={title}`

This endpoint will return the book, and associated reader, when passed the book title.

### DELETE `https://localhost:5001/api/Books/{id}`

This endpoint will destroy the book associated with id passed.

### DELETE `https://localhost:5001/api/Readers/{id}`

This endpoint will destroy the reader associated with id passed.

### POST `https://localhost:5001/api/Readers/`

This endpoint will create a new reader.
    The key/values needed are:
    "Id": int,
    "FirstName": string,
    "LastName": string

### POST `https://localhost:5001/api/Books/`

This endpoint will create a new book.
    The key/values needed are:
    "Id": int,
    "Title": string,
    "CheckedOut": bool,
    "ReaderId": int

### PUT `https://localhost:5001/api/Readers/{id}`

This endpoint will update an existing reader.
    The key/values needed are:
    "Id": int,
    "FirstName": string,
    "LastName": string

### PUT `https://localhost:5001/api/Books/{id}`

This endpoint will update an existing book.
    The key/values needed are:
    "Id": int,
    "Title": string,
    "CheckedOut": bool,
    "ReaderId": int