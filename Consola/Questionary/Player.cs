using System;

namespace Questionary
{
    class Player: IComparable
    {
        public String Name;
        public int Score;

        public int CompareTo(object obj)
        {
            return this.Score.CompareTo(((obj as Player).Score));
        }
        public override string ToString()
        {
            return String.Format($"{Name}: {Score} points");
        }
    }
}