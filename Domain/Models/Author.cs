using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Author : Base
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        public string AuthorCode { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
