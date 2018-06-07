﻿using System;
using System.Windows.Input;
using Tradeem.Services;
using Xamarin.Forms;

namespace Tradeem.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        public ICommand OpenWebCommand { get; private set; }

        public AboutViewModel(INavigationService navigationService)
        {
            //Title = "About";
            _navigationService = navigationService;
            OpenWebCommand = new Command(() => _navigationService.NavigateTo(Enums.AppPages.LoginPage));
        }

        //public ICommand OpenWebCommand { get; }
    }
}