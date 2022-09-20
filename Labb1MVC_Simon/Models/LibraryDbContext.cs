using Bogus;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace Labb1MVC_Simon.Models
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loans { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) {}

        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var custId = 1;
            var customers = new Faker<Customer>()
                .RuleFor(x => x.CustomerId, f => custId++)
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Address, f => f.Address.StreetAddress())
                .RuleFor(x => x.Phone, f => f.Phone.PhoneNumberFormat())
                .RuleFor(x => x.LoanId, f => f.Random.Int(1, 30));

            var loanId = 1;
            var loans = new Faker<Loan>()
                .RuleFor(x => x.LoanId, f => loanId++)
                .RuleFor(x => x.CustomerId, f => f.Random.Int(1, 30))
                .RuleFor(x => x.BookId, f => f.Random.Int(1, 30));

            var bookId = 1;
            var index = bookId - 1;
            var fakeBooks = new Faker<Book>()
                .RuleFor(x => x.BookId, f => bookId++)
                .RuleFor(x => x.Amount, f => f.Random.Int(1, 5))
                .RuleFor(x => x.LoanId, f => f.Random.Int(1, 40));

            modelBuilder.Entity<Loan>().HasData(loans.Generate(40));
            modelBuilder.Entity<Customer>().HasData(customers.Generate(40));
            modelBuilder.Entity<Book>().HasData(fakeBooks.Generate(40));

        }
     

    }
}

