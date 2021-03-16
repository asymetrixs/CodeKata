using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeKata.Kata04.Weather
{
    public static class WeatherData
    {
        public static Record GetSmallestSpread()
        {
            // Read file content
            var fileContent = File.ReadAllLines("Weather/weather.dat", Encoding.UTF8);

            var weatherData = new List<Record>();

            // Map file into pocos
            for (int i = 0; i < fileContent.Length; i++)
            {
                // Get line
                var line = fileContent[i];
                
                // Check if line has content
                if(string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                // Day part
                var textDay = line[..4];
                if(!int.TryParse(textDay.Trim(), out int day))
                {
                    continue;
                }

                // Temperature part
                var maxTemperature = int.Parse(line[4..8]);
                var mintemperature = int.Parse(line[9..14]);

                weatherData.Add(new Record(day, mintemperature, maxTemperature));
            }

            // Assume first element has smallest spread, will be used as base to compare against
            // until a smaller is found
            Record smallestSpread = weatherData[0];

            for (int i = 1; i < weatherData.Count; i++)
            {
                if(smallestSpread.TemperaturSpread > weatherData[i].TemperaturSpread)
                {
                    smallestSpread = weatherData[i];
                }
            }

            return smallestSpread;
        }
    }
}
