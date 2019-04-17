using System;
using System.Collections.Generic;

namespace Questionary
{
    class Test
    {
        //Fields
        private List<Question> questions;
        private Player currentlyPlayer;

        //Constructor
        public Test()
        {
            currentlyPlayer = new Player();
            questions = new List<Question>()
            {
                new Question("2+2","4","2","3","5"),
                new Question("2*2","4","2","3","5"),
                new Question("2-2","0","2","3","5"),
            };
        }

        //Methods
        public void Start()
        {
            AsingPlayerName();
            DoQuestions();
        }
        public void AsingPlayerName()
        {
            System.Console.WriteLine("Write your name");
            currentlyPlayer.Name = Console.ReadLine();
        }
        public void DoQuestions()
        {
            foreach(var question in questions)
            {
                Console.WriteLine(question.ToString());
                currentlyPlayer.Score = question.Reply();
            }
        }

    }
    
}