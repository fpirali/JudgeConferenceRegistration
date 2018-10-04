using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JudgeConferenceRegistration.Models
{
    [Table("HotelRegistration")]
    public class HotelRegistrationModels
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You must select a date.")]
        [Display(Name = "Arrival Date")]
        public string ArrivalDate { get; set; }

        [Required(ErrorMessage = "You must select a date.")]
        [Display(Name = "Departure Date")]
        public string DepartureDate { get; set; }
     
        [Display(Name = "Special Needs/Requests")]
        public string SpecialNeeds { get; set; }
    }
}