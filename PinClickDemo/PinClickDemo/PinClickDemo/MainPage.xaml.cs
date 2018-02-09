using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PinClickDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		    Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(
		        new Position(-23.4859591, -47.4420192),
		        Distance.FromMiles(0.5)));
        }

	    private void Mapa_OnTap(object sender, TapEventArgs e)
	    {
	        var pin = new Pin
	        {
	            Type = PinType.Place,
	            Position = e.Position,
	            Label = "Cliked",
	            Address = e.Position.Latitude + " X " + e.Position.Latitude,
	        };

	        Mapa.Pins.Add(pin);
	    }
    }
}
