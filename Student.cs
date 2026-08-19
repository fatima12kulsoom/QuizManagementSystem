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
    }
}
