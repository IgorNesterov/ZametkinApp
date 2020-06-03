using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace Zametkin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapePage : ContentPage
    {
        public MapePage(String coordiantes)
        {
            InitializeComponent();

            String s0 = coordiantes.Substring(0, coordiantes.IndexOf(';'));
            String s1 = coordiantes.Substring(coordiantes.IndexOf(';')+1);
            Pin pin = new Pin
            {
                Label = "Здесь!",
                Type = PinType.Place,
                Position = new Position(Double.Parse(s0), Double.Parse(s1))
            };

            MapSpan mapSpan = new MapSpan(pin.Position, 0.01, 0.01);
            Map map = new Map(mapSpan);
            map.Pins.Add(pin);
            Content = map;
        }
    }
}