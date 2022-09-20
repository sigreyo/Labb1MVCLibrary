
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Labb1MVC_Simon.Models;
using Labb1MVC_Simon.ViewModels;
using Newtonsoft.Json;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.ComponentModel;

namespace Labb1MVC_Simon.Controllers
{
    public class LibraryController : Controller
    {
        private LibraryDbContext _context;
        private static bool IsUpdated = false;

        public LibraryController(LibraryDbContext context)
        {
            _context = context;
        }

        //GET all from loans for loan list

        public async Task<IActionResult> Index() => View
            (await _context.Loans.Include(l => l.Book)
            .Include(l => l.Customer)
            .ToListAsync());

        //GET all books
        public async Task<IActionResult> BookList()
        {
            //var list = FakeBooks.Populate();
            //foreach (var item in _context.Books)
            //{
            //    list.Add(item);
            //}
            var list = await FakeBooks.GetBooksFromApi();
            if (!IsUpdated)
            {
                await Populate(list);
                IsUpdated = true;
            }
            return View(new BookListViewModel() { Books = list});
        }

        //populate DB with books from API
        public async Task Populate(List<Book> list)
        {
            for (int i = 1; i < _context.Books.Count(); i++)
            {
                var book = await _context.Books.FirstOrDefaultAsync(x => x.BookId == i);
                book.Title = list[i].Title;
                book.Author = list[i].Author;
                book.Thumbnail = list[i].Thumbnail;
                book.PageCount = list[i].PageCount;
                book.ReleaseYear = list[i].ReleaseYear;
                book.Description = list[i].Description;
                book.Category = list[i].Category;
                Console.WriteLine("updated");
            }
            await _context.SaveChangesAsync();
        }



        //GET all customers
        public async Task<IActionResult> CustomerList() => View
            (await _context.Loans.Include(l => l.Book)
            .Include(l => l.Customer)
            .ToListAsync());


        // GET: Loans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Loans == null)
            {
                return NotFound();
            }

            var loan = await _context.Loans
                .FirstOrDefaultAsync(m => m.LoanId == id);
            if (loan == null)
            {
                return NotFound();
            }

            return View(loan);
        }

        // GET: Loans/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Loans/Create
        public IActionResult CreateCustomer()
        {
            return View();
        }

        // POST: Loans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoanId,BookLoanDate,BookReturnDate,DaysToLoan,ReturnedInTime,CustomerId,BookId")] Loan loan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loan);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomer([Bind("CustomerId,FirstName,LastName,Address,Phone,LoanId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CustomerList));
            }
            return View(customer);
        }

        // GET: Loans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Loans == null)
            {
                return NotFound();
            }

            var loan = await _context.Loans.FindAsync(id);
            if (loan == null)
            {
                return NotFound();
            }
            return View(loan);
        }

        // POST: Loans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoanId,BookLoanDate,BookReturnDate,DaysToLoan,ReturnedInTime,CustomerId,BookId")] Loan loan)
        {
            if (id != loan.LoanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanExists(loan.LoanId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(loan);
        }

        // GET: Loans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Loans == null)
            {
                return NotFound();
            }

            var loan = await _context.Loans
                .FirstOrDefaultAsync(m => m.LoanId == id);
            if (loan == null)
            {
                return NotFound();
            }

            return View(loan);
        }

        // POST: Loans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Loans == null)
            {
                return Problem("Entity set 'LibraryDbContext.Loans'  is null.");
            }
            var loan = await _context.Loans.FindAsync(id);
            if (loan != null)
            {
                _context.Loans.Remove(loan);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanExists(int id)
        {
            return (_context.Loans?.Any(e => e.LoanId == id)).GetValueOrDefault();
        }
    }
}
