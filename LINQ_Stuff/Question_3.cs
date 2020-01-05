using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Stuff
{
    class Question_3
    {
        public Question_3(List<string> list)
        {
            double newVar = list.Select(s => s.Split(',').Select(n => Convert.ToInt32(n)).OrderByDescending(n=>n).Take(list.Count()).Average()).Average() ;
            Console.WriteLine(newVar);
        }
    }
}
