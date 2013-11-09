using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Inventario_disponible : Form
    {
        public Inventario_disponible()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductoDAL.BuscarProducto(txtNombre_Producto.Text, txtEmpresa_del_proovedor.Text);
        }
    }
}
