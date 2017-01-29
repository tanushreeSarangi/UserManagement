using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserManagement
{
    public class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TempPwd { get; set; }
        public string Password { get; set; }
        public string Property { get; set; }
        public string Group { get; set; }
        public string Timezone { get; set; }
    }
}