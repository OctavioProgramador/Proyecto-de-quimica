using System;
using System.Collections;
using System.Collections.Generic;

namespace Questionary
{
    class ScoreTable
    {
        private List<Player> record;
        public ScoreTable()
        {
            record = new List<Player>();    
        }
        public void Print()
        {
            foreach(Player player in record)
            {
                Console.WriteLine(player.ToString());
            }
        }
        public void AddPuntuation(Player newPuntuation)
        {
            record.Add(newPuntuation);
            record.Sort();
            if(record.Count>15)
            {
                record.Remove(record[15]);
            }
        }
    }
}