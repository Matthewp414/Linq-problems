using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Stuff
{
    class Program
    {           
        static void Main(string[] args)
        {   
            // Question 1
            List<string> collection ;
            Question_1 Test1;
         
            collection = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            Test1 = new Question_1(collection);
            Console.ReadLine();
            // Question 1 End

            //Q2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            Question_2 Test2 = new Question_2(names);
            Console.ReadLine();
            //Q2 END


            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55"};
            Console.ReadLine();
            Question_3 question_3 = new Question_3(classGrades);
        }
}
    }
