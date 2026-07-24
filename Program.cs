#nullable disable
using System;

class Program
{
    static void Main(string[] args)
    {
        // Quiz Information
        Menu.quiz.QuizID = 1;
        Menu.quiz.QuizTitle = "OOP Quiz";
        Menu.quiz.PassingMarks = 5;

        // Question 1
        Question q1 = new Question();
        q1.QuestionID = 1;
        q1.QuestionText = "What does OOP stand for?";
        q1.OptionA = "Object Original Program";
        q1.OptionB = "Object-Oriented Programming";
        q1.OptionC = "Operating-Oriented Platform";
        q1.OptionD = "Object Operating Process";
        q1.CorrectAnswer = 'B';
        q1.Marks = 1;
        Menu.quiz.Questions.Add(q1);

        // Question 2
        Question q2 = new Question();
        q2.QuestionID = 2;
        q2.QuestionText = "What is a class?";
        q2.OptionA = "A function that returns values";
        q2.OptionB = "A template or blueprint to create objects";
        q2.OptionC = "A built-in variable type";
        q2.OptionD = "A file format for code storage";
        q2.CorrectAnswer = 'B';
        q2.Marks = 1;
        Menu.quiz.Questions.Add(q2);

        // Question 3
        Question q3 = new Question();
        q3.QuestionID = 3;
        q3.QuestionText = "What is an object?";
        q3.OptionA = "A keyword used to define loops";
        q3.OptionB = "An instance of a class";
        q3.OptionC = "A compilation error";
        q3.OptionD = "A type of database";
        q3.CorrectAnswer = 'B';
        q3.Marks = 1;
        Menu.quiz.Questions.Add(q3);

        // Question 4
        Question q4 = new Question();
        q4.QuestionID = 4;
        q4.QuestionText = "Which OOP feature allows code reusability through a parent-child relationship?";
        q4.OptionA = "Abstraction";
        q4.OptionB = "Polymorphism";
        q4.OptionC = "Encapsulation";
        q4.OptionD = "Inheritance";
        q4.CorrectAnswer = 'D';
        q4.Marks = 1;
        Menu.quiz.Questions.Add(q4);

        // Question 5
        Question q5 = new Question();
        q5.QuestionID = 5;
        q5.QuestionText = "Which concept wraps data and methods into a single unit while hiding internal states?";
        q5.OptionA = "Encapsulation";
        q5.OptionB = "Inheritance";
        q5.OptionC = "Overloading";
        q5.OptionD = "Compilation";
        q5.CorrectAnswer = 'A';
        q5.Marks = 1;
        Menu.quiz.Questions.Add(q5);

        // Question 6
        Question q6 = new Question();
        q6.QuestionID = 6;
        q6.QuestionText = "What term describes a single action or function behaving in different ways?";
        q6.OptionA = "Polymorphism";
        q6.OptionB = "Abstraction";
        q6.OptionC = "Encapsulation";
        q6.OptionD = "Instantiation";
        q6.CorrectAnswer = 'A';
        q6.Marks = 1;
        Menu.quiz.Questions.Add(q6);

        // Question 7
        Question q7 = new Question();
        q7.QuestionID = 7;
        q7.QuestionText = "What is the process of hiding complex background details and showing only essential features?";
        q7.OptionA = "Polymorphism";
        q7.OptionB = "Abstraction";
        q7.OptionC = "Inheritance";
        q7.OptionD = "Modularity";
        q7.CorrectAnswer = 'B';
        q7.Marks = 1;
        Menu.quiz.Questions.Add(q7);

        // Question 8
        Question q8 = new Question();
        q8.QuestionID = 8;
        q8.QuestionText = "What is a special member function that is automatically called when an object is created?";
        q8.OptionA = "Destructor";
        q8.OptionB = "Constructor";
        q8.OptionC = "Virtual function";
        q8.OptionD = "Getter";
        q8.CorrectAnswer = 'B';
        q8.Marks = 1;
        Menu.quiz.Questions.Add(q8);

        // Question 9
        Question q9 = new Question();
        q9.QuestionID = 9;
        q9.QuestionText = "Which of the following is NOT one of the main pillars of OOP?";
        q9.OptionA = "Encapsulation";
        q9.OptionB = "Inheritance";
        q9.OptionC = "Compilation";
        q9.OptionD = "Polymorphism";
        q9.CorrectAnswer = 'C';
        q9.Marks = 1;
        Menu.quiz.Questions.Add(q9);

        // Question 10
        Question q10 = new Question();
        q10.QuestionID = 10;
        q10.QuestionText = "Can an interface have a constructor?";
        q10.OptionA = "Yes";
        q10.OptionB = "No";
        q10.CorrectAnswer = 'B';
        q10.Marks = 1;
        Menu.quiz.Questions.Add(q10);

        // Start the Program
        Menu.MainMenu();
    }
}