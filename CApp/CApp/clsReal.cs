using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
     public class clsReal
    {
        //Atributos
        private int _parteEntera; //_e
        private Double _parteDecimal;//_d

        public int parteEntera
        {   get { return _parteEntera; }
            set { _parteEntera = value; }
        }

        public Double parteDecimal
        {
            get { return _parteDecimal; }
            set { _parteDecimal = value; }
        }

        public clsReal()
        {
            this.parteEntera = 0;
            this.parteDecimal = 0;
        }






        //Constructor Con Parametros 
        public clsReal(int e,int d)
        {
            this.parteEntera = e;
            if (d >= 0)
            {
                this.parteDecimal = Math.Abs(d);
                parteEntera = +parteEntera;
            }
            else
            {
                this.parteDecimal = Math.Abs(d);
                parteEntera = -parteEntera;
            }
 
        }

        public bool esCero(clsReal numero)
        {
            return numero.parteEntera == 0 && numero.parteDecimal==0;
        }

        public int ParteEntera(clsReal numero)
        {
            return numero.parteEntera;
        }

        public Double ParteDecimal(clsReal numero)
        {
            return numero.parteDecimal;
        }



        public clsReal Suma(clsReal numero1,clsReal numero2)
        {
            clsReal sumaDeReal = new clsReal();
            sumaDeReal.parteEntera = numero1.parteEntera + numero2.parteEntera;
            sumaDeReal.parteDecimal = numero1.parteDecimal + numero2.parteDecimal;
            if (sumaDeReal.parteDecimal > 9)
            {
                sumaDeReal.parteEntera = sumaDeReal.parteEntera + 1;
                sumaDeReal.parteDecimal = sumaDeReal.parteDecimal-10;
            }
   
            return sumaDeReal;
        }

        public string Mostrar()
        {
            return parteEntera + "," + parteDecimal;
        }

    }
}
