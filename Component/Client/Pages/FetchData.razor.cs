using Component.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Component.Client.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] forecasts;

        public WeatherForecast[] Forecasts { get => forecasts; set => forecasts = value; }

        protected override async Task OnInitializedAsync()
        {
            Forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
}
