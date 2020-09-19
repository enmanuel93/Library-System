using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IEditorial : IRepositorio<Editorial>
    {
        List<EditorialViewModel> ShowEditorials(List<Editorial> editorials);
    }
}
