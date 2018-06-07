﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tradeem.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.About;
        }
    }
}