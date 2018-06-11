using System;
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
    }
}
