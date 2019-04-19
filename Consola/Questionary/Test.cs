using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.IO;

namespace Questionary
{
    class Test
    {
        //Fields
        public string rute;
        public Question[] questions;
 
        //Constructor
        public Test()
        {
            rute = Directory.GetCurrentDirectory()+@"\questions.xml";
            EnterQuestions();
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
            int[] indexArray = new int[questions.Length];
            for(int i = 0;i<questions.Length-1;i++)
            {
                indexArray[i] = rndIndex.Next(3);
            }
            Array.Sort(indexArray,questions);

        }
        public void EnterQuestions()
        {
            if(File.Exists(rute))
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
        }

        //Deserealize
        public void Deserialize()
        {
            using (FileStream fs = File.OpenRead(rute))
            {  
                XmlSerializer serializer = new XmlSerializer(typeof(Question[]));
                questions = (Question[])serializer.Deserialize(fs);
            }
        }
         public void Serialize()
        {
            using (Stream fs = new FileStream(rute,FileMode.Create,FileAccess.Write, FileShare.None))
            {  
                XmlSerializer serializer = new XmlSerializer(typeof(Question[]));
                serializer.Serialize(fs, questions);
            }
        }
    }
    
}