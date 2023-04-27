using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos_y_botones
{
    public partial class iManager : Form
    {
        public iManager()
        {
            InitializeComponent();

        }

        private void Bagregar_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Bagregar_MouseLeave(object sender, EventArgs e)
        {
            Bagregar.BorderSize = 0;
        }

        private void Bagregar_MouseClick(object sender, MouseEventArgs e)
        {
            Agregar_Producto a = new Agregar_Producto();
            a.ShowDialog();
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto buscar= new BuscarProducto();    
                buscar.ShowDialog();    
        }

        private void Bver_Click(object sender, EventArgs e)
        {
            VerProductos ver=new VerProductos();    
            ver.ShowDialog();
        }

        private void iManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed

            Application.Exit();
        }
    }
}
