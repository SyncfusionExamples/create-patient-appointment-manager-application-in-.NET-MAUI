using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppointments
{
    public class ProfileDetails
    {
        public ProfileDetails()
        {
            this.Name = "Dr.Fiona Gina";
            this.DOB = new DateTime(1992, 1, 1);
            this.Gender = "Female";
            this.BloodGroup = "O+";
            this.Email = "Fionagina@gmail.com";
            this.Phone = "55555555";
            this.Address = "507 - 20th Ave E Apt. 2A, \nSeattle";
            this.City = "Washington";
            this.State = "Seattle";
            this.PostalCode = "98122";
            this.Country = "United States";
            this.EmergencyContactName = "Peter";
            this.EmergencyContactNumber = "88888888"; 
        }

        [DataFormDisplayOptions(ShowLabel =false)]
        public string? Image { get; set; }
        public string Name { get; set; }    
        public DateTime DOB { get; set; }
        public string Gender { get; set; }

        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }  
        public string Email { get; set; }   
        public string Phone { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; } 
        public string City { get; set; }    
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        [Display(Name = "Emergency Contact Name")]
        public string EmergencyContactName   { get; set; }

        [Display(Name = "Emergency Contact Number")]
        public string EmergencyContactNumber { get; set; }
    }
}
