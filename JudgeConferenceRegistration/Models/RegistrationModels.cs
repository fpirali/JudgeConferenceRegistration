using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JudgeConferenceRegistration.Models
{
    [Table("Registration")]
    public class RegistrationModels
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Your phone number is required.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Your must select a court.")]
        [Display(Name = "Court")]
        public string Court { get; set; }

        [Required(ErrorMessage = "Your must select a conference.")]
        [Display(Name = "Conference")]
        public string Conference { get; set; }

        [Required(ErrorMessage = "Your must select an option.")]
        [Display(Name = "Will You Attend Judicial Awards Dinner")]
        public string AwardsDinner { get; set; }

        [Required(ErrorMessage = "Your must select an option.")]
        [Display(Name = "Will You need a hotel room")]
        public string HotelRoom { get; set; }
    }
}