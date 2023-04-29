using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class clsNatu
    {
       //Atributos
       private int _n;
       
       public int n
        {
            get { return _n; }
            set { _n = value; }
        }

        //Constructor sin Parametros de Entrada
        public clsNatu()
        {
            this.n = 0;
        }

        //Constructor Con Parametros de Entrada
        public clsNatu(int x)
        {
            if (x>=0)
            {
                this.n = x;
            }
            else
            {
                this.n = 0;
               
            }
                
        }

        //Constructor De Copia
        public clsNatu(clsNatu t)
        {
            if (t.n >= 0)
            {
                this.n = t.n;
            }
            else
            {
                this.n = 0;

            }

            
        }

        public int cero()
        {
            return 0;
        }

        public bool esCero(clsNatu numero)
        {
            return numero.n == 0;
        }

        public clsNatu Sucesor( clsNatu numero)
        {
            numero.n = numero.n + 1;
            return numero;
        }

        public clsNatu Predecesor(clsNatu numero)
        {
            if (esCero(numero))
            {

                numero.n = numero.n - 1;
            }
           
            return numero;
        }

        public bool esIgual(clsNatu numero1,clsNatu numero2)
        {
            if(esCero(numero1) && !esCero(numero2))
            {
                return false;
            }
            if (!esCero(numero1) && esCero(numero2))
            {
                return false;
            }
            if(numero1.n== numero2.n)
            {
                return true;
            }
            return false;

        }
        public clsNatu suma(clsNatu numero1, clsNatu numero2)
        {
            if (esCero(numero1) && !esCero(numero2))
            {
                return numero2;
            }
            if (!esCero(numero1) && esCero(numero2))
            {
                return numero1;
            }
            clsNatu sumadeNaturales = new clsNatu();
            sumadeNaturales.n = numero1.n + numero2.n;
            return sumadeNaturales;

        }

    }
}
