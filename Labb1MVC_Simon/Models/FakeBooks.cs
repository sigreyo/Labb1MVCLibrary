using Bogus;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Labb1MVC_Simon.Models
{
    public class FakeBooks
    {
        //API to populate booklist

        public static async Task<List<Book>> GetBooksFromApi()
        {
            var booklist = new List<Book>();

            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://www.googleapis.com/books/v1/volumes?q=programming&key=AIzaSyAOPSqIffpZusoT1Nl-pt947UStnJHVKzQ&maxResults=40")
            };

            var response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var strResponse = await response.Content.ReadAsStringAsync();
                var trimlist = JObject.Parse(strResponse)["items"].Children()["volumeInfo"].ToList();

                foreach (var item in trimlist)
                {
                    var tempbook = new Book();
                    var tempAuthorList = new List<string>();
                    var tempCategoryList = new List<string>();

                    foreach (var author in item["authors"])
                    {
                        tempAuthorList.Add(author.ToString());

                    }
                    try
                    {
                        foreach (var cat in item["categories"])
                        {
                            tempCategoryList.Add(cat.ToString());
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        tempCategoryList.Add("Undefined");
                    }




                    tempbook.Author = string.Join(", ", tempAuthorList);
                    tempbook.Category = string.Join(", ", tempCategoryList);
                    tempbook.PageCount = (int)item["pageCount"];
                    tempbook.Title = item["title"].ToString();
                    tempbook.Description = item["description"].ToString();
                    tempbook.Thumbnail = item["imageLinks"]["thumbnail"].ToString();
                    tempbook.ReleaseYear = item["publishedDate"].ToString();
                    booklist.Add(tempbook);
                }
            }
            return booklist;
        }


    }

}
