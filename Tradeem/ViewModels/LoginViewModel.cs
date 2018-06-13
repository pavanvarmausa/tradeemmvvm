using System;
using System.Windows.Input;
using Tradeem.Models;
using Tradeem.Services;
using Xamarin.Forms;

namespace Tradeem.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        public ICommand LoginResultCommand { get; private set; }
        private int LoginResult = 1;

       //private String userName;
        //private String password;

        //private string _userName;
        //public string Entry_Username
        //{
        //    get { return _userName; }
        //    set { Set(ref _userName, value); }
        //}


        private User _model;
        public User Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
                RaisePropertyChanged(() => Model);
            }
        }


        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            //Console.WriteLine("findUserName-> " + _userName);

            // Logic to check if Login Credentials are Valid and Login is successful.. 
            //---------------------------------------------------------------------------------
            // If successful 
            //    set variable LoginResult to 1, to navigate the user to his HomePage
            // else 
            //    set variable LoginResult to 0, to navigate the user back to LoginPage again
            //--------------------------------------------------------------------------------- 

            if (LoginResult==1) 
                /*            {
                LoginResultCommand = new Command(() => {
                    //Console.Write("findUser->" + Model.Username);
                    //Console.WriteLine("findPassword" + Model.Password);
                    _navigationService.NavigateTo(Enums.AppPages.HomePage);

                });
            }
                LoginResultCommand = new Command(() => {
                Console.Write("findUser->" + User.Username);
                    Console.WriteLine("findPassword" + User.Password);
                    _navigationService.NavigateTo(Enums.AppPages.HomePage);
                    
            });
            */
                LoginResultCommand = new Command(() => _navigationService.NavigateTo(Enums.AppPages.LoginSuccessPage));
            else
                LoginResultCommand = new Command(() => _navigationService.NavigateTo(Enums.AppPages.LoginPage));
        }
    }
}
