using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.IO;

namespace Questionary2
{
    class Test
    {
        public string rute;
        public Question[] questions;
        private int numberOfQuestions;
        Player player;
 
        public Test()
        {
            player = new Player();
            rute = Directory.GetCurrentDirectory()+@"\questions.xml";
            InsertQuestionAndAnswers();
            SortTheQuestionsRandomly();
        }

        public void InsertQuestionAndAnswers()
        {
            if (File.Exists(rute))
            {
                Deserialize();
            }
            else
            {
                questions = new Question[]
                {
                    new Question("2+2","4","2","3","5"),
                    new Question("2*2","4","2","3","5"),
                    new Question("2-2","0","2","3","5")
                };
                Serialize();
            }
            foreach (Question question in questions)
            {
                question.CreatePosibleAnswer();
            }
        }

        public void Deserialize()
        {
            using (FileStream fileStream = File.OpenRead(rute))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Question[]));
                questions = (Question[])serializer.Deserialize(fileStream);
            }
        }

        public void Serialize()
        {
            using (Stream fileStream = new FileStream(rute, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Question[]));
                serializer.Serialize(fileStream, questions);
            }
        }

        public void SortTheQuestionsRandomly()
        {
            int[] indexArray = new int[numberOfQuestions];
            FillArrayWithRandomIndex(indexArray);
            Array.Sort(indexArray, questions);
        }

        private void FillArrayWithRandomIndex(int [] array)
        {
            Random rndIndex = new Random();
            for (int i = 0; i < numberOfQuestions - 1; i++)
            {
                array[i] = rndIndex.Next(numberOfQuestions);
            }
        }

        public void Start()
        {
            string playerName = "";
            int playerPoints = 0;
            playerName = AsingPlayerName();
            playerPoints  = DoQuestions();
            player = new Player(playerName,playerPoints);
        }

        public string AsingPlayerName()
        {
            Console.WriteLine("Write your name");
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

        public Player getPlayer()
        {
            return player;
        }
    }
    
}