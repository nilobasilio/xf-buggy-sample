using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class MainPageCS : TabbedPage
	{
		public MainPageCS ()
		{		

			Children.Add (new TodayPageCS ());
            Children.Add(new SchedulePage());
			Children.Add (new SettingsPage ());
		}
       
    }
}
