using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tradeem.Views
{
    public partial class SignUp_PhoneNo_Page : ContentPage
    {
        public SignUp_PhoneNo_Page()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //            var pageVar = new Page2();
            //            NavigationPage.SetBackButtonTitle(pageVar, "Back-Pg2");
            //            Navigation.PushAsync(pageVar);
            //            NavigationPage.SetHasNavigationBar(pageVar, false);
            //            NavigationPage.SetHasBackButton(pageVar, false);

            Navigation.PushAsync(new SignUpVerificationPage());
        }
    }
}
