using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tradeem.Views
{
    public partial class SignUpZipCodePage : ContentPage
    {
        public SignUpZipCodePage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpBirthDayPage());
        }
    }
}
