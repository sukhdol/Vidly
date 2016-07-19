using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Your name is required.")]
        [StringLength(255, ErrorMessage = "Your name cannot exceed 255 characters")]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public byte MembershipTypeId { get; set; }

        // Navigation Properties
        public MembershipType MembershipType { get; set; }
    }
}