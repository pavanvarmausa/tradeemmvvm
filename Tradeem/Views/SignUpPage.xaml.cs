﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tradeem.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.SignUp;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
//            Navigation.PushAsync(new SignUpSuccessPage());
            Navigation.PushAsync(new SignUp_PhoneNo_Page());
        }
    }
}