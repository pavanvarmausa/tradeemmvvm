using System;
using Tradeem.Enums;
using Xamarin.Forms;

namespace Tradeem.Services
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
