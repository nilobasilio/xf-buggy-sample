using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
    public class MyNavigationPage : NavigationPage
    {
		public MyNavigationPage()
		{
			BarTextColor = Color.White;
			ToolbarItems.Add(new ToolbarItem("Go Home Page",
											 "",
											 GoToHomePage,
											 ToolbarItemOrder.Default,
											 0));
		}

		public MyNavigationPage(Page root) : base(root)
		{
			BarTextColor = Color.White;		
			ToolbarItems.Add(new ToolbarItem("Go Home Page",
											 "",
											 GoToHomePage,
											 ToolbarItemOrder.Default,
											 0));
		}

		void GoToHomePage()
		{
			App.Current.MainPage = App.Home;
		}
	}
}

