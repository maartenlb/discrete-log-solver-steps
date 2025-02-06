using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime;
using System.ComponentModel.Design.Serialization;

namespace Security_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading input
            BigInteger modulus;
            BigInteger grondtal;
            double orde;
            BigInteger.TryParse(Console.ReadLine().Split()[0], out modulus);
            BigInteger.TryParse(Console.ReadLine().Split()[0], out grondtal);
            double.TryParse(Console.ReadLine().Split()[0], out orde);

            uint k;
            uint.TryParse(Console.ReadLine().Split()[0], out k);

            double rootq;
            double a;
            double b;

            rootq = Math.Ceiling(Math.Sqrt(orde));

            if (k <= 100)
            {
                a = rootq;
                b = rootq;
            }

            else
            {
                a = Math.Ceiling(rootq / Math.Sqrt(k));
                b = rootq * Math.Ceiling(Math.Sqrt(k));
            }

            BigInteger giantbase = 1;

            for (uint i = 1; i <= a; i++)
            {
                giantbase = (giantbase * grondtal) % modulus;
            }

            Dictionary<BigInteger, uint> GiantSteps = new Dictionary<BigInteger, uint>();
            BigInteger giantpower = 1;
            for (uint n = 1; n <= b; n++)
            {
                giantpower = (giantpower * giantbase) % modulus;
                GiantSteps.Add(giantpower, n);
            }

            BigInteger x;
            BigInteger babystep;
            bool answer;
            uint j;

            for (uint n = 0; n < k; n++)
            {
                BigInteger.TryParse(Console.ReadLine().Split()[0], out x);
                answer = false;
                babystep = x;
                if (GiantSteps.ContainsKey(babystep))
                {
                    answer = true;
                    GiantSteps.TryGetValue(babystep, out j);
                    Console.WriteLine(a * j);
                }

                for (uint i = 1; i < a; i++)
                {
                    babystep = (babystep * grondtal) % modulus;
                    if (GiantSteps.ContainsKey(babystep))
                    {
                        answer = true;
                        GiantSteps.TryGetValue(babystep, out j);
                        Console.WriteLine((a * j) - i);
                    }
                }
                if (answer == false)
                {
                    Console.WriteLine("geen macht");
                }
            }

            Console.ReadKey();
        }
    }
}
