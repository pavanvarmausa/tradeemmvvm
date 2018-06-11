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
            var viewModel = App.Locator.Login;
            BindingContext = viewModel;
        }
    }
}
