using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //If App.Main is null, instantiate it.
        //If not, reopen the last page viewed.
        void Button_Clicked(object sender, EventArgs e) => ShowMainPage();

        static void InitMainPageIfNull()
        {
            if (App.Main == null)
                App.Main = new MyNavigationPage(new MainPage());
        }

        static void ShowMainPage()
        {
            InitMainPageIfNull();
            Application.Current.MainPage = App.Main;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            InitMainPageIfNull();
        }

        // On Android back button pressed, do nothing.
        protected override bool OnBackButtonPressed() => true;
    }
}
