using System;
using Xamarin.Forms;
using Tradeem.Views;
using Xamarin.Forms.Xaml;
using GalaSoft.MvvmLight.Ioc;
using Tradeem.Services;
using Tradeem.Enums;
using Tradeem.ViewModels;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Tradeem
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();

            INavigationService navigationService;

            if (!SimpleIoc.Default.IsRegistered<INavigationService>())
            {
                // Setup navigation service:
                navigationService = new NavigationService();

                // Configure pages:
                navigationService.Configure(AppPages.AboutPage, typeof(AboutPage));
                navigationService.Configure(AppPages.LoginPage, typeof(LoginPage));
                navigationService.Configure(AppPages.HomePage, typeof(HomePage));
                navigationService.Configure(AppPages.SignUpPage, typeof(SignUpPage));

                // Register NavigationService in IoC container:
                SimpleIoc.Default.Register<INavigationService>(() => navigationService);
            }

            else
                navigationService = SimpleIoc.Default.GetInstance<INavigationService>();

            // Create new Navigation Page and set LoginPage as its default page:
            var firstPage = new NavigationPage(new AboutPage());
            // Set Navigation page as default page for Navigation Service:
            navigationService.Initialize(firstPage);
            // You have to also set MainPage property for the app:
            MainPage = firstPage;
        }

        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator => _locator ?? (_locator = new ViewModelLocator());

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
