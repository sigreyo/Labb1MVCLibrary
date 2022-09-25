using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Labb1MVC_Simon.Models;
using Labb1MVC_Simon.ViewModels;
using Bogus;

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



        //Start page
        public async Task<IActionResult> Start()
        {
            var list = await FakeBooks.GetBooksFromApi();
            if (!IsUpdated)
            {
                await Populate(list);
                IsUpdated = true;
            }
            return View();
        }


        //GET all from loans for loan list

        public async Task<IActionResult> LoanList() => View
            (await _context.Loans.Include(l => l.Book)
            .Include(l => l.Customer)
            .ToListAsync());

        // GET: Library/CustomerDetails/5
        public async Task<IActionResult> CustomerDetails(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var cust = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (cust == null)
            {
                return NotFound();
            }

            return View(new CustomerDetailsViewModel { LoansWithBooks = _context.Loans.Include(x => x.Book).ToList(), Customer = cust });
        }

        //GET: Library/BookDetails/4
        public async Task<IActionResult> BookDetails(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var cust = await _context.Books
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (cust == null)
            {
                return NotFound();
            }

            return View(cust);
        }

        //GET all books
        public async Task<IActionResult> BookList() => View(new BookListViewModel() { Books = _context.Books });

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
        public async Task<IActionResult> CustomerList() =>
            View(await _context.Customers.Include(l => l.Loans).ToListAsync());



        // GET: Library/Create
        public IActionResult CreateLoan()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Title");
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FullName");
            return View();
        }

        //POST: create a loan
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLoan([Bind("LoanId,BookLoanDate,BookReturnDate,DaysToLoan,ReturnedInTime,CustomerId,BookId")] Loan loan)
        {
            if (ModelState.IsValid)
            {
                loan.BookLoanDate = DateTime.Now;
                loan.BookReturnDate = DateTime.Now.AddDays(loan.DaysToLoan);
                _context.Add(loan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Start));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId", loan.BookId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Address", loan.CustomerId);
            return View(loan);
        }

        // GET: Library/Create
        public IActionResult CreateCustomer()
        {
            return View();
        }

        // POST: create a customer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomer([Bind("CustomerId,FullName,Address,Phone")] Customer cust)
        {
            if (ModelState.IsValid)
            {
                var ava = new Bogus.DataSets.Internet();
                cust.Avatar = ava.Avatar();

                _context.Add(cust);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Start));
            }

            return View(cust);
        }

        //GET: Library/DeleteLoan/5
        public async Task<IActionResult> DeleteLoan(int? id)
        {
            if (id == null || _context.Loans == null)
            {
                return NotFound();
            }

            var loan = await _context.Loans
                .Include(b => b.Book)
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.LoanId == id);
            if (loan == null)
            {
                return NotFound();
            }

            return PartialView("components//_modalDeleteLoan", loan);
            //return View(loan);
        }

        // POST: Library/DeleteLoan/5
        [HttpPost, ActionName("DeleteLoanConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteLoan(int id)
        {

            var loan = await _context.Loans.FirstOrDefaultAsync(m => m.LoanId == id);
            if (loan != null)
            {
                _context.Loans.Remove(loan);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Start));
        }

        // GET: Library/DeleteCustomer/5
        public async Task<IActionResult> DeleteCustomer(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var cust = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (cust == null)
            {
                return NotFound();
            }

            return PartialView("components//_modalDeleteCustomer", cust);
        }

        // POST: Library/Delete/5
        [HttpPost, ActionName("DeleteCustomerConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCustomer(int id)
        {

            var cust = await _context.Customers.FindAsync(id);
            if (cust != null)
            {
                _context.Customers.Remove(cust);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(CustomerList));
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> EditCustomer(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var cust = await _context.Customers.FindAsync(id);
            if (cust == null)
            {
                return NotFound();
            }
            return PartialView("components//_modalEditCustomer", cust);

        }

        // POST: Transactions/Edit/5        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCustomerConfirmed(Customer cust)
        {         

            if (ModelState.IsValid)
            {

                _context.Update(cust);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(CustomerList));
            }

            return View(nameof(CustomerList));
        }




        private bool LoanExists(int id)
        {
            return _context.Loans.Any(e => e.LoanId == id);
        }
    }
}
