using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class BookReportViewModel
    {
        public string ID { get; set; }
        public string Author { get; set; }
        public string Editorial { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Date { get; set; }
        public string CreationDate
        {
            get { return Date.ToString("MM/dd/yyyy H:mm"); }
        }
    }
}
