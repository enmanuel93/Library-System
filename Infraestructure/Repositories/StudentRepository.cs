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
    public class StudentRepository : BaseRepository<Student>, IStudent
    {

        public List<StudentViewModel> ShowStudents(List<Student> students)
        {
            var _students = new List<StudentViewModel>();

            foreach (var item in students)
            {
                _students.Add(new StudentViewModel()
                {
                    ID = item.StudentCode,
                    Name = item.Name,
                    LastName = item.LastName,
                    Address = item.Address,
                    Phone = item.Phone
                });
            }

            return _students;
        }
    }
}
