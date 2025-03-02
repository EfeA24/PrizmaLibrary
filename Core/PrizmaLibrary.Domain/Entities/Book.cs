using PrizmaLibrary.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Domain.Entities
{
    public class Book : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
