using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProyectoFinal2
{
    class Iterador : IEnumerable
    {
       
        private int[] valores = new int[7];
        
        public Iterador() 
        {
            
            for (int n = 0; n < 7; n++)
                valores[n] = n + n;

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new ContenedorEnum(valores));
        }



    }
    class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int posicion = 0;
        

       
        public  ContenedorEnum (int[] pArreglo) 
        {
            arreglo = pArreglo;
        }

        object IEnumerator.Current
        {
            get 
            {
               return arreglo[posicion];
            } 
        }

        //object IEnumerator.Current => throw new NotImplementedException();

        // Siguiente elemento
        public bool MoveNext() 
        {
            posicion++;
            if (posicion < arreglo.Length)
                return true;
            else
                return false;
           

            
        }

        // devolver
        public void Reset()
        {
            posicion= 0;
        }
        

    }
}
