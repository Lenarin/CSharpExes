using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2_Observer
{
    public class AverageDisplay
    {
        private List<int> _temperatureList = new List<int>();
        private List<int> _humidityList = new List<int>();

        public void OnUpdate(WeatherStationData data)
        {
            _temperatureList.Add(data.Temperature);
            _humidityList.Add(data.Humidity);

            Console.WriteLine($"Средняя температура равна: {_temperatureList.Average()}, Средняя влажность равна: {_humidityList.Average()}");
        }
    }
}