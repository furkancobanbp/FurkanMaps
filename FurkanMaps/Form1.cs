using FurkanMaps.Functions;
using System.Linq;

namespace FurkanMaps.Model
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        List<clsSehir> sehirList = new();
        List<Root> RootData = new();
        public restApi api = new();
        public List<MapWeather> weatherList = new();

        GMap.NET.WindowsForms.GMapOverlay markerOverlay = new GMap.NET.WindowsForms.GMapOverlay();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(38.963745, 35.243322);
            gMapControl1.MinZoom = 5; // Zoom seviyesi
            gMapControl1.MaxZoom = 15;
            gMapControl1.Zoom = 5;
            gMapControl1.DragButton = MouseButtons.Left;

        }

        private void btnVeriGetir_Click(object sender, EventArgs e)
        {
            markerOverlay.Markers.Clear();

            DateTime baslangicTarihi = DateTime.UtcNow.AddDays(-1).Date.AddHours(-3);
            DateTime bitisTarihi = baslangicTarihi.AddHours(23);

            using (context context = new context())
            {
                var list = context.tblSehir.ToList();
                sehirList.AddRange(list);


                foreach (clsSehir i in sehirList)
                {
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                       new GMap.NET.PointLatLng(i.lat, i.lon),
                       GMap.NET.WindowsForms.Markers.GMarkerGoogleType.purple);

                    var weatherData = context.tblHistoricWeatherData.
                        Where(p => p.time >= baslangicTarihi && p.time <= bitisTarihi).Where(s => s.city == i.SehirAdi).
                        GroupBy(p => p.city).
                        Select(p => new MapWeather { city = p.Key, temp_c = p.Average(s => s.temp_c), time = baslangicTarihi }).ToList();

                    marker.ToolTipText = i.SehirAdi + ": " + Math.Round(weatherData.FirstOrDefault().temp_c, 2) + "°"; // Ýl adý ve hava durumu
                    marker.ToolTipMode = GMap.NET.WindowsForms.MarkerTooltipMode.OnMouseOver;

                    markerOverlay.Markers.Add(marker);
                }
                gMapControl1.Overlays.Add(markerOverlay);
            }
            metroLabel1.Text = "Son Veri Alýnma Zamaný: " + DateTime.Now + "";

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            markerOverlay.Markers.Clear();
            using (context context = new context())
            {
                var list = context.tblSehir.ToList();
                sehirList.AddRange(list);


                foreach (clsSehir i in sehirList)
                {
                    RootData.Add(api.TahminHavaDurumu(DateTime.UtcNow.AddDays(+1).AddHours(-3), i.SehirAdi));
                }
                foreach (Root i in RootData)
                {
                    MapWeather mapData = new();

                    mapData.temp_c = i.current.temp_c;
                    mapData.time = DateTime.UtcNow.AddHours(-3);
                    if (!(i.location.name == "Van Ferit Melen Airport"))
                    {
                        mapData.city = i.location.name;
                    }
                    else
                    {
                        mapData.city = "Van";
                    }
                    weatherList.Add(mapData);
                }
                foreach (clsSehir i in sehirList)
                {
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                       new GMap.NET.PointLatLng(i.lat, i.lon),
                       GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot);

                    var weatherData = weatherList.Where(s => s.city == i.SehirAdi).
                        GroupBy(p => p.city).Select(p => new MapWeather { city = p.Key, temp_c = p.Average(s => s.temp_c) })
                        .ToList();

                    marker.ToolTipText = i.SehirAdi + ": " + Math.Round(weatherData.FirstOrDefault().temp_c, 2) + "°"; // Ýl adý ve hava durumu
                    marker.ToolTipMode = GMap.NET.WindowsForms.MarkerTooltipMode.OnMouseOver;

                    markerOverlay.Markers.Add(marker);

                }
                gMapControl1.Overlays.Add(markerOverlay);
            }
            metroLabel1.Text = "Son Veri Alýnma Zamaný: " + DateTime.Now + "";
        }
        private void btnTahminiHavaDurumu_Click(object sender, EventArgs e)
        {
            markerOverlay.Markers.Clear();

            DateTime baslangicTarihi = DateTime.UtcNow.AddDays(+1).Date.AddHours(-3);
            DateTime bitisTarihi = baslangicTarihi.AddHours(23);

            using (context context = new context())
            {
                var list = context.tblSehir.ToList();
                sehirList.AddRange(list);


                foreach (clsSehir i in sehirList)
                {
                    GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                       new GMap.NET.PointLatLng(i.lat, i.lon),
                       GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_dot);

                    var weatherData = context.tblForecastWeatherData.
                        Where(p => p.time >= baslangicTarihi && p.time <= bitisTarihi).Where(s => s.city == i.SehirAdi).
                        GroupBy(p => p.city).
                        Select(p => new MapWeather { city = p.Key, temp_c = p.Average(s => s.temp_c), time = baslangicTarihi }).ToList();

                    marker.ToolTipText = i.SehirAdi + ": " + Math.Round(weatherData.FirstOrDefault().temp_c, 2) + "°"; // Ýl adý ve hava durumu
                    marker.ToolTipMode = GMap.NET.WindowsForms.MarkerTooltipMode.OnMouseOver;

                    markerOverlay.Markers.Add(marker);
                }
                gMapControl1.Overlays.Add(markerOverlay);
            }
            metroLabel1.Text = "Son Veri Alýnma Zamaný: " + DateTime.Now + "";

        }
    }
}