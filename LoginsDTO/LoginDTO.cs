using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class LoginDTO
    {
        public string LoginID { get; set; }
        public string Account { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PlainTextPassword { get; set; }
        public string Website { get; set; }
        public string PricePerMonth { get; set; }
        public DateTime? RenewalDate { get; set; }
    }
}
