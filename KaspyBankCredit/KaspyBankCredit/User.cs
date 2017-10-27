using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspyBankCredit
{
    public class User
    {
        public long Id { get; set; }
        public Person Person { get; set; }
        public string PIN{get;set;}
        public string Password { get; set; }
    }
}
