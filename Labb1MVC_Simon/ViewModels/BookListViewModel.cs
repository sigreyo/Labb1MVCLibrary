using Labb1MVC_Simon.Models;
using Newtonsoft.Json;

namespace Labb1MVC_Simon.ViewModels
{
    public class BookListViewModel
    {        
        public IEnumerable<Book> Books { get; set; }        
    }
}
