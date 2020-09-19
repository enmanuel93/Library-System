using Domain.Context;
using Domain.Interfaces;
using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class EditorialRepository : BaseRepository<Editorial>, IEditorial
    {

        public List<EditorialViewModel> ShowEditorials(List<Editorial> editorials)
        {
            var newEditorials = new List<EditorialViewModel>();

            foreach (var item in editorials)
            {
                newEditorials.Add(new EditorialViewModel()
                {
                    ID = item.EditorialId,
                    Name = item.Name,
                    Address = item.Address
                });
            }

            return newEditorials;
        }
    }
}
