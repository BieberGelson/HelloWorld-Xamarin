using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Relative_Layout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RelativeLayoutEx1 : ContentPage
	{
		public RelativeLayoutEx1 ()
		{
			InitializeComponent ();
            var layout = new RelativeLayout();
            Content = layout;
            var banner = new BoxView { Color = Color.FromHex("#f7f7f7") };
            layout.Children.Add(banner,
                widthConstraint: Constraint.RelativeToParent((parent => parent.Width)),
                heightConstraint: Constraint.RelativeToParent((parent => parent.Height * 0.3)));
            var stacklayoutbanner = new StackLayout { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            var preco = new Label { TextColor = Color.FromHex("#33353a"), Text = "$11.95", FontSize = 60, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
            var botao = new Button { Text = "Add $7.99 Credit", BorderRadius = 15, BackgroundColor = Color.FromHex("#1695A3"), TextColor =Color.White,  FontSize = 15, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            stacklayoutbanner.Children.Add(preco);
            stacklayoutbanner.Children.Add(botao);
            layout.Children.Add(stacklayoutbanner,
                widthConstraint: Constraint.RelativeToParent((parent => parent.Width)),
                heightConstraint: Constraint.RelativeToParent((parent => parent.Height * 0.3)));

            var stacklayoutdescription = new StackLayout { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Spacing = 20};
            var labeltitulo = new Label { Text = "Why pay for credit?", FontSize = 15, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
            var labeldescription = new Label
            {
                FontSize = 13,
                Text = "Because you can reach people who arent't on\n" +
                "SkyApp by calling mobile and landline\n" +
                "numbers, or spending SMS, at low cost-rates.",
                HorizontalTextAlignment = TextAlignment.Center
            };

            stacklayoutdescription.Children.Add(labeltitulo);
            stacklayoutdescription.Children.Add(labeldescription);

            layout.Children.Add(stacklayoutdescription,
                  widthConstraint: Constraint.RelativeToParent((parent => parent.Width)),
                heightConstraint: Constraint.RelativeToParent((parent => parent.Height * 0.3)),
                yConstraint: Constraint.RelativeToView(banner, (RelativeLayout, element) => element.Height + 30));


		}
	}
}