using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;


namespace Productos
{
    public partial class Form1 : Form
    {
        ClaseEntidad objent = new ClaseEntidad();
        ClaseNegocio objneg = new ClaseNegocio();

        public Form1()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objent.codigo = txtCodigo.Text;
            objent.nombre = txtNombre.Text;
            objent.descripcion = txtDescripcion.Text;
            objent.unidades = Convert.ToInt32(txtUnidades.Text);
            objent.PrecioProveedor = Convert.ToInt32(txtPrecioProveedor.Text);
            objent.PrecioUnitario = Convert.ToInt32(txtPrecioUnitario.Text);
            objent.PrecioPublico = Convert.ToInt32(txtPrecioPublico.Text);
            objent.presentacion = txtPresentacion.Text;
            objent.fecha = txtFechaEntrada.Text;
            objent.categoria = txtCategoria.Text;

            objent.accion = accion;

            String men = objneg.N_mantenimientoProductos(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtUnidades.Text = "";
            txtPrecioProveedor.Text = "";
            txtPrecioUnitario.Text = "";
            txtPrecioPublico.Text = "";
            txtPresentacion.Text = "";
            txtFechaEntrada.Text = "";
            txtCategoria.Text = "";

            dataGridView1.DataSource = objneg.N_listarProductos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listarProductos();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                if (MessageBox.Show("Deseas registrar a " + txtNombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;
                {
                    mantenimiento("1");
                    limpiar();
                }   
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (MessageBox.Show("Deseas modificar a " + txtNombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;
                {
                    mantenimiento("2");
                    limpiar();
                }
            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar a " + txtNombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) ;
                {
                    mantenimiento("3");
                    limpiar();
                }
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                objent.codigo = txtBuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscarProductos(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_listarProductos();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtCodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtNombre.Text = dataGridView1[1, fila].Value.ToString();
            txtDescripcion.Text = dataGridView1[2, fila].Value.ToString();
            txtUnidades.Text = dataGridView1[3, fila].Value.ToString();
            txtPrecioProveedor.Text = dataGridView1[4, fila].Value.ToString();
            txtPrecioUnitario.Text = dataGridView1[5, fila].Value.ToString();
            txtPrecioPublico.Text = dataGridView1[6, fila].Value.ToString();
            txtPresentacion.Text = dataGridView1[7, fila].Value.ToString();
            txtFechaEntrada.Text = dataGridView1[8, fila].Value.ToString();
            txtCategoria.Text = dataGridView1[9, fila].Value.ToString();
        }
    }
}
