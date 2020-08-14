using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fibonnaci 3 - avaliação de teste");


            int fiboantes = 4181;
            int fiboatual = 6765;
            int somadefibos = fiboantes + fiboatual;



            Console.Write(fiboantes + "," + fiboatual + ",");


            for (int i = 1; i <= 1; i++)


                Console.Write(somadefibos + ",");
            fiboantes = fiboatual;
            fiboatual = somadefibos;
            somadefibos = fiboantes + fiboatual;






            Console.ReadKey();
        }

    }

}
