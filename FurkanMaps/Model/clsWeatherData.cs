using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanMaps.Model
{
    public class clsWeatherData
    {
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Astro
    {
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string moonrise { get; set; }
        public string moonset { get; set; }
        public string moon_phase { get; set; }
        public string moon_illumination { get; set; }
        public int is_moon_up { get; set; }
        public int is_sun_up { get; set; }
    }

    public class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
        public int code { get; set; }
    }

    public class Current
    {
        public int last_updated_epoch { get; set; }
        public string last_updated { get; set; }
        public decimal temp_c { get; set; }
        public decimal temp_f { get; set; }
        public int is_day { get; set; }
        public Condition condition { get; set; }
        public decimal wind_mph { get; set; }
        public decimal wind_kph { get; set; }
        public int wind_degree { get; set; }
        public string wind_dir { get; set; }
        public decimal pressure_mb { get; set; }
        public decimal pressure_in { get; set; }
        public decimal precip_mm { get; set; }
        public decimal precip_in { get; set; }
        public decimal humidity { get; set; }
        public decimal cloud { get; set; }
        public decimal feelslike_c { get; set; }
        public decimal feelslike_f { get; set; }
        public decimal vis_km { get; set; }
        public decimal vis_miles { get; set; }
        public decimal uv { get; set; }
        public decimal gust_mph { get; set; }
        public decimal gust_kph { get; set; }
    }

    public class Day
    {
        public decimal maxtemp_c { get; set; }
        public decimal maxtemp_f { get; set; }
        public decimal mintemp_c { get; set; }
        public decimal mintemp_f { get; set; }
        public decimal avgtemp_c { get; set; }
        public decimal avgtemp_f { get; set; }
        public decimal maxwind_mph { get; set; }
        public decimal maxwind_kph { get; set; }
        public decimal totalprecip_mm { get; set; }
        public decimal totalprecip_in { get; set; }
        public decimal totalsnow_cm { get; set; }
        public decimal avgvis_km { get; set; }
        public decimal avgvis_miles { get; set; }
        public decimal avghumidity { get; set; }
        public int daily_will_it_rain { get; set; }
        public decimal daily_chance_of_rain { get; set; }
        public int daily_will_it_snow { get; set; }
        public decimal daily_chance_of_snow { get; set; }
        public Condition condition { get; set; }
        public decimal uv { get; set; }
    }

    public class Forecast
    {
        public List<Forecastday> forecastday { get; set; }
    }

    public class Forecastday
    {
        public string date { get; set; }
        public int date_epoch { get; set; }
        public Day day { get; set; }
        public Astro astro { get; set; }
        public List<Hour> hour { get; set; }
    }

    public class Hour
    {
        public int time_epoch { get; set; }
        public string time { get; set; }
        public decimal temp_c { get; set; }
        public decimal temp_f { get; set; }
        public int is_day { get; set; }
        public Condition condition { get; set; }
        public decimal wind_mph { get; set; }
        public decimal wind_kph { get; set; }
        public decimal wind_degree { get; set; }
        public string wind_dir { get; set; }
        public decimal pressure_mb { get; set; }
        public decimal pressure_in { get; set; }
        public decimal precip_mm { get; set; }
        public decimal precip_in { get; set; }
        public decimal humidity { get; set; }
        public decimal cloud { get; set; }
        public decimal feelslike_c { get; set; }
        public decimal feelslike_f { get; set; }
        public decimal windchill_c { get; set; }
        public decimal windchill_f { get; set; }
        public decimal heatindex_c { get; set; }
        public decimal heatindex_f { get; set; }
        public decimal dewpoint_c { get; set; }
        public decimal dewpoint_f { get; set; }
        public bool will_it_rain { get; set; }
        public decimal chance_of_rain { get; set; }
        public bool will_it_snow { get; set; }
        public decimal chance_of_snow { get; set; }
        public decimal vis_km { get; set; }
        public decimal vis_miles { get; set; }
        public decimal gust_mph { get; set; }
        public decimal gust_kph { get; set; }
        public decimal uv { get; set; }
    }

    public class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public decimal lat { get; set; }
        public decimal lon { get; set; }
        public string tz_id { get; set; }
        public int localtime_epoch { get; set; }
        public string localtime { get; set; }
    }

    public class Root
    {
        public Location location { get; set; }
        public Current current { get; set; }
        public Forecast forecast { get; set; }
    }


    [PrimaryKey(nameof(city), nameof(time))]
    public class MyForecastData : IWeatherData
    {
        public string city { get; set; }       
        public DateTime time { get; set; }
        public decimal temp_c { get; set; }
        public decimal temp_f { get; set; }          
        public decimal wind_mph { get; set; }
        public decimal wind_kph { get; set; }
        public decimal wind_degree { get; set; }
        public string wind_dir { get; set; }
        public decimal pressure_mb { get; set; }
        public decimal pressure_in { get; set; }
        public decimal precip_mm { get; set; }
        public decimal precip_in { get; set; }
        public decimal humidity { get; set; }
        public decimal cloud { get; set; }
        public decimal feelslike_c { get; set; }
        public decimal feelslike_f { get; set; }
        public decimal windchill_c { get; set; }
        public decimal windchill_f { get; set; }
        public decimal heatindex_c { get; set; }
        public decimal heatindex_f { get; set; }
        public decimal dewpoint_c { get; set; }
        public decimal dewpoint_f { get; set; }
        public bool will_it_rain { get; set; }
        public decimal chance_of_rain { get; set; }
        public bool will_it_snow { get; set; }
        public decimal chance_of_snow { get; set; }
        public decimal vis_km { get; set; }
        public decimal vis_miles { get; set; }
        public decimal gust_mph { get; set; }
        public decimal gust_kph { get; set; }
        public decimal uv { get; set; }

    }
    [PrimaryKey(nameof(city), nameof(time))]
    public class MyHistoricData: IWeatherData
    {
        public string city { get; set; }
        public DateTime time { get; set; }
        public decimal temp_c { get; set; }
        public decimal temp_f { get; set; }
        public decimal wind_mph { get; set; }
        public decimal wind_kph { get; set; }
        public decimal wind_degree { get; set; }
        public string wind_dir { get; set; }
        public decimal pressure_mb { get; set; }
        public decimal pressure_in { get; set; }
        public decimal precip_mm { get; set; }
        public decimal precip_in { get; set; }
        public decimal humidity { get; set; }
        public decimal cloud { get; set; }
        public decimal feelslike_c { get; set; }
        public decimal feelslike_f { get; set; }
        public decimal windchill_c { get; set; }
        public decimal windchill_f { get; set; }
        public decimal heatindex_c { get; set; }
        public decimal heatindex_f { get; set; }
        public decimal dewpoint_c { get; set; }
        public decimal dewpoint_f { get; set; }
        public bool will_it_rain { get; set; }
        public decimal chance_of_rain { get; set; }
        public bool will_it_snow { get; set; }
        public decimal chance_of_snow { get; set; }
        public decimal vis_km { get; set; }
        public decimal vis_miles { get; set; }
        public decimal gust_mph { get; set; }
        public decimal gust_kph { get; set; }
        public decimal uv { get; set; }


    }
    public interface IWeatherData
    {
        public string city { get; set; }
        public DateTime time { get; set; }
        public decimal temp_c { get; set; }
        public decimal temp_f { get; set; }
        public decimal wind_mph { get; set; }
        public decimal wind_kph { get; set; }
        public decimal wind_degree { get; set; }
        public string wind_dir { get; set; }
        public decimal pressure_mb { get; set; }
        public decimal pressure_in { get; set; }
        public decimal precip_mm { get; set; }
        public decimal precip_in { get; set; }
        public decimal humidity { get; set; }
        public decimal cloud { get; set; }
        public decimal feelslike_c { get; set; }
        public decimal feelslike_f { get; set; }
        public decimal windchill_c { get; set; }
        public decimal windchill_f { get; set; }
        public decimal heatindex_c { get; set; }
        public decimal heatindex_f { get; set; }
        public decimal dewpoint_c { get; set; }
        public decimal dewpoint_f { get; set; }
        public bool will_it_rain { get; set; }
        public decimal chance_of_rain { get; set; }
        public bool will_it_snow { get; set; }
        public decimal chance_of_snow { get; set; }
        public decimal vis_km { get; set; }
        public decimal vis_miles { get; set; }
        public decimal gust_mph { get; set; }
        public decimal gust_kph { get; set; }
        public decimal uv { get; set; }
    }
    public class MapWeather : MyHistoricData
    {

    }
        
    public class CurrentWeather : Current
    {

    }
}
