using Xamarin.Forms;

namespace FontIcons
{
	public partial class FontIconsPage : ContentPage
	{
		public FontIconsPage()
		{
			InitializeComponent();


		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			var panel = new StackLayout();
			var btn = new IconFontButton() { IconFont = "F000", FontSize=30 };
			var btn1 = new IconFontButton() { IconFont = "F013", FontSize=30 };
			var btn2 = new IconFontButton() { IconFont = "F06E",FontSize=30 };
			var btn3 = new IconFontButton() { IconFont = "F087",FontSize=60 };
			MainGrid.Children.Add(btn, 1, 1);
			MainGrid.Children.Add(btn1, 1, 2);
			MainGrid.Children.Add(btn2, 3, 1);
			MainGrid.Children.Add(btn3, 3, 2);
		}

	}
}

