using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KombinatorikaLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] brojevi = new int[ ] { 1,2,3,4,5,6,7,8,9};

            var upit =
                from broj1 in brojevi
                from broj2 in brojevi

                where broj2 != broj1 && (broj1 * 10 + broj2) % 2 == 0
                from broj3 in brojevi
                where broj3 != broj2 && broj3 != broj1 && (broj1 * 100 + broj2 * 10 + broj3) % 3 == 0
                from broj4 in brojevi
                where broj4 != broj3 && broj4 != broj1 && broj4 != broj2 && (broj1 * 1000 + broj2 * 100 + broj3 * 10 + broj4) % 4 == 0
                from broj5 in brojevi
                where broj5 != broj3 && broj5 != broj1 && broj5 != broj2 && broj5 != broj4 && broj1;

            Console.ReadKey();
        }
    }
}
