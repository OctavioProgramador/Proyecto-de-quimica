using System;
using System.Collections;
using System.Collections.Generic;

namespace Questionary
{
    class Test
    {
        //Fields
        private Question[] questions;
 
        //Constructor
        public Test()
        {
            questions = new Question[]
            {
                new Question("2+2","4","2","3","5"),
                new Question("2*2","4","2","3","5"),
                new Question("2-2","0","2","3","5")
            };
           SortTheQuestionsRandomly();
        }

        //Methods
        public Player Start()
        {
            string playerName="";
            int playerPoints=0;
            playerName = AsingPlayerName();
            playerPoints  = DoQuestions();
            return new Player(playerName,playerPoints);
        }
        public string AsingPlayerName()
        {
            System.Console.WriteLine("Write your name");
            return Console.ReadLine();
        }
        public int DoQuestions()
        {
            int puntuation = 0;
            foreach(var question in questions)
            {
                Console.WriteLine(question.ToString());
                puntuation += question.Reply();
            }
            return puntuation;
        }
        public void SortTheQuestionsRandomly()
        {
            Random rndIndex  = new Random();
            int[] indexArray = new int[] 
            {
                rndIndex.Next(3),
                rndIndex.Next(3),
                rndIndex.Next(3)  
            };
            Array.Sort(indexArray,questions);

        }

    }
    
}