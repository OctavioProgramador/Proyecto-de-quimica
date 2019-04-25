using System;

using System.Collections.Generic;

using System.Xml.Serialization;

using System.IO;

namespace WindowsFormsApp1
{
    class Test
    {
        //Fields
        public string rute;
        //public Question[] questions;
        public List<Question> questions;
        
        //Constructor
        public Test()
        {
            rute = Directory.GetCurrentDirectory() + @"\questions.xml";
            EnterQuestions();
            //SortTheQuestionsRandomly();
        }

        //Methods
        /*public Player Start()
        {
            string playerName = "";
            int playerPoints = 0;
            playerName = AsingPlayerName();
            playerPoints = DoQuestions();
            return new Player(playerName, playerPoints);
        }*/

        public string AsingPlayerName()
        {
            System.Console.WriteLine("Write your name");
            return Console.ReadLine();
        }
    
        public void EnterQuestions()
        {
            /*
            if (File.Exists(rute))
            {
                Deserialize();
            }
            
            else
            {
            */
                questions = new List<Question>()
                {
                    new Question("Óxido de nitrogeno III","NO3","Fe2S3","SiO","SiO2"),
                    new Question("Óxido arsenoso","As2O3","As2O5","As2O4","Br2O5"),
                    new Question("Óxido brómico","Br2O5","Br2O3","Br2O","Br2O7"),
                };
               /*Serialize();
               
            }*/
        }

        //Deserealize
        public void Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
            using (FileStream fs = File.OpenRead(rute))
            {             
                questions = (List<Question>)serializer.Deserialize(fs);
            }


        }
        public void Serialize()
        {
            Stream fs = new FileStream(rute, FileMode.Create, FileAccess.Write, FileShare.None);
           
                XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
                serializer.Serialize(fs, questions);

        }
    }

}