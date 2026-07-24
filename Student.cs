#nullable disable
using System;

class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string RollNo { get; set; }
    public int Score { get; set; }
    public string Department { get; set; }

    public void RegisterStudent()
    {
        Console.Write("Enter Student ID: ");
        StudentID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Roll No: ");
        RollNo = Console.ReadLine();

        Console.Write("Enter Department: ");
        Department = Console.ReadLine();

        Console.WriteLine("\nStudent Registered Successfully!");
    }

    public void DisplayStudent()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Student ID : " + StudentID);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Roll No    : " + RollNo);
        Console.WriteLine("Department : " + Department);
        Console.WriteLine("----------------------------");
    }

    public void UpdateStudent()
    {
        Console.WriteLine("\nUpdate Student");

        Console.Write("Enter New Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter New Roll No: ");
        RollNo = Console.ReadLine();

        Console.Write("Enter New Department: ");
        Department = Console.ReadLine();

        Console.WriteLine("Student Updated Successfully!");
    }
}