using PrizmaLibrary.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category() { }
        public Category(int parentId, string name, int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }

        public int ParentId { get; set; }
        public string Name { get; set; }
        public int Priorty { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<Detail> Details { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
