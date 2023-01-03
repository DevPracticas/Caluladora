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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winAppCalculadora
{
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }
        int dato1, dato2;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (textBox1.Text != "")
                    {
                        try
                        {
                            operaciones obj = new operaciones();
                            entidades_resultado_operacion resp = obj.buscar(int.Parse(textBox1.Text));
                            dato1 = resp.dato1;
                            dato2 = resp.dato2;

                            lblOperacion.Text = resp.operacion.ToString();
                            txtDato1.Text = dato1.ToString();
                            txtDato2.Text = dato2.ToString();
                            lblOperacion.Text = Convert.ToString(resp.operacion);
                            lblId.Text = Convert.ToString(resp.id_resultadoOperacion);

                            txtDato1.Enabled = true;
                            txtDato1.Focus();
                            txtDato2.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Ingrese numeros enteros desde " + int.MinValue + " hasta " + int.MaxValue);
                        }
                    }
                    else
                        MessageBox.Show("ingrese valores");
                }
                else
                {
                    MessageBox.Show("ingrese números");
                    e.Handled = true;
                    return;
                }
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {

        }

        private void txtDato2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtDato2.Text != "")
                {
                    try
                    {
                        dato2 = int.Parse(txtDato2.Text);

                        if (dato2 == 0 &&  lblOperacion.Text == "División")
                            MessageBox.Show("no se puede dividir para cero");
                        else
                        {
                            entidades_resultado_operacion objEntidad = new entidades_resultado_operacion();
                            objEntidad.dato1 = int.Parse(txtDato1.Text);
                            objEntidad.dato2 = int.Parse(txtDato2.Text);
                            objEntidad.id_resultadoOperacion = Convert.ToInt32(lblId.Text);
                            objEntidad.operacion = lblOperacion.Text;

                            operaciones objOperaciones = new operaciones();

                            string resultado = objOperaciones.update(objEntidad);
                            MessageBox.Show(resultado);

                            txtDato1.Clear();
                            txtDato1.Enabled = false;

                            txtDato2.Clear();
                            txtDato2.Enabled = false;

                            
                        }
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show(error.Message);
                        MessageBox.Show("Ingrese numeros enteros desde " + int.MinValue + " hasta " + int.MaxValue);
                    }
                }
                else
                    MessageBox.Show("ingrese valores");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDato1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
    }
}
