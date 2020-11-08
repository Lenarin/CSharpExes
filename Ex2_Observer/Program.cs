using System;

namespace Ex2_Observer
{
    class Program
    {
        private static void Main(string[] args)
        {
            var station = new WeatherStation();
            
            var ad = new AverageDisplay();
            var itd = new InTimeDisplay();
            
            station.AddObserver(ad.OnUpdate);
            station.AddObserver(itd.OnUpdate);

            station.Data = new WeatherStationData
            {
                Humidity = 15,
                Temperature = 20
            };

            station.Data = new WeatherStationData
            {
                Humidity = 25,
                Temperature = 15
            };
            
            station.RemoveObserver(itd.OnUpdate);

            station.Data = new WeatherStationData
            {
                Humidity = 10,
                Temperature = 8
            };
        }
    }
}