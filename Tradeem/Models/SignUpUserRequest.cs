using System;
namespace Tradeem.Models
{
    public class SignUpUserRequest
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Interests { get; set; }

        public string Action { get; set; }
        public String Error { get; set; }

/*        public SignUpUserRequest()
        {
        }
*/        
    }
}
