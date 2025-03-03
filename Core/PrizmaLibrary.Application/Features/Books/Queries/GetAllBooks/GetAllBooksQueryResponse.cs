using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Application.Features.Books.Queries.GetAllBooks
{
    public class GetAllBooksQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}
