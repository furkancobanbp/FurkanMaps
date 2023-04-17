
using Newtonsoft.Json;
using RestSharp;
using FurkanMaps.Model;


namespace FurkanMaps.Functions
{
    public class restApi
    {         
        public String WeatherApiKey = "378040fe1f0f427184983253230604";
        public String WeatherApiBaseUrl = "http://api.weatherapi.com/v1";
        

       
        public Root GecmisHavaDurumu(DateTime basTar, DateTime bitTar, String Sehir)
        {
            String baslangicTarihi = basTar.ToString("yyyy-MM-dd");
            String bitisTarihi = bitTar.ToString("yyyy-MM-dd");

            RestClient client = new RestClient(WeatherApiBaseUrl);
            var request = new RestRequest("/history.json");

            request.AddParameter("key", WeatherApiKey);
            request.AddParameter("dt", baslangicTarihi);
            request.AddParameter("end_dt", bitisTarihi);
            request.AddParameter("q", Sehir);
            request.AddParameter("lang", "TR");


            var Response = client.Execute(request).Content;

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Response);

            return myDeserializedClass;
        }

        public Root TahminHavaDurumu(DateTime bitTar, String Sehir)
        {
            String bitisTarihi = bitTar.ToString("yyyy-MM-dd");

            RestClient client = new RestClient(WeatherApiBaseUrl);
            var request = new RestRequest("/forecast.json");

            request.AddParameter("key", WeatherApiKey);
            request.AddParameter("dt", bitisTarihi);
            request.AddParameter("q", Sehir);
            request.AddParameter("lang", "tr");

            var Response = client.Execute(request).Content;

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Response);

            return myDeserializedClass;
        }
        public List<T> WeatherData<T>(Root RawData) where T : IWeatherData, new()
        {
            List<T> dataList = new List<T>();

            foreach (Forecastday i in RawData.forecast.forecastday)
            {
                foreach (Hour j in i.hour)
                {
                    T data = new T();

                    data.city = RawData.location.name;
                    data.time = Convert.ToDateTime(j.time);
                    data.uv = j.uv;
                    data.cloud = j.cloud;
                    data.wind_kph = j.wind_kph;
                    data.wind_mph = j.wind_mph;
                    data.pressure_in = j.pressure_in;
                    data.pressure_mb = j.pressure_mb;
                    data.wind_degree = j.wind_degree;
                    data.wind_dir = j.wind_dir;
                    data.temp_c = j.temp_c;
                    data.temp_f = j.temp_f;
                    data.precip_mm = j.precip_mm;
                    data.precip_in = j.precip_in;
                    data.humidity = j.humidity;
                    data.cloud = j.cloud;
                    data.feelslike_c = j.feelslike_c;
                    data.feelslike_f = j.feelslike_f;
                    data.windchill_c = j.windchill_c;
                    data.windchill_f = j.windchill_f;
                    data.heatindex_c = j.heatindex_c;
                    data.heatindex_f = j.heatindex_f;
                    data.dewpoint_c = j.dewpoint_c;
                    data.dewpoint_f = j.dewpoint_f;
                    data.will_it_rain = j.will_it_rain;
                    data.chance_of_rain = j.chance_of_rain;
                    data.will_it_snow = j.will_it_snow;
                    data.chance_of_snow = j.chance_of_snow;
                    data.vis_km = j.vis_km;
                    data.vis_miles = j.vis_miles;
                    data.gust_kph = j.gust_kph;

                    dataList.Add(data);
                }
            }

            return dataList;
        }

       
    }
    
}
