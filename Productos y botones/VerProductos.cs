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
    public partial class VerProductos : Form
    {

        
        public VerProductos()
        {
            InitializeComponent();
            

        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            this.Tablav.DataSource = DBproduct.Cargar();

        }


        private void Beditar_Click(object sender, EventArgs e)
        {
            Producto ProductoSelect;


            if (Tablav.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(this.Tablav.CurrentRow.Cells[0].Value);
                
                ProductoSelect = DBproduct.ObtenerProducto(id);
               
                Agregar_Producto ag = new Agregar_Producto(true, ProductoSelect);
                
                ag.ShowDialog();
                this.Tablav.DataSource = DBproduct.Cargar();
                //this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");


          



        }

        private void Bborrar_Click(object sender, EventArgs e)
        {

        }

        private void Bborrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Producto Actual", "Estas Seguro ??",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DBproduct.Eliminar((int)this.Tablav.CurrentRow.Cells[0].Value ) > 0)
                {

                    MessageBox.Show("Producto Eliminado Correctamente!", "Producto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Tablav.DataSource = DBproduct.Cargar();


                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Producto", "Producto No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Tablav_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
