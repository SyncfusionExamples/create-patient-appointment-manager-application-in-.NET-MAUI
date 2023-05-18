using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppointments
{
    public class ProfileViewModel
    {
        public ProfileDetails ProfileDetails { get; set; }

        public LoginFormModel LoginFormModel { get; set; }

        public ProfileViewModel() { 
        
            this.ProfileDetails = new ProfileDetails(); 
            this.LoginFormModel = new LoginFormModel();
        }
    }
}
