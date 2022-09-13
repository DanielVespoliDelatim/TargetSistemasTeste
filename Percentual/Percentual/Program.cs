using System;

namespace Percentual
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sp = 67.83643m;

            decimal rj = 36.67866m;
            decimal mg = 29.22988m;
            decimal es = 27.16548m;
            decimal outros = 19.84953m;
            

            decimal spp;
            decimal rjs;
            decimal mgs;
            decimal ess;
            decimal outross;
            

            decimal valortotal = sp + rj + mg + es + outros;

            spp = (sp / valortotal) * 100;
            rjs = (rj / valortotal) * 100;
            mgs = (mg / valortotal) * 100;
            ess = (es / valortotal) * 100;
            outross = (outros / valortotal) * 100;


            Console.WriteLine(spp);
            Console.WriteLine(rjs);
            Console.WriteLine(mgs);
            Console.WriteLine(ess);
            Console.WriteLine(outross);
           
            


        }
    }
}
