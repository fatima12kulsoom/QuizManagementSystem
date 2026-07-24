# Quiz Management System

## Project Description

The Quiz Management System is a console-based application developed in **C#** using **Object-Oriented Programming (OOP)** concepts. It allows multiple students to register, take a pre-defined multiple-choice quiz, and receive their scores with a pass/fail result.

## Features

* Student registration
* Multiple student support
* Pre-defined OOP MCQ quiz
* Display quiz questions and options
* Accept student answers
* Automatic score calculation
* Pass/Fail result display
* Menu-driven console interface

## Technologies Used

* C#
* .NET Console Application
* Visual Studio Code
* Object-Oriented Programming (OOP)

## OOP Concepts Used

* Classes and Objects
* Encapsulation
* Constructors
* Properties (Get/Set)
* Lists (`List<T>`)
* Methods
* Object Interaction

## Project Structure

* `Program.cs` – Starts the application and loads quiz questions.
* `Menu.cs` – Displays the menu and controls the program flow.
* `Student.cs` – Stores student information and registration methods.
* `Question.cs` – Represents a single MCQ.
* `Quiz.cs` – Stores quiz details and the list of questions.
* `InputHelper.cs` – Handles user input.

## How to Run

1. Open the project folder in Visual Studio Code.
2. Open the integrated terminal.
3. Run the following command:

```
dotnet run
```

4. Register a student.
5. Start the quiz.
6. Answer all MCQs.
7. View the final score and pass/fail result.

## Team Members

* **Member 1:** Core System Development (Student Registration, Quiz Logic, Score Calculation)
* **Member 2:** Student Management (Search, Update, Delete, Validation)
* **Member 3:** Result Management (Statistics, Ranking, Reports)

## Future Enhancements

* Student login system
* Timer for quizzes
* Question categories
* Randomized questions
* Database integration
* Admin panel
* Result history
