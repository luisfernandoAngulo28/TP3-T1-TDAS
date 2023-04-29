using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class clsComp
    {//Atributos
        private float _parteReal; //_e
        private int _parteCompleja;//_d

       

       
        public float parteReal
        {
            get { return _parteReal; }
            set { _parteReal = value; }
        }

        public int parteCompleja
        {
            get { return _parteCompleja; }
            set { _parteCompleja = value; }
        }


        public clsComp()
        {
            this.parteReal = 0;
            this.parteCompleja = 0;
        }
        public clsComp(int e, int d)
        {
            this.parteReal = e;
            this.parteCompleja = d;
            

        }

        public char signo()
        {
            if (parteCompleja >= 0)
            {
                return '+';
            }
            else
            {
                return '-';
            }

        }

        public bool esCero(clsComp numero)
        {
            return numero.parteReal == 0 && numero.parteCompleja == 0;
        }

        public float ParteReal(clsComp numero)
        {
            return numero.parteReal;
        }

        public int ParteDecimal(clsComp numero)
        {
            return numero.parteCompleja;
        }

        public clsComp Suma(clsComp numero1, clsComp numero2)
        {
            clsComp sumaDeComplejos = new clsComp();
            sumaDeComplejos.parteReal = numero1.parteReal + numero2.parteReal;
            sumaDeComplejos.parteCompleja = numero1.parteCompleja + numero2.parteCompleja;
            

            return sumaDeComplejos;
        }

        public string Mostrar()
        {
            return parteReal + " " + signo()+parteCompleja+"i";
        }


    }
}
