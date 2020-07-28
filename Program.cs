using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number=0;
            int count = 0;
            int c = 1;
            for (var i = 2; c <= 500; i++)
            {
                for (var j = 2; j <= i;j++){
                if (i % j == 0)
                    {
                        count++;
                    }
                }
            if (count == 1)
                {
                    number += i;
                    c++;
                }
                Console.WriteLine(number);
                count = 0;
            }
            Console.WriteLine(number);        
        }

    }
}
