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
	public partial class RelativeLayoutCodeBehind : ContentPage
	{
		public RelativeLayoutCodeBehind ()
		{
			InitializeComponent ();
            var layout = new RelativeLayout();
            Content = layout;
            var aquabox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquabox,
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height * 0.3),
               widthConstraint: Constraint.RelativeToParent(parent => parent.Width));
            var silverbox = new BoxView { Color = Color.Silver };
            layout.Children.Add(silverbox,
                yConstraint: Constraint.RelativeToView(aquabox, (RelativeLayout, element) => element.Height + 20));
            
		}
	}
}