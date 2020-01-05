using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Stuff
{
    class Question_2
    {
        
        public Question_2(List<string> list)
        {
            
            var newVar = list.Distinct();
            foreach (var str in newVar)
            {
                Console.WriteLine(str);
            }
        }
    }
}
