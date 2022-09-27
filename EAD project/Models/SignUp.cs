using System;
using System.Collections.Generic;
using EAD_project.Models;

#nullable disable

namespace EAD_project
{
    public partial class SignUp : Baseclass_signup
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
