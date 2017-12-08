using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WeatherApp.ViewModels;
using Prism.Navigation;
using System.Net.Http;

namespace WeatherApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapsPage : ContentPage
	{
        Dictionary<string, string> nameToLayerType = new Dictionary<string, string>()
        {
            { "Clouds", "clouds_new" }, {"Precipitation", "precipitation_new" },
            { "Air Pressure", "pressure_new" }, { "Wind Speed", "wind_new" },
            { "Temperature", "temp_new" }
        };

        List<string> layers = new List<string>
        {
            "Clouds", "Precipitation", "Atmospheric Pressure", "Wind Speed", "Temperature"
        };
        public List<string> Layers => layers;

        public MapsPage()
		{
            InitializeComponent();

            PopulatePicker();
		}

        private void PopulatePicker()
        {
            foreach (var item in nameToLayerType)
            {
                MyPicker.Items.Add(item.Key);
            }

            MyPicker.SelectedIndex = 0;
        }
        
        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Code to handle user making index changes in picker
            string selectedItem = MyPicker.Items[MyPicker.SelectedIndex];

            string selectedType = nameToLayerType[selectedItem];

            HttpClient client = new HttpClient();
            var uri = new Uri(
                string.Format(
                    $"http://tile.openweathermap.org/map/{selectedType}/5/36.7741/-119.8389.png?appid=" +
                    $"{ApiKey.WeatherAPIKey}"));
            //var response = await client.GetAsync(uri);

            Device.OpenUri(uri);
        }
    }
}