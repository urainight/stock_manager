using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace stock_manager
{
    internal class User
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool is_admin { get; set; } = false;
        public DateTime date_joined { get; set; } = DateTime.Now;

        public User(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = Backend_user.HashPassword(password);
        }
    }
}
