using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb1MVC_Simon.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(12)")]
        [MaxLength(12, ErrorMessage = "Max 12 characters.")]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20, ErrorMessage = "Max 20 characters.")]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        [MaxLength(30, ErrorMessage = "Max 30 characters.")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(12)")]
        [MaxLength(12, ErrorMessage = "Max 12 characters.")]
        [DisplayName("Phone number")]
        public string Phone { get; set; }

        public int LoanId { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
