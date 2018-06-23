using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tradeem.Views
{
    public partial class SignUpBirthDayPage : ContentPage
    {
        public SignUpBirthDayPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpGenderPage());
        }
    }
}
