namespace CodeKata.Kata06
{
    public class LetterCount
    {
        public char Letter { get; init; }

        public int Count { get; init; }

        public string Representation
        {
            get
            {
                return $"{this.Letter}={this.Count}";
            }
        }
    }
}
