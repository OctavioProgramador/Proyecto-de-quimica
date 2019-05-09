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
        public List<Question> questions;
        
        //Constructor
        public Test()
        {
            rute = Directory.GetCurrentDirectory() + @"\questions.xml";
            EnterQuestions();
            //SortTheQuestionsRandomly();
        }

        public string AsingPlayerName()
        {
            System.Console.WriteLine("Write your name");
            return Console.ReadLine();
        }
    
        public void EnterQuestions()
        {
            if (File.Exists(rute))
            {
                Deserialize();
            }
            else
            {
                questions = new List<Question>()
                {
                    new Question("2+2","4","2","3","5"),
                };
                Serialize();
            }
            foreach (Question q in questions)
            {
                q.CreatePosibleAnswers();                
            }
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