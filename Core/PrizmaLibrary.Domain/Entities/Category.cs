﻿using PrizmaLibrary.Domain.Common;
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

        public required int ParentId { get; set; }
        public required string Name { get; set; }
        public required int Priorty { get; set; }
        public required bool IsDeleted { get; set; } = false;

        public ICollection<Detail> Details { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
