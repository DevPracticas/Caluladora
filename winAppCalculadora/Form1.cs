using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winAppCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("test_web_2p\\index.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevaOperacion obj = new frmNuevaOperacion();
            obj.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'calculadora4DataSet.resultadoOperacion' Puede moverla o quitarla según sea necesario.
            this.resultadoOperacionTableAdapter.Fill(this.calculadora4DataSet.resultadoOperacion);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.resultadoOperacionTableAdapter.Fill(this.calculadora4DataSet.resultadoOperacion);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmModificar obj = new frmModificar();
            obj.ShowDialog();
        }
    }
}
