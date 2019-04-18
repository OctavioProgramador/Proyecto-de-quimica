using System;
using System.Collections.Generic;

namespace Questionary
{
    class Question
    {
        //Properties
        public string QuestionText {get; set;}
        public string CorrectAnswer {get; set;}
        public string WrongAnswer1{get; set;}
        public string WrongAnswer2{get; set;}
        public string WrongAnswer3{get; set;}
        private string[] posibleAnswer;

        //Constructor
        public Question(string questionText,string correctAnswer,string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
            WrongAnswer1 = wrongAnswer1;
            WrongAnswer2 = wrongAnswer2;
            WrongAnswer3 = wrongAnswer3;     
            posibleAnswer = new string[4]
            {
                CorrectAnswer,
                WrongAnswer1,
                WrongAnswer2,
                WrongAnswer3
            };
            SortTheAnswersRandomly(); 
        }

        //Methods
        public override string ToString()
        {    
            return String.Format(QuestionText+"\n1)"+posibleAnswer[0]+"\n2)"+posibleAnswer[1]+"\n3)"+posibleAnswer[2]+"\n4)"+posibleAnswer[3]);
        }
        public int Reply()
        {
            int answer=0;
            answer = int.Parse(Console.ReadLine());
            if (posibleAnswer[answer-1].Equals(CorrectAnswer))
            {
                System.Console.WriteLine("Correct answer +1 point");
                return 1;
            }
            else
            {
                System.Console.WriteLine("Error, wrong answer");
                return 0;
            }
        }
        public void SortTheAnswersRandomly()
        {
            Random random = new Random();
            int[] randomIndex = new int[4]
            {
                random.Next(4),
                random.Next(4),
                random.Next(4),
                random.Next(4),            
            };
            Array.Sort(randomIndex,posibleAnswer);
        }
    }
}