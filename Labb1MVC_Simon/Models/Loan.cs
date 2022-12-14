using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb1MVC_Simon.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        [DisplayName("Loaned at")]
        public DateTime BookLoanDate { get; set; } = DateTime.Now;

        [DisplayName("To be returned at")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? BookReturnDate { get; set; }

        [Required(ErrorMessage = "Value can not be empty.")]
        [DisplayName("Days to loan")]
        public int DaysToLoan { get; set; } = 30;

        [DisplayName("Returned in time?")]
        public bool? ReturnedInTime { get; set; }

        [ForeignKey("Loans")]
        [DisplayName("Loaned by")]
        public int CustomerId { get; set; }
        [ForeignKey("Loans")]
        public int BookId { get; set; }

        public Book? Book { get; set; }
        public Customer? Customer { get; set; }

    }
}
