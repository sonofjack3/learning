using System;

namespace WebApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary
        {
            get {
                if (TemperatureC <= 0) 
                    return "Freezing";
                else if (TemperatureC > 0 && TemperatureC <= 5)
                    return "Chilly";
                else if (TemperatureC > 5 && TemperatureC <= 10)
                    return "Cool";
                else if (TemperatureC > 10 && TemperatureC <= 15)
                    return "Mild";
                else if (TemperatureC > 15 && TemperatureC <= 20)
                    return "Warm";
                else if (TemperatureC > 20 && TemperatureC <= 25)
                    return "Balmy";
                else if (TemperatureC > 25 && TemperatureC <= 30)
                    return "Hot";
                else if (TemperatureC > 30 && TemperatureC <= 35)
                    return "Sweltering";
                else
                    return "Scorching";
            }
        }

    }
}
