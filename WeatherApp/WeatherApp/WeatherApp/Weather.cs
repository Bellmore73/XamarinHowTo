﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public class Weather
    {
        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humididty { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }

        public Weather()
        {
            Title = string.Empty;
            Temperature = string.Empty;
            Wind = string.Empty;
            Humididty = string.Empty;
            Visibility = string.Empty;
            Sunrise = string.Empty;
            Sunset = string.Empty;
        }

    }
}
