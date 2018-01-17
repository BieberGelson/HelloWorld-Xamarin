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
	public partial class AbsoluteLayoutCodeBehind : ContentPage
	{
		public AbsoluteLayoutCodeBehind ()
		{
			InitializeComponent ();
            var layout = new AbsoluteLayout();
            Content = layout;
            var AquaBoxView = new BoxView { BackgroundColor = Color.Aqua };
            layout.Children.Add(AquaBoxView, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
            var whiteboxview = new BoxView { BackgroundColor = Color.White };
            layout.Children.Add(whiteboxview, new Rectangle(0.5, 0.1, 100, 100), AbsoluteLayoutFlags.PositionProportional);
            var botao = new Button { Text = "Texto do Botão" };
            layout.Children.Add(botao, new Rectangle(0, 1, 1, 0.1), AbsoluteLayoutFlags.All);

		}
	}
}