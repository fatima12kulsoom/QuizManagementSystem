#nullable disable
using System;
using System.Collections.Generic;

class Quiz
{
    public int QuizID { get; set; }
    public string QuizTitle { get; set; }
    public int PassingMarks { get; set; }

    public List<Question> Questions { get; set; }

    // Constructor
    public Quiz()
    {
        Questions = new List<Question>();
    }

    public void DisplayQuiz()
    {
        Console.WriteLine("================================");
        Console.WriteLine("Quiz ID       : " + QuizID);
        Console.WriteLine("Quiz Title    : " + QuizTitle);
        Console.WriteLine("Passing Marks : " + PassingMarks);
        Console.WriteLine("================================");
    }

    public void DisplayAllQuestions()
    {
        foreach (Question question in Questions)
        {
            question.DisplayQuestion();
            Console.WriteLine();
        }
    }
}