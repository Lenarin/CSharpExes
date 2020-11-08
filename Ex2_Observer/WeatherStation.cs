using System;
using System.Collections.Generic;

namespace Ex2_Observer
{
    public delegate void OnUpdateEventHandlers(WeatherStationData data);
    public class WeatherStationData
    {
        protected internal int Temperature { get; set; }
        protected internal int Humidity { get; set; }
    }
    
    public class WeatherStation
    {
        private event OnUpdateEventHandlers UpdateEventHandlers;

        private int _temperature = 0;
        private int _humidity = 0;

        public WeatherStationData Data
        {
            get => new WeatherStationData {Humidity = _humidity, Temperature = _temperature};
            set { 
                _temperature = value.Temperature;
                _humidity = value.Humidity;
                InvokeOnUpdateEventHandlers();
            }
        }
        public void AddObserver(OnUpdateEventHandlers observer)
        {
            UpdateEventHandlers += observer;
        }

        public void RemoveObserver(OnUpdateEventHandlers observer)
        {
            UpdateEventHandlers -= observer;
        }
        
        protected void InvokeOnUpdateEventHandlers()
        {
            UpdateEventHandlers?.Invoke(new WeatherStationData
            {
                Temperature = _temperature,
                Humidity = _humidity
            });
        }
    }
}