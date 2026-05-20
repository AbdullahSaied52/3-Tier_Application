
# Contacts Management System (3-Tier Architecture)

A robust and scalable C# console application designed for managing contact information. This project is strictly implemented using the **3-Tier Architecture** pattern to ensure clean separation of concerns, high maintainability, and reusability.

## 📌 Project Architecture

The solution is split into three distinct layers:

1. **Data Access Layer (`clsData1`)**
   * Handles direct communication with the Microsoft SQL Server database.
   * Utilizes ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataReader`) to execute queries securely.
   * Contains the foundational `is_found` database helper method.

2. **Business Logic Layer (`Business`)**
   * Acts as an intermediary between the UI and the Data Layer.
   * Maps raw database records into strongly-typed domain objects (`clscontact`).
   * Encapsulates business rules and entity behavior.

3. **Presentation Layer (`_3_tier_project`)**
   * A Console Application that serves as the user interface.
   * Interacts exclusively with the Business Layer to request and display contact details to the user.

---

## 🚀 Features

* **Secure Data Retrieval:** Implements parameterized SQL queries (`@id`) to completely mitigate **SQL Injection** vulnerabilities.
* **Efficient Record Finding:** Fetches specific contact records by their unique `ContactId` and populates business objects seamlessly.
* **Safe Connection Handling:** Implements precise exception handling with a `finally` block ensuring database connections are reliably closed even if runtime errors occur.

---

## 🛠️ Technologies & Tools

* **Language:** C# (.NET)
* **Database:** Microsoft SQL Server
* **Data Access Technology:** ADO.NET

---

## 💻 Database Schema

The system connects to a database named `ContactsDB` and targets a `Contacts` table with the following structural layout:

| Column Name | Data Type | Description |
| :--- | :--- | :--- |
| `ContactId` | `int` | Primary Key (Identity) |
| `FirstName` | `nvarchar` | Contact's first name |
| `LastName` | `nvarchar` | Contact's last name |
| `Email` | `nvarchar` | Email address |
| `Phone` | `nvarchar` | Phone number |
| `Address` | `nvarchar` | Physical address |
| `CountryID` | `int` | Foreign Key referencing a Countries table |

---

## 📖 Setup and Installation

1. **Database Setup:** Ensure you have Microsoft SQL Server running and a database named `ContactsDB` configured with the `Contacts` table.
2. **Connection String:** Open `clsData.cs` in the Data Access Layer and update the `connection_string` credentials to match your local SQL Server instance:
   ```csharp
   static string connection_string = "Server=.;Database=ContactsDB;User Id=sa;Password=YOUR_PASSWORD";

