using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WeatherPage : ContentPage
	{
		public WeatherPage ()
		{
			InitializeComponent ();
		    Title = "Sample Weather App";
		    getWeatherBtn.Clicked += GetWeatherButton_Clicked;
		}

	    private async void GetWeatherButton_Clicked(object sender, EventArgs e)
	    {
	        var weather = await Core.GetWeather("60601");
	        getWeatherBtn.Text = weather.Title;
	    }

    }
}