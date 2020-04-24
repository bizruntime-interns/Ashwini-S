using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT
{
    class Program
    {
        static void Main(string[] args)
        {
            ashEntities context = new ashEntities();
            var student = new student()
            {
                personid = 6,
                firstname = "nick",
                lastname = "adi",
                age = 24
            };
            context.students.Add(student);
            context.SaveChanges();
        }
    }
}
