using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            return Raiz == null;
        }

        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario();
                Nodo.Dato = Dato;
                Nodo.Izq = null;
                Nodo.Der = null;

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }

        public void Muestra(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            Muestra(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol += "     ";
            }
            strArbol += nodo.Dato.ToString() + "\r\n";
            Muestra(nivel + 1, nodo.Izq);
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido += nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido += nodo.Dato + ", ";
            InOrden(nodo.Der);
        }

        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido += nodo.Dato + ", ";
        }

        public bool Busqueda(int valor, NodoBinario nodo)
        {
            if (nodo == null)
            {
                return false;
            }
            else if (valor < nodo.Dato)
            {
                return Busqueda(valor, nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                return Busqueda(valor, nodo.Der);
            }
            else
            {
                return true;
            }
        }

        public void BuscaNodo(int valor)
        {
            if (Raiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            if (Busqueda(valor, Raiz))
            {
                MessageBox.Show("Se ha encontrado el dato: " + valor);
            }
            else
            {
                MessageBox.Show("Valor no encontrado");
            }
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

    }
}
