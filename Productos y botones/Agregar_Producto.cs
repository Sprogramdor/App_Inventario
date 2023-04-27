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
    public partial class Agregar_Producto : Form
    {

        bool NRchack;
        int NR=0;
        public Agregar_Producto()

        {
            InitializeComponent();
            this.Bactualizar.Visible = false;
            
      
           
        }

        public Agregar_Producto( bool Aviso, Producto pdt)

        {
            InitializeComponent();
            if (Aviso)
            {
                this.btnGuardar.Visible = false;
                this.Bactualizar.Visible = true;
                this.label1.Text = "Actualizar Producto";
                this.icono.Visible = false; 
                this.NRchack= this.EditarProducto(pdt);
              
            }





        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            int re = DBproduct.Agregar(this.crearproducto());
            if (re > 0)
            {
                MessageBox.Show("Producto guardado");
                limpiar();
            }
            else
            {
                MessageBox.Show("Producto no guardado");
            }
        }
        

        public Producto crearproducto()
        {
            Producto Prod = new Producto();
            Prod.Nombre = txtNombre.Texts;
            String zz = txtPrecio.Text;
            Prod.Precio = Convert.ToDouble(zz);
            Prod.ID = txtID.Texts;
            Prod.Dimension = txtDimensión.Texts;
            Prod.Descripcion = txtDescripción.Texts;
            Prod.Tipo = cmbTipo.Text;
            if (this.NRchack)
            {
                Prod.NRegistro = NR;
            }
            return Prod;
        }


        public bool EditarProducto(Producto pdt)
        {

            txtNombre.Texts = pdt.Nombre;
            txtPrecio.Text = pdt.Precio.ToString();
            txtID.Texts = pdt.ID;
            txtDimensión.Texts = pdt.Dimension;
            txtDescripción.Texts = pdt.Descripcion;
            cmbTipo.Text = pdt.Tipo;
            this.NR = pdt.NRegistro;
            return true;
        }


        public void limpiar()
        {
             txtNombre.Texts="";
             txtPrecio.Text = "";
             txtID.Texts = "";
             txtDimensión.Texts = "";
             txtDescripción.Texts = "";
             cmbTipo.Text = ""; 

        }


        private void Agregar_Producto_Load(object sender, EventArgs e)
        {



        }

        private void Bactualizar_Click(object sender, EventArgs e)
        {

            //this.crearproducto().ToString();
           // MessageBox.Show(this.crearproducto().toString(), "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            if (DBproduct.Actualizar(this.crearproducto()) > 0)
            {
                MessageBox.Show("Los datos del Producto se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.limpiar();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //if >0 actualizado correctamente 
            //DBproduct.Actualizar(null);


           
        }




       

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números

           
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                //toolTip1.IsBalloon = true;
                //toolTip1.Show("Solo se permiten numeros",this.txtPrecio, 3000);
                e.Handled = true;
            }
        }

       
    }
}
