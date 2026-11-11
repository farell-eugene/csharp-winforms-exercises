# C# Windows Forms Exercises

A collection of small **C# Windows Forms** applications from the Visual Programming course. They progress from event handling and input validation to object-oriented design and SQL Server data access.

| # | Project | What it does | Concepts |
|---|---|---|---|
| 01 | [Number Guessing Game](01-number-guessing-game) | Guess a random number from 1–100 within 10 attempts | Events, `Random`, control visibility, game state |
| 02 | [Library Book Lending](02-library-book-lending) | Add books, lend them to students (by student ID) and track remaining copies | Classes (`Book`, `Student`), collections, list binding |
| 03 | [Grade Calculator](03-grade-calculator) | Enter courses with credit weight and assignment/midterm/final scores to compute totals and letter grades | Classes, calculated properties, input validation |
| 04 | [Salary Tax Calculator](04-salary-tax-calculator) | Compute net salary from monthly wage and absences, with a 2% or 3% tax depending on whether gross pay is below or above IDR 5 million | Polymorphic tax classes, `TryParse` validation |
| 05 | [Student Registration (SQL)](05-student-registration-sql) | Register students (ID, username, email) in SQL Server and list them in a grid | ADO.NET, parameterized queries, MDI forms, `DataGridView` |

## Running a project

**Requirements:** Windows, Visual Studio 2019+ with the *.NET desktop development* workload, .NET Framework.

1. Open the `.sln` file inside the project folder.
2. Build and run (F5).

For **05 Student Registration**, first create a SQL Server Express database named `students` with a `student` table (`nimStudent`, `nameStudent`, `emailStudent`), then check the connection string in `FormRegister/dbClient.cs` and `App.config` (default: `Data Source=.\SQLEXPRESS;Initial Catalog=students;Integrated Security=True`).

UI labels are in Indonesian.

## Tech stack

C# · .NET Framework · Windows Forms · ADO.NET · SQL Server
