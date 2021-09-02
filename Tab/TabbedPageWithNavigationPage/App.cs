using System.Diagnostics;
using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class App : Application
	{
		//We are navigating back to this Home Page in our app. From where user can go to another pages.
		public static HomePage Home;

		//We are using this as static NavigationPage to save user's last page viewed.
        //Then when navigating again from Home Page, the user should go to the last page he has viewed.
        //In that case, it should open again the Tabbed Page with the previous oppend Tab.
		public static MyNavigationPage Main; 

		public App ()
		{
			MainPage = Home = new HomePage();
        }

		protected override void OnStart ()
		{
			Debug.WriteLine("OnStart");
		}

		protected override void OnSleep ()
		{
			Debug.WriteLine("OnSleep");
		}

		protected override void OnResume ()
		{
			Debug.WriteLine("OnResume");
		}
	}
}

