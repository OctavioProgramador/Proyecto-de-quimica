using System;
using System.Collections;
using System.Collections.Generic;

namespace Questionary
{
    class Test
    {
        //Fields
        private Question[] questions;
        private Player currentlyPlayer;
        private int[] indexArray;
        private Random rndIndex;

        //Constructor
        public Test()
        {
            rndIndex = new Random();
            currentlyPlayer = new Player();
            questions = new Question[]
            {
                new Question("2+2","4","2","3","5"),
                new Question("2*2","4","2","3","5"),
                new Question("2-2","0","2","3","5")
            };
            indexArray = new int[] 
            {
                rndIndex.Next(3),
                rndIndex.Next(3),
                rndIndex.Next(3)  
            };
            Array.Sort(indexArray,questions);
        }

        //Methods
        public Player Start()
        {
            AsingPlayerName();
            DoQuestions();
            return currentlyPlayer;
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
                currentlyPlayer.Score +=
                question.Reply();
            }
        }

    }
    
}