using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pretul produsului este");
            int PretProdus = int.Parse(Console.ReadLine());
            bool ok = true;          
            while (ok==true)
            {
                Console.WriteLine("Introduceti monede de 5,10 sau 25 ");
                int NumarMonede = int.Parse(Console.ReadLine());
                while (NumarMonede < PretProdus)
                {
                    Console.WriteLine("Pana acum aveti introdusa suma de" + " " + NumarMonede+" "+"monede");
                    Console.WriteLine( "Va rugam sa mai introduceti monede de 5,10 sau 25 ");
                    NumarMonede+= int.Parse(Console.ReadLine());
                }

                ok = false;

               
                int REST = Rest(NumarMonede,PretProdus);
                RestulCalculat(REST);
                Console.WriteLine("Aveti produsul si restul dumneavoastra de" + " " + REST+"monede");

            }
        }

        static int Rest(int SumaIntrodusa, int PretProdus)// cat rest trebuie sa dea
        {
            int k = SumaIntrodusa - PretProdus;
            return k;
        }
       
        
        static void RestulCalculat(int rest) // Cum da restul
        {
            if (rest <= 0)
            {
                return;
            }


            int nickles = 0;
            int quarters = 0;
            int dimes = 0;


            while (rest > 0)
            {
                if (rest >= 25)
                {
                    rest -= 25;
                    ++quarters;
                }

                else if (rest >= 5)
                {
                    rest -= 5;
                    ++nickles;
                }
                else if (rest >= 10)
                {
                    rest -= 10;
                    ++dimes;
                }

            }
           

           
        }
    }
}
