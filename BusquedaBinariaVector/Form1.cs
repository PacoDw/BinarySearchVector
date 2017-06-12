using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaBinariaVector
{
    public partial class Form1 : Form
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS ATTRIBUTES
        private Vector vector;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CLASS CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD CREAR VECTOR CLICK
        private void bttonCrearVector_Click(object sender, EventArgs e)
        {
            vector = new Vector();
            vector.CrearVector();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METHOD BUSCAR CLICK
        private void bttonBuscar_Click(object sender, EventArgs e)
        {
            int indice = vector.Buscar(Convert.ToInt32(txtBuscar.Text));

            txtResultado.Text = "indice: " + Convert.ToString(indice) + "  valor:" + vector._vector[indice]
                              + "  comparacionnes: " + vector.Cout;
        }

    }
}
