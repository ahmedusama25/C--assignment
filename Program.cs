using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter first number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            ////Console.Write("Enter second Number : ");
            //Console.Write("Enter a second number : ");
            ////string b = Console.ReadLine();
;           //
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a*b*c);
            //for (int i = 0; i < 4; i++)
            //{ for (int j=0; j < 4; j++)
            //    {
            //        Console.Write("{0}", a);
            //        if (i % 2 == 1)
            //        {
            //            Console.Write("{0} ", a);
            //        }
            //    }
            //    // Console.WriteLine(a + "*" + i + "=" + a*i);
            //    Console.Write("\n");
            //}
            //Console.ReadLine();

            //Console.WriteLine(b.Remove(b.IndexOf("a"),1));

            //replacee(b);
            //static void replacee(string b)
            //{
            //    string c = b.Substring(0, 1);
            //    string d = b.Substring(b.Length - 1, 1);
            //    Console.WriteLine(d + b.Substring(1, b.Length - 2) + c);
            //} 

            //if ((a<0 && c>0)||(a>0 && c < 0))
            //{
            //    Console.WriteLine("true");
            //}
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
