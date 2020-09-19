
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Users : Base
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Rol { get; set; }        
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
