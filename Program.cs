using System;

namespace Automat_vanzari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti banii: ");
            int bani, n = 5, d = 10, q = 25;
            bani = int.Parse(Console.ReadLine());
            if (bani == n)
            {
                Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                bani = int.Parse(Console.ReadLine());
                if (bani == d)
                {
                    Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                    bani = int.Parse(Console.ReadLine());
                    if (bani == q)
                    {
                        Console.WriteLine("Va rugam sa ridicati produsul si restul (15 centi). Vi-au mai ramas 5 centi.");
                        Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                        bani = int.Parse(Console.ReadLine());
                        if (bani == q)
                        {
                            Console.WriteLine("Va rugam sa ridicati produsul si restul (10 centi). Va multumim!");
                        }
                        else if (bani == d)
                        {
                            Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                            bani = int.Parse(Console.ReadLine());
                            if (bani == q)
                            {
                                Console.WriteLine("Va rugam sa ridicati produsul si restul (15 centi). Vi-au mai ramas 5 centi.");
                                Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                                bani = int.Parse(Console.ReadLine());
                                if (bani == q)
                                {
                                    Console.WriteLine("Va rugam sa ridicati produsul si restul (10 centi). Va multumim!");
                                }
                            }
                        }
                        else if (bani == d)
                            Console.WriteLine("Va rugam sa ridicati produsul si restul (5 centi). Va multumim!");
                    }
                    else if (bani == q)
                    {
                        Console.WriteLine("Va rugam sa ridicati produsul si restul (10 centi).Va multumim!");
                    }
                }
                else if (bani == d)
                {
                    Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                    bani = int.Parse(Console.ReadLine());
                    if (bani == d)
                        Console.WriteLine("Va rugam sa ridicati produsul.Va multumim!");
                    else if (bani == n)
                    {
                        Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                        bani = int.Parse(Console.ReadLine());
                        if (bani == n)
                            Console.WriteLine("Va rugam sa ridicati produsul.Va multumim!");
                    }
                    else if (bani == q)
                    {
                        Console.WriteLine("Va rugam sa ridicati produsul si restul (15 centi). Vi-au mai ramas 5 centi.");
                        Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                        bani = int.Parse(Console.ReadLine());
                        if (bani == q)
                        {
                            Console.WriteLine("Va rugam sa ridicati produsul si restul (10 centi).Va multumim!");
                        }
                    }
                }
                else if (bani == q)
                {
                    Console.WriteLine("Va rugam sa ridicati produsul si restul (5 centi). Va multumim!");
                }


            }
            else if (bani==d)
            {
                Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                bani = int.Parse(Console.ReadLine());
                if (bani==n)
                {
                    Console.WriteLine("Va rugam sa mai introduceti monezi. Suma minima este 20 centi.");
                    bani = int.Parse(Console.ReadLine());
                    if (bani==n)
                        Console.WriteLine("Va rugam sa ridicati produsul!");
                    else if (bani == d)
                        Console.WriteLine("Va rugam sa ridicati produsul si restul (5 centi). Va multumim!");
                }
                else if (bani==d)
                    Console.WriteLine("Va rugam sa ridicati produsul!");
                else if (bani==q)
                    Console.WriteLine("Va rugam sa ridicati produsul si restul (15 centi). Va multumim!");
            }
            else if(bani==q)
                Console.WriteLine("Va rugam sa ridicati produsul si restul (5 centi). Va multumim!");
        }
    }
}
