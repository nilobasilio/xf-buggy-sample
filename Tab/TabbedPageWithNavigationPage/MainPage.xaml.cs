using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        void Back_Clicked(object sender, System.EventArgs e)
        {
			App.Current.MainPage = App.Home;
		}

		// On Android back button pressed, do nothing.
		protected override bool OnBackButtonPressed() => true;
	}
}

