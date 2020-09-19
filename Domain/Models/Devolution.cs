using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{

    public class Devolution : Base
    {
        public string DevolutionCode { get; set; }
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
    }
}
