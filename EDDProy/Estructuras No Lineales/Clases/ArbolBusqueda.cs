using EDDemo.Estructuras_Lineales.Clases;
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
                b.AppendFormat("{0}->{1} [side=L label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }
            else
            {
                b.AppendFormat("{0}->L{1} [side=L, style=\"invis\" label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("L{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            else
            {
                b.AppendFormat("{0}->R{1} [side=R, style=\"invis\" label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("R{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);

            }
            return b.ToString();
        }
        public void PodaArbol()
        {
            if (Raiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }
            PodaArbol(ref Raiz);
        }
        public void PodaArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PodaArbol(ref nodo.Izq);
            PodaArbol(ref nodo.Der);

            nodo = null;
        }
        public void EliminarPredecesor(int x, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (x < nodo.Dato)
                EliminarPredecesor(x, ref nodo.Izq);
            else if (x > nodo.Dato)
                EliminarPredecesor(x, ref nodo.Der);
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario mayor = BuscaMayor(nodo.Izq);
                    nodo.Dato = mayor.Dato;
                    EliminarPredecesor(mayor.Dato, ref nodo.Izq);
                }
                else
                {
                    if (nodo == Raiz)
                    {
                        if (nodo.Izq != null)
                            Raiz = nodo.Izq;
                        else if (nodo.Der != null)
                            Raiz = nodo.Der;
                        else
                            Raiz = null;
                    }

                    NodoBinario temp = nodo;
                    if (nodo.Izq == null)
                        nodo = nodo.Der;
                    else if (nodo.Der == null)
                        nodo = nodo.Izq;

                    temp = null;
                }
            }
        }
        public NodoBinario BuscaMayor(NodoBinario nodo)
        {
            if (nodo == null)
                return null;
            else if (nodo.Der == null)
                return nodo;
            else
                return BuscaMayor(nodo.Der);
        }
        public void EliminarSucesor(int x, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (x < nodo.Dato)
            {
                EliminarSucesor(x, ref nodo.Izq);
            }
            else if (x > nodo.Dato)
            {
                EliminarSucesor(x, ref nodo.Der);
            }
            else if (nodo.Izq != null && nodo.Der != null)
            {
                NodoBinario menor = BuscaMenor(nodo.Der);
                nodo.Dato = menor.Dato;

                EliminarSucesor(menor.Dato, ref nodo.Der);
            }
            else
            {
                NodoBinario temp = nodo;
                if (nodo.Izq == null)
                {
                    nodo = nodo.Der;
                }
                else if (nodo.Der == null)
                {
                    nodo = nodo.Izq;
                }
                temp = null;
            }
        }

        private NodoBinario BuscaMenor(NodoBinario nodo)
        {
            while (nodo != null && nodo.Izq != null)
            {
                nodo = nodo.Izq;
            }
            return nodo;
        }
        public void RecorridoPorNivelesPersonalizado(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            Cola cola = new Cola();
            cola.Queue(nodo);

            strRecorrido = ""; 
            while (!cola.IsEmpty())
            {
                NodoBinario actual = cola.DeQueue();
                strRecorrido += actual.Dato + " - ";

                if (actual.Izq != null)
                    cola.Queue(actual.Izq);

                if (actual.Der != null)
                    cola.Queue(actual.Der);
            }
        }
        public int Altura(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            int AltIzquierda = Altura(nodo.Izq);
            int AltDerecha = Altura(nodo.Der);

            return 1 + Math.Max(AltIzquierda, AltDerecha);
        }
        public int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            if (nodo.Izq == null && nodo.Der == null)
            {
                return 1;
            }

            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }
        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);

        }
        public bool EsLleno(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return true;
            }

            if (nodo.Izq == null && nodo.Der == null)
            {
                return true;
            }

            if (nodo.Izq != null && nodo.Der != null)
            {
                return EsLleno(nodo.Izq) && EsLleno(nodo.Der);
            }
            return false;
        }
        public bool EsArbolCompleto(NodoBinario nodo)
        {
            if (nodo == null)
                return true; 

            Cola colaAuxiliar = new Cola();
            colaAuxiliar.Queue(nodo);

            bool nodoLleno = false; 
            while (!colaAuxiliar.IsEmpty())
            {
                NodoBinario nodoAuxiliar = colaAuxiliar.DeQueue();

                if (nodoAuxiliar.Izq != null)
                {
                    if (nodoLleno)
                        return false; 

                    colaAuxiliar.Queue(nodoAuxiliar.Izq);
                }
                else
                {
                    nodoLleno = true; 
                }

                if (nodoAuxiliar.Der != null)
                {
                    if (nodoLleno)
                        return false;

                    colaAuxiliar.Queue(nodoAuxiliar.Der);
                }
                else
                {
                    nodoLleno = true;
                }
            }
            return true; 
        }
    }
}
