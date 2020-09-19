using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
   public class LoanReportViewModel
   {
        public string ID { get; set; }
        public string Student { get; set; }
        public string Book { get; set; }
        public DateTimeOffset Date { get; set; }
        public string CreationDate
        {
            get { return Date.ToString("MM/dd/yyyy H:mm"); }
        }
    }
}
