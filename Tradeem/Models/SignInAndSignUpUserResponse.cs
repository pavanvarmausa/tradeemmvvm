using System;
//using GalaSoft.MvvmLight;
namespace Tradeem.Models
{
    public class SignInAndSignUpUserResponse
    {
        
        public String Action { get; set; }
        public String State { get; set; }
        public String UserId { get; set; }
        public String Error { get; set; }

    }
}