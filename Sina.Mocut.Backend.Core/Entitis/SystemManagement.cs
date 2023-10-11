using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sina.Mocut.Backend.Core.Entitis
{
    public class SystemManagement
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public SystemManagement(string password, string username)
        {
            Password = password;
            Username = username;
        }
    }
}
