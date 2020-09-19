using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{

    public class Book : Base
    {
        public Book()
        {
            this.Loans = new HashSet<Loan>();
        }

        public string BookCode { get; set; }
        public int AuthorId { get; set; }

        public int EditorialId { get; set; }
        public string Name { get; set; }

        public Editorial Editorial { get; set; }

        public Author Author { get; set; }

        public ICollection<Loan> Loans { get; set; }
    }
}
