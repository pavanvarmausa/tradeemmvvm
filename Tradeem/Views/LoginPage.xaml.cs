using System;
using System.Collections.Generic;
using Tradeem.Models;
using Xamarin.Forms;

namespace Tradeem.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            username.Focus();
            var viewModel = App.Locator.Login;
            BindingContext = viewModel;
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            try {
                if (username.Text.Length < 5)
                {
                    DisplayAlert("Invalid Username", "UserName must be at least 5 characters and only consist of letters, numbers or underscores.", "Close");
                    username.Focus();
                }
            }
            catch(NullReferenceException) {
                DisplayAlert("ok", "okay.", "ok");
                username.Focus();
            }

        } 
        void Handle_Completed_1(object sender, System.EventArgs e)
        {
            if (password.Text.Length < 6)
            {
                DisplayAlert("Invalid Password", "Password must be atleast 6 characters.", "Close");
                password.Focus();
            }
        }
    }
}
