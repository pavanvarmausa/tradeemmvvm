using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tradeem.Views
{
    public partial class SignUpGenderPage : ContentPage
    {
        public string gender;
        public SignUpGenderPage()
        {
            InitializeComponent();

        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpInterestsPage());
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            gender = "Male";
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            gender = "Female";
        }
    }
}
