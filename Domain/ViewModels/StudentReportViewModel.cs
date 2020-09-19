using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class StudentReportViewModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTimeOffset Date { get; set; }
        public string CreationDate
        {
            get { return Date.ToString("MM/dd/yyyy H:mm"); }
        }
    }
}
