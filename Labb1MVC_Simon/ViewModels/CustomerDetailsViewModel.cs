using Labb1MVC_Simon.Models;

namespace Labb1MVC_Simon.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public IEnumerable<Loan> LoansWithBooks { get; set; }
        public Customer Customer { get; set; }
    }
}
