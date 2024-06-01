using Arbolbalanceado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbolbalanceado.Services
{
    public class ArbolBalanceado
    {
        public Nodo Raiz;

        public ArbolBalanceado()
        {
            Raiz = null;
        }

        
        public void Insertar(int valor)
        {
            Raiz = Insertar(Raiz, valor);
        }

      
        private Nodo Insertar(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                nodo = new Nodo(valor);
            }
            else if (valor < nodo.Valor)
            {
                nodo.Izquierdo = Insertar(nodo.Izquierdo, valor);
            }
            else
            {
                nodo.Derecho = Insertar(nodo.Derecho, valor);
            }

            return nodo;
        }

       
        public void Mostrar()
        {
            Mostrararbol(Raiz);
        }

       
        private void Mostrararbol(Nodo nodo)
        {
            if (nodo != null)
            {
                Mostrararbol(nodo.Izquierdo);
                Console.Write($"{nodo.Valor} ");
                Mostrararbol(nodo.Derecho);
            }
        }
    }
}
