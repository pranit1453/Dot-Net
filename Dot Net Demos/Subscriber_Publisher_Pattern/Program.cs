namespace Subscriber_Publisher_Pattern
{
    public delegate void WeatherConditionDelegate(string condition,int temperature);
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation ws = WeatherConditionFactory.create();

        }
    }

    public class WeatherConditionFactory
    {
       public static WeatherStation create()
        {
            /*
             var is a type inference keyword in C#.
             When you declare a variable with var, the compiler automatically
             determines its type at compile time based on the value you assign.
             */
            var ws = new WeatherStation();
            WeatherDisplay wd = new WeatherDisplay();
            wd.Subscriber(ws);

            WeatherAlert wa = new WeatherAlert();
            wa.Subscriber(ws);

            WeatherLogger wl = new WeatherLogger();
            wl.Subscriber(ws);

            ws.UpdateWeather("Sunny", 30);
            ws.UpdateWeather("Rainy", 25);
            ws.UpdateWeather("Hot", 42);
            ws.UpdateWeather("Cold", 15);

            return ws;
        }
    }


    // Publisher
    public class WeatherStation
    {
        //create event 
        public event WeatherConditionDelegate? OnWeatherChanged;

        public void UpdateWeather(string condition, int temperature)
        {
            Console.WriteLine($"WeatherStation : Weather updated to {condition}, {temperature} °C");
            // Raise event...
            OnWeatherChanged?.Invoke(condition, temperature);
        } 
    }

    // Subscriber 1

    public class WeatherDisplay
    {
        public void Subscriber (WeatherStation station)
        {
            station.OnWeatherChanged += ShowWeather;
        }

        private void ShowWeather(string condition, int temperature)
        {
            Console.WriteLine($"[Display] Current Weather : {condition}, Temperature : {temperature} °C");
        }
    }

    // Subscriber 2
    public class WeatherAlert
    {
        public void Subscriber(WeatherStation station)
        {
            station.OnWeatherChanged += CheckAlert;
        }

        private void CheckAlert(string condition, int temperature)
        {
            if (temperature >= 40)
            {
                Console.WriteLine($"[Alert] Heatwave warning!!!");
            }
            else if(temperature >=10 && temperature <= 20)
            {
                Console.WriteLine("[Alert] Too much cold!!!");
            }
            else if (condition == "Rainy")
            {
                Console.WriteLine($"[Alert] Carry Umbrella too much rain...");
            }
            else if(condition == "Sunny")
            {
                Console.WriteLine($"[Alert] Too sunny...");
            }
        }
    }

    // Subscriber 3
    public class WeatherLogger
    {
        public void Subscriber (WeatherStation station)
        {
            station.OnWeatherChanged += LogWeather;
        }

        private void LogWeather(string condition, int temperature)
        {
            Console.WriteLine($"[Logger] Weather record : Condition = {condition}, Temperature = {temperature}");
        }
    }
}
