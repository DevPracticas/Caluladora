using capaEntidades;
using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winAppCalculadora
{
    public partial class frmNuevaOperacion : Form
    {
        public frmNuevaOperacion()
        {
            InitializeComponent();
        }

        private void txtOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmNuevaOperacion_Load(object sender, EventArgs e)
        {
            txtDato1.Enabled = false;
            txtDato2.Enabled = false;
            comboBox1.Focus();
        }

        private void txtDato1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if(e.KeyChar == (char)Keys.Enter)
                {
                    if (txtDato1.Text != "")
                    {
                        try
                        {
                            dato1 = int.Parse(txtDato1.Text);
                            txtDato2.Enabled = true;
                            txtDato2.Focus();
                        }
                        catch
                        {
                            MessageBox.Show("Ingrese numeros enteros desde " + int.MinValue + " hasta " + int.MaxValue);
                        }
                    }
                    else
                        MessageBox.Show("ingrese valores");
                }
             
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtDato1.Enabled = true;
            txtDato1.Focus();
        }
        int dato2, dato1;
        private void txtDato2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtDato2.Text != "")
                {
                    try
                    {
                        dato2 = int.Parse(txtDato2.Text);

                        if (dato2 == 0 && Convert.ToString(comboBox1.SelectedItem) == "División")
                            MessageBox.Show("no se puede dividir para cero");
                        else
                        {
                            entidades_resultado_operacion objEntidad = new entidades_resultado_operacion();
                            objEntidad.dato1 = dato1;
                            objEntidad.dato2 = dato2;
                            objEntidad.operacion = Convert.ToString(comboBox1.SelectedItem);

                            operaciones objOperaciones = new operaciones();
                            string resultado = objOperaciones.nuevaOperacion(objEntidad);
                            MessageBox.Show(resultado);

                            txtDato1.Clear();
                            txtDato1.Enabled = false;

                            txtDato2.Clear();
                            txtDato2.Enabled = false;

                            comboBox1.Focus();
                            comboBox1.SelectedIndex = -1;
                            comboBox1.Text = "Seleccione una operación";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ingrese numeros enteros desde " + int.MinValue + " hasta " + int.MaxValue);
                    }
                }
                else
                    MessageBox.Show("ingrese valores");
            }
        }
    }
}
