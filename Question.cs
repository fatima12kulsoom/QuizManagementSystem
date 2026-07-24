#nullable disable
using System;
class Question
{
    public int QuestionID { get; set; }
    public string QuestionText { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string OptionD { get; set; }
    public char CorrectAnswer { get; set; }
    public int Marks { get; set; }

    public void DisplayQuestion()
    {
        Console.WriteLine(QuestionText);
        Console.WriteLine("A. " + OptionA);
        Console.WriteLine("B. " + OptionB);
        Console.WriteLine("C. " + OptionC);
        Console.WriteLine("D. " + OptionD);
    }
}