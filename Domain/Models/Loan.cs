using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{

    public class Loan : Base
    {
        public Loan()
        {
            this.Devolutions = new HashSet<Devolution>();
        }

        public string LoanCode { get; set; }

        public int StudentId { get; set; }

        public int BookId { get; set; }
        public Student Student { get; set; }
        public Book Book { get; set; }

        public ICollection<Devolution> Devolutions { get; set; }
    }
}
