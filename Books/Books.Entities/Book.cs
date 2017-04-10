using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace Books.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public Genre Category { get; set; }
    }
}
