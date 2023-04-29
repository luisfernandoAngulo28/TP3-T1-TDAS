using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {  
        //Aqui Hacemos la llamda en consola
        public static void Main(string[] args)
        {
            /*clsNatu numeroNaturaluno = new clsNatu(12);  2,5
            clsNatu numeroNaturaldos = new clsNatu(18);
            clsNatu numeroNaturaltres = new clsNatu();
            Console.Write("la suma es ");
            Console.WriteLine(numeroNaturaltres.suma(numeroNaturaluno,numeroNaturaldos).n);*/
            /*clsReal numeroRealuno = new clsReal(2,5);
            clsReal numeroRealdos = new clsReal(2,5);
            clsReal numeroRealtres = new clsReal();
            Console.Write("la suma es ");
            Console.WriteLine(numeroRealtres.Suma(numeroRealuno, numeroRealdos).Mostrar());
           */
            // Double numero = 2500.16;
            // Double parteEntera = Math.Truncate(numero);


            /* clsConj conjunto = new clsConj();
             conjunto.Add(5);
             conjunto.Add(6);
             conjunto.Add(7);
             Console.WriteLine("A="+conjunto.view());*/
           /* clsBols bolsa = new clsBols();
            bolsa.Add(5);
            bolsa.Add(6);
            bolsa.Add(7);
            bolsa.Add(7);
            Console.WriteLine("A=" + bolsa.view());*/

            clsComp numeroComplejouno = new clsComp(2, 5);
            clsComp numeroComplejodos = new clsComp(2, 5);
            clsComp numeroComplejotres = new clsComp();
            Console.WriteLine("numero Complejo uno  " + numeroComplejouno.Mostrar());
            Console.WriteLine("numero Complejo dos  " + numeroComplejodos.Mostrar());
            Console.Write("la suma es ");
            Console.WriteLine(numeroComplejotres.Suma(numeroComplejouno, numeroComplejodos).Mostrar());

            Console.ReadKey();
        }
    }
}
