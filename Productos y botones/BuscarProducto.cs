using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Productos_y_botones.Base_de_Datos;

namespace Productos_y_botones
{
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
           this.ComboB.SelectedIndex = 0;
            pictureNO.Visible = false;

        }

        private void Tbuscar__TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {

        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
          dataG.DataSource =DBproduct.Buscar(this.ComboB.Text);
            List<Producto> lista = DBproduct.Buscar(this.ComboB.Text);

            if (!lista.Any())
            {
                dataG.Visible = false;
                pictureNO.Visible = true;
                this.panel1.BackColor = Color.Red;
            }
            else
            {
                dataG.Visible=true;
                pictureNO.Visible = false;
                this.panel1.BackColor = Color.DarkGray;
            }


        }
    }
}
