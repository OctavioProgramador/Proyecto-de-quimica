using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.IO;


namespace WindowsFormsApp1
{
    class ScoreTable
    {
        public string rute;
        private List<Player> record;

        //Constructors

        public ScoreTable(int modePlayer)
        {
            if(modePlayer == 1)
            {
                //rute = Directory.GetCurrentDirectory() + @"\playerScore1PLayer.xml";
                rute = @".\playerScore1PLayer.xml";
            }
            else if(modePlayer == 2)
            {
                //rute = Directory.GetCurrentDirectory() + @"\playerScore2PLayer.xml";
                rute = @".\playerScore2PLayer.xml";
            }          
            record = new List<Player>();
            if (File.Exists(rute))
            {
                Deserialize();
            }
        }

        //Methods

        public List<Player> GetRecord()
        {
            return record;
        }
        public void Print()
        {

            foreach (Player player in record)
            {
                Console.WriteLine(player.ToString());
            }

        }
        public void AddPuntuation(Player newPuntuation)
        {

            record.Add(newPuntuation);
            record.Sort();
            record.Reverse();
            if (record.Count > 15)
            {
                record.Remove(record[15]);
            }
            Serialize();
        }    
        public void Deserialize()
        {
            using (FileStream fs = File.OpenRead(rute))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
                record = (List<Player>)serializer.Deserialize(fs);
            }
        }
        public void Serialize()
        {
            using (TextWriter fs = new StreamWriter(rute))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
                serializer.Serialize(fs, record);
            }
        }
    }
}