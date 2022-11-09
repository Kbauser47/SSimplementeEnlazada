using Lista_SE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSimplementeEnlazada
{
    public partial class Form1 : Form
    {
        private TLisAsig Lista1;
        public Form1()
        {
            InitializeComponent();
            Lista1 = new TLisAsig();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Lista1.BuscarAsig(textBox1.Text) == true)
            {
                TNodoAsig Despues;
                Despues = (TNodoAsig)Lista1.getProxCursor();
                textBox1.Text = Despues.dameAsig();
                textBox2.Text = Despues.dameHoras().ToString();
            }
            else
            {
                MessageBox.Show("No existe Siguiente");
                return;
            }
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {

            string Insercion;
            Lista1.crearLista(textBox1.Text, int.Parse(textBox2.Text));
            Insercion = textBox1.Text + " - " + textBox2.Text;
            //textBox2.Text = "";
            textBox1.Focus();
            //textBox1.Text = null;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            TNodoAsig Sobre;
            if(Lista1.BuscarAsig(textBox1.Text)==true)
            {

                Sobre = (TNodoAsig)Lista1.eliminar();
                textBox1.Text = "";
                textBox2.Text = "";

            }

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            TNodoAsig Inicio;
            Inicio = (TNodoAsig)Lista1.getPrimero();
            if (Inicio == null)
            {
                MessageBox.Show("Lista Vacia");
                return;
            }
            else
            {
                textBox1.Text = Inicio.dameAsig();
                textBox2.Text= (Inicio.dameHoras()).ToString() ;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            TNodoAsig Antes;
            if(Lista1.BuscarAsig(textBox1.Text) == true)
            {

                Antes = (TNodoAsig)Lista1.getAntCursor();
                textBox1.Text = Antes.dameAsig();
                textBox2.Text = Antes.dameHoras().ToString();

            }
            else
            {
                MessageBox.Show("No existe anterior");
                return;
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {

            TNodoAsig Final;
            Final = (TNodoAsig)Lista1.getUltimo();
            if (Final == null)
            {

                MessageBox.Show("Lista Vacia");
                return;

            }

            textBox1.Text = Final.dameAsig();
            textBox2.Text = Final.dameHoras().ToString();

        }
    }
}
