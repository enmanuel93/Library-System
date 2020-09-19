using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Student : Base
    {
        public Student()
        {
            this.Loans = new HashSet<Loan>();
        }

        public string StudentCode { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICollection<Loan> Loans { get; set; }
    }
}
