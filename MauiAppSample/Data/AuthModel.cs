using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppSample.Data
{
    public class LoginResult
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string[] roles { get; set; }
        public string tokenType { get; set; }
        public string accessToken { get; set; }


    }

    public class LoginError
    {
		//only if error
		public string path { get; set; }
		public string error { get; set; }
		public string message { get; set; }
		public string status { get; set; }
	}
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required.")]
        //[EmailAddress(ErrorMessage = "Email is not valid.")]
        public string username { get; set; } // NOTE: email will be the username, too

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
    public class RegModel : LoginModel
    {
        [Required(ErrorMessage = "Confirm password is required.")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password and confirm password do not match.")]
        public string confirmpwd { get; set; }
    }
}
