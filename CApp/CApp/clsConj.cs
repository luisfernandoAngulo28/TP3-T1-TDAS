using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class clsConj
    {   //Atributos
    
        int[]V = new int[50];
        int pos;
        int cant;

       public int posicion { 
           get { return pos; }
           set { pos = value; }
       }


        public int cantidad
        {
            get { return cant; }
            set { cant = value; }
        }


        public int[] Vector
        {
            get { return V; }
            set { V = value; }
        }

        //Constructor
        public clsConj()
        {
            V = new int[50];
             posicion = -1; ;
            cantidad=0;
        }
        //Constructor con paramtros de entrada
        public clsConj(int n)
        {
            int[] V = new int[n];
            int pos = -1;
            int cant = 0;
        }

        //Constructor con paramtros de entrada
        public clsConj(clsConj C)
        {
            int[] V = new int[C.cant];
            int pos = C.pos ;
            int cant = C.cant;
        }

        public bool Vacio()
        {
            return this.cantidad == 0;
        }

        public bool Llena()
        {
            return this.cantidad == Vector.Length-1;
        }

        public void Add( int elemento)
        {
            if (!Llena())
            {
                if (!pertenece(elemento))
                {
                    posicion = posicion + 1;
                    Vector[posicion] = elemento;
                    cantidad++;
                }
            }
            else
            {
                Console.WriteLine("Error:Add:Conjunto Lleno");
            }
        }

        public bool pertenece(int elemento)
        {
            bool sw = false;
            int posi = 0;
            while (sw==false && posi<=cantidad)
            {
                if (Vector[posi] == elemento)
                {
                    sw = true;
                }
                else
                {
                    posi++;
                }
                
            }
            return sw;
        }


        public void Delete(int elemento)
        {
            if((elemento>=0) && (!Vacio()))
            {
                int i = 0;
                while ( i <= cantidad && Vector[i] != elemento )
                {
                    i++;
                }

                if (i <= cantidad)
                {
                    for (int j = i; j < cantidad; j++)
                    {
                        Vector[j] = Vector[j + 1];
                    }
                    cantidad--;
                }
            }
        }

        public string view()
        {
            string Salida = "{";
            for (int i = 0; i < cantidad; i++)
            {
                Salida = Salida + Vector[i] +",";
            }
            Salida = Salida.Substring(0, Salida.Length - 1);
            return Salida+"}";
        }

    }
}
