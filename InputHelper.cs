#nullable disable
using System;
using System.Collections.Generic;

class InputHelper
{
    // Read Integer
    public static int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Read String
    public static string ReadString(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    // Read Character
    public static char ReadChar(string message)
    {
        Console.Write(message);
        return Convert.ToChar(Console.ReadLine().ToUpper());
    }
}



class QuizResult
{
    // Student information
    public int StudentID;
    public string StudentName;

    // Quiz information
    public string QuizName;
    public int TotalQuestions;
    public int CorrectAnswers;
    public int WrongAnswers;
    public int SkippedAnswers;

    // Result information
    public double Percentage;
    public string Grade;
    public string Status;

    // Constructor
    public QuizResult()
    {
        StudentID = 0;
        StudentName = "";
        QuizName = "";
        TotalQuestions = 0;
        CorrectAnswers = 0;
        WrongAnswers = 0;
        SkippedAnswers = 0;
        Percentage = 0;
        Grade = "";
        Status = "";
    }

    // Calculate result
    public void CalculateResult()
    {
        if (TotalQuestions > 0)
        {
            Percentage = ((double)CorrectAnswers / TotalQuestions) * 100;
        }
        else
        {
            Percentage = 0;
        }

        if (Percentage >= 80)
        {
            Grade = "A";
            Status = "Excellent";
        }
        else if (Percentage >= 70)
        {
            Grade = "B";
            Status = "Very Good";
        }
        else if (Percentage >= 60)
        {
            Grade = "C";
            Status = "Good";
        }
        else if (Percentage >= 50)
        {
            Grade = "D";
            Status = "Pass";
        }
        else
        {
            Grade = "F";
            Status = "Fail";
        }
    }

    // Display result
    public void DisplayResult()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("              QUIZ RESULT");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Student ID       : " + StudentID);
        Console.WriteLine("Student Name     : " + StudentName);
        Console.WriteLine("Quiz Name        : " + QuizName);
        Console.WriteLine("Total Questions  : " + TotalQuestions);
        Console.WriteLine("Correct Answers  : " + CorrectAnswers);
        Console.WriteLine("Wrong Answers    : " + WrongAnswers);
        Console.WriteLine("Skipped Answers  : " + SkippedAnswers);
        Console.WriteLine("Percentage       : " + Percentage.ToString("0.00") + "%");
        Console.WriteLine("Grade            : " + Grade);
        Console.WriteLine("Status           : " + Status);

        Console.WriteLine("----------------------------------------");
    }
}


// ============================================================
// STATISTICS CLASS
// ============================================================

class QuizStatistics
{
    public int TotalStudents;
    public int TotalQuestionsAttempted;
    public int TotalCorrectAnswers;
    public int TotalWrongAnswers;
    public int TotalSkippedAnswers;

    public double AveragePercentage;
    public double HighestPercentage;
    public double LowestPercentage;

    public QuizStatistics()
    {
        TotalStudents = 0;
        TotalQuestionsAttempted = 0;
        TotalCorrectAnswers = 0;
        TotalWrongAnswers = 0;
        TotalSkippedAnswers = 0;

        AveragePercentage = 0;
        HighestPercentage = 0;
        LowestPercentage = 0;
    }

    // Calculate statistics
    public void CalculateStatistics(QuizResult[] results, int count)
    {
        if (count == 0)
        {
            return;
        }

        TotalStudents = count;

        double totalPercentage = 0;

        HighestPercentage = results[0].Percentage;
        LowestPercentage = results[0].Percentage;

        for (int i = 0; i < count; i++)
        {
            TotalQuestionsAttempted =
                TotalQuestionsAttempted + results[i].TotalQuestions;

            TotalCorrectAnswers =
                TotalCorrectAnswers + results[i].CorrectAnswers;

            TotalWrongAnswers =
                TotalWrongAnswers + results[i].WrongAnswers;

            TotalSkippedAnswers =
                TotalSkippedAnswers + results[i].SkippedAnswers;

            totalPercentage =
                totalPercentage + results[i].Percentage;

            if (results[i].Percentage > HighestPercentage)
            {
                HighestPercentage = results[i].Percentage;
            }

            if (results[i].Percentage < LowestPercentage)
            {
                LowestPercentage = results[i].Percentage;
            }
        }

        AveragePercentage = totalPercentage / count;
    }

    // Display statistics
    public void DisplayStatistics()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("           QUIZ STATISTICS");
        Console.WriteLine("========================================");

        Console.WriteLine("Total Students       : " + TotalStudents);
        Console.WriteLine("Total Questions      : " + TotalQuestionsAttempted);
        Console.WriteLine("Total Correct        : " + TotalCorrectAnswers);
        Console.WriteLine("Total Wrong          : " + TotalWrongAnswers);
        Console.WriteLine("Total Skipped        : " + TotalSkippedAnswers);

        Console.WriteLine(
            "Average Percentage   : " +
            AveragePercentage.ToString("0.00") + "%");

        Console.WriteLine(
            "Highest Percentage   : " +
            HighestPercentage.ToString("0.00") + "%");

        Console.WriteLine(
            "Lowest Percentage    : " +
            LowestPercentage.ToString("0.00") + "%");

        Console.WriteLine("========================================");
    }

    // Find pass percentage
    public double CalculatePassPercentage(QuizResult[] results, int count)
    {
        if (count == 0)
        {
            return 0;
        }

        int passedStudents = 0;

        for (int i = 0; i < count; i++)
        {
            if (results[i].Percentage >= 50)
            {
                passedStudents++;
            }
        }

        return ((double)passedStudents / count) * 100;
    }

    // Find fail percentage
    public double CalculateFailPercentage(QuizResult[] results, int count)
    {
        if (count == 0)
        {
            return 0;
        }

        int failedStudents = 0;

        for (int i = 0; i < count; i++)
        {
            if (results[i].Percentage < 50)
            {
                failedStudents++;
            }
        }

        return ((double)failedStudents / count) * 100;
    }

    // Find number of A grades
    public int CountGradeA(QuizResult[] results, int count)
    {
        int total = 0;

        for (int i = 0; i < count; i++)
        {
            if (results[i].Grade == "A")
            {
                total++;
            }
        }

        return total;
    }

    // Find number of B grades
    public int CountGradeB(QuizResult[] results, int count)
    {
        int total = 0;

        for (int i = 0; i < count; i++)
        {
            if (results[i].Grade == "B")
            {
                total++;
            }
        }

        return total;
    }

    // Find number of C grades
    public int CountGradeC(QuizResult[] results, int count)
    {
        int total = 0;

        for (int i = 0; i < count; i++)
        {
            if (results[i].Grade == "C")
            {
                total++;
            }
        }

        return total;
    }

    // Find number of D grades
    public int CountGradeD(QuizResult[] results, int count)
    {
        int total = 0;

        for (int i = 0; i < count; i++)
        {
            if (results[i].Grade == "D")
            {
                total++;
            }
        }

        return total;
    }

    // Find number of F grades
    public int CountGradeF(QuizResult[] results, int count)
    {
        int total = 0;

        for (int i = 0; i < count; i++)
        {
            if (results[i].Grade == "F")
            {
                total++;
            }
        }

        return total;
    }

}


// ============================================================
// RANKING CLASS
// ============================================================

class QuizRanking
{
    // Sort students according to percentage
    public void SortByPercentage(
        QuizResult[] results,
        int count)
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (results[i].Percentage < results[j].Percentage)
                {
                    QuizResult temp = results[i];

                    results[i] = results[j];

                    results[j] = temp;
                }
            }
        }
    }


    // Display ranking
    public void DisplayRanking(
        QuizResult[] results,
        int count)
    {
        SortByPercentage(results, count);

        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("                QUIZ RANKING");
        Console.WriteLine("==============================================");

        Console.WriteLine(
            "{0,-8} {1,-10} {2,-20} {3,-12}",
            "Rank",
            "ID",
            "Student",
            "Percentage");

        Console.WriteLine("----------------------------------------------");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                "{0,-8} {1,-10} {2,-20} {3,-12:0.00}",
                i + 1,
                results[i].StudentID,
                results[i].StudentName,
                results[i].Percentage);
        }

        Console.WriteLine("==============================================");
    }
}
