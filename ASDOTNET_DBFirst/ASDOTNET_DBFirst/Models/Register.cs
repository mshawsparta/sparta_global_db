using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ASDOTNET_DBFirst.Models
{
    public class Register
    {
        private int userID;
        private string username;
        private string password;
        private string passwordCheck;

        [Required]
        [Key]
        public int UserID { get => userID; set => userID = value; }
        [Required]
        public string Username { get => username; set => username = value; }
        [Required]
        public string Password { get => password; set => password = value; }
        [Required]
        public string PasswordCheck { get => passwordCheck; set => passwordCheck = value; }
    }
}