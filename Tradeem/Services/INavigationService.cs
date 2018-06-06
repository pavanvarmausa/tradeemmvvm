using System;
using Give2.Enums;
using Xamarin.Forms;

namespace Give2.Services
{
    public interface INavigationService
    {
        void GoBack();
        void NavigateTo(AppPages pageKey);
        void NavigateTo(AppPages pageKey, object parameter);
        // Register pages and add them to the dictionary:
        void Configure(AppPages pageKey, Type pageType);
        // Initialize first app page (navigation page):
        void Initialize(NavigationPage navigation);
    }
}
