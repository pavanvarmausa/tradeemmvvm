using System;
//using GalaSoft.MvvmLight;

namespace Tradeem.Models
{
    public class SignInUserRequest
    {
        public String EmailOrUserName { get; set; }
        public String Password { get; set; }
        public String Action { get; set; }
        public String Error { get; set; }

        //public User()
        //{
        //}

        //public User(string Username, string Password)
        //{
        //    this.Username = Username;
        //    this.Password = Password;
        //}

        //private string username;
        //public string Username
            //{
            //    get { return username; }
            //    set
            //    {
            //        if (value != username)
            //        {
            //            username = value;
            //            RaisePropertyChanged("Username");
            //        }
            //    }
            //}

            //private string password;
            //public string Password
            //{
            //    get { return password; }
            //    set
            //    {
            //        if (value != password)
            //        {
            //            password = value;
            //            RaisePropertyChanged("Password");
            //        }
            //    }
            //} 
    }
}
