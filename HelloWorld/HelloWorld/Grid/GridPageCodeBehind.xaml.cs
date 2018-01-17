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
	public partial class GridPageCodeBehind : ContentPage
	{
		public GridPageCodeBehind ()
		{
			InitializeComponent ();
            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 40
            };
            grid.BackgroundColor = Color.Yellow;
            
            var label = new Label { Text = "Label 1" };
            label.BackgroundColor = Color.Silver;
            grid.Children.Add(label, 0, 0);    //(elemento, numero da coluna, numero da linha
            grid.Children.Add(new Label { Text = "Label 2", BackgroundColor = Color.Silver }, 1, 0);    //(elemento, numero da coluna, numero da linha
            grid.Children.Add(new Label { Text = "Label 3", BackgroundColor = Color.Silver }, 2, 0);    //(elemento, numero da coluna, numero da linha

            grid.Children.Add(new Label { Text = "Label 1", BackgroundColor = Color.Silver }, 0, 2);    //(elemento, numero da coluna, numero da linha
            grid.Children.Add(new Label { Text = "Label 2", BackgroundColor = Color.Silver }, 1, 2);    //(elemento, numero da coluna, numero da linha
            grid.Children.Add(new Label { Text = "Label 3", BackgroundColor = Color.Silver }, 2, 2);    //(elemento, numero da coluna, numero da linha

            Grid.SetRowSpan(label, 2);
            Grid.SetColumnSpan(label, 2);
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute) //primeira linha do grid
            });
            
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(2, GridUnitType.Star) //segunda linha
            });
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Star) //terceira linha
            });
            Content = grid;
        }
	}
}