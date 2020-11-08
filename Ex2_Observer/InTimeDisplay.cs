using System;
using System.Globalization;

namespace Ex2_Observer
{
    public class InTimeDisplay
    {
        public void OnUpdate(WeatherStationData data)
        {
            Console.WriteLine($"Во время {DateTime.Now.ToString(CultureInfo.CurrentCulture)} температура равнялась {data.Temperature}");
        }
    }
}