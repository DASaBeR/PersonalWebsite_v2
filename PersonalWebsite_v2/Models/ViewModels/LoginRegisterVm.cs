using PersonalWebsite_v2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite_2.Models.ViewModels
{
    public class LoginRegisterVm
    {
        public LoginVM? login { get; set; }
        public RegisterVM? register { get; set; }
    }
}
