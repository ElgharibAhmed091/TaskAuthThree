# Task 03 - JWT Authentication & Authorization API

## 🔐 Description

This project implements secure **JWT-based authentication and authorization** using ASP.NET Core Web API. It includes user registration, secure password hashing using **BCrypt**, JWT token generation, and **role-based access control** (`admin`, `user`, etc.).

---

## 📌 Features

- ✅ User registration (`/api/Auth/register`)
- ✅ User login with JWT token generation (`/api/Auth/login`)
- ✅ Passwords stored securely using **BCrypt hashing**
- ✅ JWT token validation with expiration
- ✅ Role-based authorization using `[Authorize(Roles = "...")]`
- ✅ Swagger UI support with **🔐 Authorize** button
- ✅ Secure endpoints like `/api/Users/admin`, `/api/Users/profile`

---

## 🛠️ Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (LocalDB)
- JWT (JSON Web Tokens)
- BCrypt.Net-Next (for password hashing)
- Swagger / Swashbuckle for API documentation

---

## 🚀 How to Run

1. Clone or download the project.
2. Make sure SQL Server is running.
3. Update the connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=YOUR_SERVER_NAME;Initial Catalog=AuthTaskJWT;Integrated Security=True"
   }
