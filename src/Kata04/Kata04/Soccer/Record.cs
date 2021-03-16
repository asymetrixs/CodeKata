using System;

namespace CodeKata.Kata04.Soccer
{
    public class Record
    {
        public Record(string name, int againstOpponent, int forOpponent)
        {
            this.Name = name;
            this.AgainstOpponent = againstOpponent;
            this.ForOpponent = forOpponent;
            this.Difference = Math.Abs(againstOpponent - forOpponent);
        }

        public string Name { get; }

        public int AgainstOpponent { get; }

        public int ForOpponent { get; }

        public int Difference { get; }
    }
}
