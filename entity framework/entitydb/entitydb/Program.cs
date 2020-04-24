using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitydb
{
    class Program
    {
        static void Main(string[] args)
        {
            ashEntities context = new ashEntities();
            var child = new child()
            {
                id = 6,
                firstname = "nick",
                lastname = "adi",
                age = 24
            };
            context.children.Add(child);
            context.SaveChanges();
        }
    }
}
