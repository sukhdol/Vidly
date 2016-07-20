using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required.")]
        [StringLength(255, ErrorMessage = "The name cannot exceed 255 characters.")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        // Navigation Properties
        public MembershipType MembershipType { get; set; }
    }
}