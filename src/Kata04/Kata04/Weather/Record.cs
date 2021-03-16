namespace CodeKata.Kata04.Weather
{
    public class Record
    {
        public Record(int day, int minTemperatur, int maxTemperatur)
        {
            this.Day = day;
            this.MinTemperator = minTemperatur;
            this.MaxTemperatur = maxTemperatur;
            this.TemperaturSpread = maxTemperatur - minTemperatur;
        }

        public int Day { get; }

        public int MinTemperator { get; }

        public int MaxTemperatur { get; }

        public int TemperaturSpread { get; }
    }
}
