using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml;

namespace WindowsFormsApp1
{
    [Serializable()]
    public class Player : IComparable, ISerializable
    {
        public String Name;
        public int Score;

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public Player()
        {

        }

        public int CompareTo(object obj)
        {
            return this.Score.CompareTo(((Player)obj).Score);
        }

        public override string ToString()
        {
            return String.Format($"{Name}: {Score} points");
        }

        //Serialize
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Score", Score);
        }
        //Deserialize
        public Player(SerializationInfo info, StreamingContext ctxt)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Score = (int)info.GetValue("Name", typeof(int));

        }
    }
}