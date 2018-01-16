using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}