using System;
using System.Collections;
using System.Collections.Generic;

namespace Questionary
{
    class Game
    {
        private ScoreTable scoreTable;
        private Test test;
        public Game()
        {
            scoreTable = new ScoreTable();
            test = new Test();
        }
        public void Start()
        {
            int opt=0;
            System.Console.WriteLine("Welcome to the trivia game");
            System.Console.WriteLine("Chose one option");
            System.Console.WriteLine("1.-Game");
            System.Console.WriteLine("2.-Scores");
            System.Console.WriteLine("3.-Exit");
            opt = int.Parse(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    Console.Clear();
                    scoreTable.AddPuntuation(test.Start());
                    Console.ReadLine();
                    Console.Clear();
                    Start();
                break;
                case 2:
                    Console.Clear();    
                    
                break;    
                case 3:
                break;                   
            }
        }
    }
}