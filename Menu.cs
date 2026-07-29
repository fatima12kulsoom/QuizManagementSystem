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
        Console.WriteLine("3. View Students");
        Console.WriteLine("4. Search Student");
        Console.WriteLine("5. Update Student");
        Console.WriteLine("6. Delete Student");
        Console.WriteLine("7. Exit");
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
                ViewStudents();
                break;
            case 4:
                SearchStudent();
                break;
            case 5:
                UpdateStudent();
                break;
            case 6:
                DeleteStudent();
                break;
            case 7:
                Console.WriteLine("Thank You!");
                break;
            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
        if (choice != 7)
        {
            Console.WriteLine("\nPress Enter to Continue...");
            Console.ReadLine();
        }
    } while (choice != 7);
}
public static void RegisterStudent()
{
    Student student = new Student();
    student.RegisterStudent();
    students.Add(student);
    Console.WriteLine("\nStudent Registered Successfully!");
}
public static Student? FindStudent(int id)
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
public static void ViewStudents()
{
    if (students.Count == 0)
    {
        Console.WriteLine("No Students Registered Yet!");
        return;
    }
    Console.WriteLine("\n==============================");
    Console.WriteLine("      ALL STUDENTS");
    Console.WriteLine("==============================");
    foreach (Student student in students)
    {
        Console.WriteLine("ID    : " + student.StudentID);
        Console.WriteLine("Name  : " + student.Name);
        Console.WriteLine("Score : " + student.Score);
        Console.WriteLine("------------------------------");
    }
}
public static void SearchStudent()
{
    int id = InputHelper.ReadInt("Enter Student ID to Search: ");
    Student? student = FindStudent(id);
    if (student == null)
    {
        Console.WriteLine("Student not found!");
        return;
    }
    Console.WriteLine("\n==============================");
    Console.WriteLine("ID    : " + student.StudentID);
    Console.WriteLine("Name  : " + student.Name);
    Console.WriteLine("Score : " + student.Score);
    Console.WriteLine("==============================");
}
public static void UpdateStudent()
{
    int id = InputHelper.ReadInt("Enter Student ID to Update: ");
    Student? student = FindStudent(id);
    if (student == null)
    {
        Console.WriteLine("Student not found!");
        return;
    }
    Console.Write("Enter New Name (Current: " + student.Name + "): ");
    string newName = Console.ReadLine() ?? string.Empty;
    if (!string.IsNullOrWhiteSpace(newName))
    {
        student.Name = newName;
    }
    Console.WriteLine("\nStudent Updated Successfully!");
}
public static void DeleteStudent()
{
    int id = InputHelper.ReadInt("Enter Student ID to Delete: ");
    Student? student = FindStudent(id);
    if (student == null)
    {
        Console.WriteLine("Student not found!");
        return;
    }
    students.Remove(student);
    Console.WriteLine("\nStudent Deleted Successfully!");
}
public static void StartQuiz()
{
    int id = InputHelper.ReadInt("Enter Student ID: ");
    Student? student = FindStudent(id);  // ? is nullable reference type, so we need to check if student is null before proceeding
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
