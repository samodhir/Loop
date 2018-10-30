using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class loop
    {
        static void Main()
        {
            //while
            Console.WriteLine("Please Enter a number");
            int num = int.Parse(Console.ReadLine());
            int i = 0;

            while (i<num)
            {
                Console.WriteLine("While Loop {0}",i);
                i++;
            }
            //Do while 
            Console.WriteLine("Please Enter a number");
            int num1 = int.Parse(Console.ReadLine());
            int j = 0;

            do
            {
                Console.WriteLine("Do While Loop {0}", j);
                j++;
            }
            while (j < num1);
            //for loop
            Console.WriteLine("Please Enter a number");
            int num2 = int.Parse(Console.ReadLine());
            for (int a=0; a<num2; a++)
            {
                Console.WriteLine("For Loop {0}", a);
            
            }
            //foreach
            string[] arr = new string[4];
            arr[0] = "sam";
            arr[1] = "jun";
            arr[2] = "saa";
            arr[3] = "sun";

            foreach(String name in arr)
            {
                Console.WriteLine("\n Hello " + name);
            }
            Console.ReadKey();
        }
    }
}
