using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tradeem.Views
{
    public partial class SignUpInterestsPage : ContentPage
    {
        public String Interests;

        public SignUpInterestsPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginSuccessPage());
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
//            throw new NotImplementedException();
            Navigation.PushAsync(new LoginSuccessPage());

        }
        void Handle_Clicked_2(Object sender, System.EventArgs e)
        {
            Interests += sender.ToString();
        }
        void Handle_Clicked_3(Object sender, System.EventArgs e)
        {
            Interests += sender.ToString();
        }
        void Handle_Clicked_4(Object sender, System.EventArgs e)
        {
            Interests += sender.ToString();
        }

    }
}
