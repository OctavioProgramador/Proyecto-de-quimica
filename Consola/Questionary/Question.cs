using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml;

namespace Questionary
{
    [Serializable()]
    public class Question: ISerializable
    {
        //Properties
        public string QuestionText {get; set;}
        public string CorrectAnswer {get; set;}
        public string WrongAnswer1{get; set;}
        public string WrongAnswer2{get; set;}
        public string WrongAnswer3{get; set;}
        [NonSerialized()]
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
            Random randomSeed = new Random();
            Random random = new Random(randomSeed.Next(100));
            int[] randomIndex = new int[4]
            {
                random.Next(4),
                random.Next(4),
                random.Next(4),
                random.Next(4),            
            };
            Array.Sort(randomIndex,posibleAnswer);
        }

        //Serialize
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("QuestionText",QuestionText);            
            info.AddValue("CorrectAnswer",CorrectAnswer);
            info.AddValue("WrongAnswer1",WrongAnswer1);
            info.AddValue("WrongAnswer2",WrongAnswer2);
            info.AddValue("WrongAnswer3",WrongAnswer3);
        }
        //Deserialize
        public Question(SerializationInfo info, StreamingContext ctxt)
        {
            QuestionText = (string)info.GetValue("QuestionText",typeof(string));
            CorrectAnswer = (string)info.GetValue("CorrectAnswer",typeof(string));
            WrongAnswer1 = (string)info.GetValue("WrongAnswer1",typeof(string));
            WrongAnswer2 = (string)info.GetValue("WrongAnswer2",typeof(string));
            WrongAnswer3 = (string)info.GetValue("WrongAnswer3",typeof(string));
            posibleAnswer = new string[4]
            {
                CorrectAnswer,
                WrongAnswer1,
                WrongAnswer2,
                WrongAnswer3
            };
            SortTheAnswersRandomly();             
        }
        public Question()
        {
            QuestionText = "1"; 
            CorrectAnswer = "1"; 
            WrongAnswer1 = "1"; 
            WrongAnswer2 = "1"; 
            WrongAnswer3 = "1"; 
                
            posibleAnswer = new string[4]
            {
                CorrectAnswer,
                WrongAnswer1,
                WrongAnswer2,
                WrongAnswer3
            };
            SortTheAnswersRandomly(); 
        }
    }
}