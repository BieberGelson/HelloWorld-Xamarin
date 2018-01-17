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
	public partial class GridExercicio1 : ContentPage
	{
		public GridExercicio1 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var botao = sender as Button;
            LabelNumeros.Text = LabelNumeros.Text + botao.Text;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            LabelNumeros.Text = "";
        }
    }
}