﻿using System;
using System.Windows.Input;
using RestSharp;
using Tradeem.Models;
using Tradeem.Services;
using Xamarin.Forms;

/* removed these usings
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
 */

namespace Tradeem.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        public ICommand LoginResultCommand { get; private set; }
        private int LoginResult = 1;

        private String _userName;
        public String UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }
        private String _password;
        public String Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }


/*        private User _model;
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
*/


        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

                LoginResultCommand = new Command(() => {
                    validateCredentials();
                });
        }

        private async void validateCredentials()
        {
            // Console.WriteLine("findUser->" + UserName);
            // Console.WriteLine("findPassword" + Password);

            SignInUserRequest loginUserRequest = new SignInUserRequest();
            // Right now hard-coding to the values Brian mentioned, but later change the code to
            // loginuserrequest.EmailOrUserName = UserName;
            // loginuserrequest.Password = Password;

            loginUserRequest.EmailOrUserName = "professorx";
            loginUserRequest.Password = "G32Jdd";

            loginUserRequest.Action = "LoginUser";
            loginUserRequest.Error = "";

            RestClient client = new RestClient("https://tradeemWSapi.azurewebsites.net/api/login");
            RestRequest request = new RestRequest();
            request.AddJsonBody(loginUserRequest);
            request.Method = Method.POST;

            //request.AddHeader("Accept", "application/json");
            // string body = @"{
            //             ""userid"": 1
            //           }";
            //
            //request.AddParameter("application/json", body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            string json = response.Content; //json has our response

            RestSharp.Deserializers.JsonDeserializer deserial = new RestSharp.Deserializers.JsonDeserializer();
            SignInAndSignUpUserResponse signInAndSignUpResponse = deserial.Deserialize<SignInAndSignUpUserResponse>(response);

            if(signInAndSignUpResponse.State.Equals("success"))
                _navigationService.NavigateTo(Enums.AppPages.LoginSuccessPage);
            else
                _navigationService.NavigateTo(Enums.AppPages.LoginPage);
        }
    }
}
