using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session01_EFCore.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int NumOfPages { get; set; }
        public int YearOfPublish { get; set; }
        public bool IsInStock { get; set; }

    }
}
