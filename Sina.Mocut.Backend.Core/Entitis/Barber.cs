using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sina.Mocut.Backend.Core.Entitis
{
    public class Barber
    {
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }

        public Barber(string? phoneNumber, string? fullName)
        {
            PhoneNumber = phoneNumber;
            FullName = fullName;
        }
    }
}
