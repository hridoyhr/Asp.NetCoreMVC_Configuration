using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration1._0.Models
{
    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
    }
}
