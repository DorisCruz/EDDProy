﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
       
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDato.Text, out int nuevoDato))
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
                return;
            }
            miRaiz = miArbol.RegresaRaiz();


            if (miArbol.Busqueda(nuevoDato, miRaiz))
            {
                MessageBox.Show("El dato ya existe en el árbol.");
                txtDato.Text = "";
                return;
            }
            miArbol.strArbol = "";

            miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);

            miArbol.Muestra(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
            LabelPre.Text = "";
            LabelIn.Text = "";
            LabelPost.Text = "";
            txtNodos.Text = "";
        }
       
        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnRecorrer_Click_1(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                LabelPre.Text = "El arbol esta vacio";
                return;
            }
            LabelPre.Text = "";
            miArbol.PreOrden(miRaiz);

            LabelPre.Text = miArbol.strRecorrido;

            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                LabelIn.Text = "El arbol esta vacio";
                return;
            }
            LabelIn.Text = "";
            miArbol.InOrden(miRaiz);
            LabelIn.Text = miArbol.strRecorrido;

            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                LabelPost.Text = "El arbol esta vacio";
                return;
            }
            LabelPost.Text = "";
            miArbol.PostOrden(miRaiz);
            LabelPost.Text = miArbol.strRecorrido;
        }

        private void btnRandom_Click_1(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                miRaiz = miArbol.RegresaRaiz();

                if (miArbol.Busqueda(Dato, miRaiz))
                {
                    nNodos--;
                }
                else
                {
                    miArbol.InsertaNodo(Dato, ref miRaiz);
                }
            }
            miArbol.Muestra(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
         
            if (int.TryParse(txtDato.Text, out int valor))
            {
                miArbol.BuscaNodo(valor);
                txtDato.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }
    }
}
