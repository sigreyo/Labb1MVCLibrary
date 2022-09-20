using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb1MVC_Simon.Models
{
    public class Book
    {
        [Key]        
        public int BookId { get; set; }

        [DisplayName("Title")]
        public string? Title { get; set; }

        [DisplayName("Authors")]
        public string? Author { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        [DisplayName("Release year")]
        public string? ReleaseYear { get; set; }

        [DisplayName("Books left")]
        public int Amount { get; set; }

        public string? Thumbnail { get; set; }
        public int? PageCount { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public int LoanId { get; set; }
        public ICollection<Loan> Loans { get; set; }



    }
}