using System;
using System.Collections.Generic;

class Menu
{
    static List<Student> students = new List<Student>();

    public static Quiz quiz = new Quiz();

    public static void MainMenu()
{
    int choice;

    do
    {
        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("    QUIZ MANAGEMENT SYSTEM");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Register Student");
        Console.WriteLine("2. Start Quiz");
        Console.WriteLine("3. Exit");
        Console.Write("Enter Choice: ");

        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                RegisterStudent();
                break;

            case 2:
                StartQuiz();
                break;

            case 3:
                Console.WriteLine("Thank You!");
                break;

            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }

        if (choice != 3)
        {
            Console.WriteLine("\nPress Enter to Continue...");
            Console.ReadLine();
        }

    } while (choice != 3);
}

public static void RegisterStudent()
{
    Student student = new Student();

    student.RegisterStudent();

    students.Add(student);

    Console.WriteLine("\nStudent Registered Successfully!");
}

public static Student FindStudent(int id)
{
    foreach (Student student in students)
    {
        if (student.StudentID == id)
        {
            return student;
        }
    }

    return null;
}

public static void StartQuiz()
{
    int id = InputHelper.ReadInt("Enter Student ID: ");

    Student student = FindStudent(id);

    if (student == null)
    {
        Console.WriteLine("Student not found!");
        return;
    }

    Console.WriteLine("\nWelcome, " + student.Name);
    Console.WriteLine("Quiz: " + quiz.QuizTitle);
    Console.WriteLine();

    int score = 0;

    foreach (Question question in quiz.Questions)
    {
        question.DisplayQuestion();

        char answer = InputHelper.ReadChar("Enter Answer: ");

        if (answer == question.CorrectAnswer)
        {
            score += question.Marks;
        }

        Console.WriteLine();
    }

    student.Score = score;

    Console.WriteLine("==============================");
    Console.WriteLine("Quiz Finished!");
    Console.WriteLine("Student : " + student.Name);
    Console.WriteLine("Score   : " + score);

    if (score >= quiz.PassingMarks)
    {
        Console.WriteLine("Result  : PASS");
    }
    else
    {
        Console.WriteLine("Result  : FAIL");
    }

    Console.WriteLine("==============================");
}
}