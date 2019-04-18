using System;

namespace Questionary
{
    class Player: IComparable
    {
        public String Name;
        public int Score;
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(object obj)
        {
            return this.Score.CompareTo( ( (Player)obj ).Score );
        }
        public override string ToString()
        {
            return String.Format($"{Name}: {Score} points");
        }
    }
}