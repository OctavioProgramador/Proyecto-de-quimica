
using System;
using System.Threading;
using System.Runtime.Serialization;


namespace WindowsFormsApp1
{
    [Serializable()]
    public class Question : ISerializable
    {
        //Properties
        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public string WrongAnswer1 { get; set; }
        public string WrongAnswer2 { get; set; }
        public string WrongAnswer3 { get; set; }
        private string[] posibleAnswer;

        public string GetPosibleAnswer(int indexOfAnswer)
        {
            return posibleAnswer[indexOfAnswer];
        }

        //Constructor
        public Question(string questionText, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
            WrongAnswer1 = wrongAnswer1;
            WrongAnswer2 = wrongAnswer2;
            WrongAnswer3 = wrongAnswer3;
        }

        //Methods

        public bool Reply(int answer)
        {
            return (posibleAnswer[answer - 1].Equals(CorrectAnswer));
        }

        public void SortTheAnswersRandomly()
        {           
            Random random = new Random();
            Thread.Sleep(10);
            int[] randomIndex = new int[4]
            {
                random.Next(4),
                random.Next(4),
                random.Next(4),
                random.Next(4),
            };
            Array.Sort(randomIndex, posibleAnswer);

        }

        //Serialize
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("QuestionText", QuestionText);
            info.AddValue("CorrectAnswer", CorrectAnswer);
            info.AddValue("WrongAnswer1", WrongAnswer1);
            info.AddValue("WrongAnswer2", WrongAnswer2);
            info.AddValue("WrongAnswer3", WrongAnswer3);
        }
        //Deserialize
        public Question(SerializationInfo info, StreamingContext ctxt)
        {
            QuestionText = (string)info.GetValue("QuestionText", typeof(string));
            CorrectAnswer = (string)info.GetValue("CorrectAnswer", typeof(string));
            WrongAnswer1 = (string)info.GetValue("WrongAnswer1", typeof(string));
            WrongAnswer2 = (string)info.GetValue("WrongAnswer2", typeof(string));
            WrongAnswer3 = (string)info.GetValue("WrongAnswer3", typeof(string));
        }
        
        public Question()
        {
            
            QuestionText = "1";
            CorrectAnswer = "1";
            WrongAnswer1 = "1";
            WrongAnswer2 = "1";
            WrongAnswer3 = "1";                     
        }
        public void CreatePosibleAnswers()
        {
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
