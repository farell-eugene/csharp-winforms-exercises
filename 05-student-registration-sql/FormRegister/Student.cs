using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormRegister
{
    internal class Students
    {
        public int nim { get; set; }
        
        public string username { get; set; }
        
        public string email { get; set; }

        
        public Students(int nim, string username, string email)
        {
            this.nim = nim;
            this.username = username;
            this.email = email;
        }
    }
}