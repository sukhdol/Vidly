using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255, ErrorMessage = "The customer name cannot exceed 255 characters.")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        [Display(Name = "Membership Type")]
        [Required(ErrorMessage = "The membership type is required.")]
        public byte? MembershipTypeId { get; set; }

        // Data for membersghip types dropdown list
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public string Heading
        {
            get { return Id != 0 ? "Edit Customer" : "Add Customer"; }
        }

        public CustomerFormViewModel()
        {
            Id = 0;
        }

        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            Birthdate = customer.Birthdate;
            MembershipTypeId = customer.MembershipTypeId;
        }
    }
}