using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Stuff
{
    class Question_1
    {
       
        public Question_1(List<string> list )
        {
            var newVar = list.Where(s => s.Contains("th"));
            foreach ( var str in newVar)
            {
                Console.WriteLine(str);
            }
        }
        
    }
}
