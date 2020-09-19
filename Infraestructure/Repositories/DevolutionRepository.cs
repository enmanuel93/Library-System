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
    public class DevolutionRepository : BaseRepository<Devolution>, IDevolution
    {


        public List<DevolutionViewModel> ShowDelvolutions(List<Devolution> devolutions)
        {
            var _devolutions = new List<DevolutionViewModel>();

            foreach (var item in devolutions)
            {
                _devolutions.Add(new DevolutionViewModel()
                {
                    ID = item.DevolutionCode,
                    Code = item.LoanId.ToString(),
                });
            }

            return _devolutions;
        }
    }
}
