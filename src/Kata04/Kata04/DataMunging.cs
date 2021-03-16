using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeKata.Kata04
{
    public static class DataMunging
    {
        public static WeatherData GetSmallestSpread()
        {
            // Read file content
            var fileContent = File.ReadAllLines("weather.dat", Encoding.UTF8);

            var weatherData = new List<WeatherData>();

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

                weatherData.Add(new WeatherData(day, mintemperature, maxTemperature));
            }

            // Assume first element has smallest spread, will be used as base to compare against
            // until a smaller is found
            WeatherData smallestSpread = weatherData[0];

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
