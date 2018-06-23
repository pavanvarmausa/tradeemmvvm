using System;
//using System.Collections.Generic;
using Tradeem.ViewModels;
using Tradeem.Models;

using Xamarin.Forms;

namespace Tradeem.Views
{
    public partial class NotificationsPage : ContentPage
    {
        NotificationViewModel viewModel;
        public NotificationsPage()
        {
            viewModel = new NotificationViewModel();
            BindingContext = viewModel;
            InitializeComponent();

        }
        public void OnItemTapped(Object o, ItemTappedEventArgs eventArgs)
        {
            var notification = eventArgs.Item as Notification;
            if(notification != null){
                DisplayAlert("Notification", String.Format("You selected {0}", notification.userName), "Ok");
            }
        }
    }
}
