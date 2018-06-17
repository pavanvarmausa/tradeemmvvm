using System;
//using GalaSoft.MvvmLight;
namespace Tradeem.Models
{
    public class SignInAndSignUpUserResponse
    {
        
        public string Action { get; set; }
        public string State { get; set; }
        public string UserId { get; set; }
        public String Error { get; set; }

    }
}