using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_Web.Class
{
    public class User
    {
        string user_name;
        string password;
        string role;
        public User() { }
        public User(string user_name, string password, string role)
        {
            this.user_name = user_name;
            this.password = password;
            this.role = role;
        }
        public string UserName
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string Password
            { get { return password; } set { password = value; } }
        public string Role
            { get { return role; } set { role = value; } }
    }
}