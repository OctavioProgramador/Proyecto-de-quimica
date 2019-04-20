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
    [Serializable()]
    class ScoreTable
    {
        public string rute;
        private List<Player> record;
        public ScoreTable()
        {
            rute = Directory.GetCurrentDirectory() + @"\playerScore.xml";
            record = new List<Player>();    
        }

        public void Print()
        {
     
            foreach (Player player in record)
            {
              Console.WriteLine(player.ToString());
            }
            Serialize();
        }

        public void AddPuntuation(Player newPuntuation)
        {
                
            record.Add(newPuntuation);
            record.Sort();
      
            if (record.Count > 15)
            {
                    record.Remove(record[15]);
            }
                
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