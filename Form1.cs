using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openwethermap
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async Task Clima()
        {
            TextBox t = new TextBox();
            t.Location = new System.Drawing.Point(6, 7);
            t.Text = "sdagsdagdsa";
            this.Controls.Add(t);
            try
            {
                string url =
                    "https://api.openweathermap.org/data/2.5/forecast&quot" +
                    "?lat=-34.6117691" +
                    "&lon=-58.4056336" +
                    "&appid=fdb0a8dc0570d9832beb6193975cd536" +
                    "&units=metric" +
                    "&lang=es";

                string json = await httpClient.GetStringAsync(url);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                WeatherResponse response =
                    JsonSerializer.Deserialize<WeatherResponse>(json, options);

                if (response == null || response.List == null)
                {
                    MessageBox.Show("No se pudo obtener el clima.");
                    return;
                }

                string resultado = "";

                foreach (WeatherItem item in response.List)
                {
                    // Convertimos el timestamp de OpenWeather a fecha/hora
                    DateTime fecha = DateTimeOffset
                        .FromUnixTimeSeconds(item.Dt)
                        .LocalDateTime;


                    string descripcion = "";

                    if (item.Weather != null && item.Weather.Count > 0)
                    {
                        descripcion = item.Weather[0].Description;
                    }

                    resultado +=
                        $"{fecha:dd/MM HH:mm} - " +
                        $"{item.Main.Temp:0}°C - " +
                        $"{descripcion}\r\n";
                }

                lbResultado.Text = resultado;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(
                    "Error al consultar OpenWeather:\r\n\r\n" +
                    ex.Message
                );
            }
            catch (JsonException ex)
            {
                MessageBox.Show(
                    "Error al interpretar el JSON:\r\n\r\n" +
                    ex.Message
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\r\n\r\n" +
                    ex.Message
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await Clima();
            PictureBox pictureBox = new PictureBox();
            pictureBox1.Image = pictureBox.Image;
        }
    }


    // =========================================================
    // RESPUESTA PRINCIPAL
    // =========================================================

    public class WeatherResponse
    {
        [JsonPropertyName("cod")]
        public string Cod { get; set; }

        [JsonPropertyName("message")]
        public double Message { get; set; }

        [JsonPropertyName("cnt")]
        public int Count { get; set; }

        [JsonPropertyName("list")]
        public List<WeatherItem> List { get; set; }

        [JsonPropertyName("city")]
        public City City { get; set; }
    }


    // =========================================================
    // CADA PRONÓSTICO
    // =========================================================

    public class WeatherItem
    {
        [JsonPropertyName("dt")]
        public long Dt { get; set; }

        [JsonPropertyName("main")]
        public MainWeather Main { get; set; }

        [JsonPropertyName("weather")]
        public List<WeatherDescription> Weather { get; set; }

        [JsonPropertyName("dt_txt")]
        public string DtTxt { get; set; }
    }


    // =========================================================
    // TEMPERATURA / HUMEDAD
    // =========================================================

    public class MainWeather
    {
        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonPropertyName("temp_min")]
        public double Temp_Min { get; set; }

        [JsonPropertyName("temp_max")]
        public double Temp_Max { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }


    // =========================================================
    // DESCRIPCIÓN DEL CLIMA
    // =========================================================

    public class WeatherDescription
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }


    // =========================================================
    // CIUDAD
    // =========================================================

    public class City
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("coord")]
        public Coordinates Coord { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("timezone")]
        public int Timezone { get; set; }
    }


    // =========================================================
    // COORDENADAS
    // =========================================================

    public class Coordinates
    {
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }
    }
}
