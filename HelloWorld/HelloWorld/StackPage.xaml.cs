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
	public partial class StackPage : ContentPage
	{
		public StackPage ()
		{
			InitializeComponent ();
            var layout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(0, 40, 0, 0),
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = Color.LightBlue
            };
            layout.Children.Add(new Label { Text = "Label 1" });
            var layout1 = new StackLayout
            {
                Padding = 40
            };
            layout1.Children.Add(new Label { Text = "Label 2" });
            layout1.Children.Add(new Label { Text = "Label 3" });
            layout.Children.Add(layout1);
            Content = layout;
		}
	}
}