/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Give2"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using Give2.Services;

namespace Give2.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}
            //SearchNearbyServices myEmailService = SearchNearbyServices.CreateAsync();

            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<SignUpViewModel>();
            SimpleIoc.Default.Register<SearchNearbyServices>();
            //SimpleIoc.Default.Register(() => SearchNearbyServices.CreateAsync());
        }

        //public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        public HomeViewModel Home => ServiceLocator.Current.GetInstance<HomeViewModel>();

        public LoginViewModel Login => ServiceLocator.Current.GetInstance<LoginViewModel>();

        public SignUpViewModel SignUp => ServiceLocator.Current.GetInstance<SignUpViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}