using System;

namespace Questionary
{
    struct Player: IComparable
    {
        public String Name;
        public int Score;

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