using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session01_EFCore.Models
{
    internal class Category
    {
        public int CategoryId { get; set; } //primarykey

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
