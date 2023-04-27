namespace Productos_y_botones
{
    partial class Agregar_Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Producto));
            this.label1 = new System.Windows.Forms.Label();
            this.icono = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Bactualizar = new Productos_y_botones.RjControls.RJButton();
            this.btnGuardar = new Productos_y_botones.RjControls.RJButton();
            this.txtDescripción = new CustomControls.RJControls.RJTextBox();
            this.txtDimensión = new CustomControls.RJControls.RJTextBox();
            this.txtID = new CustomControls.RJControls.RJTextBox();
            this.txtNombre = new CustomControls.RJControls.RJTextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Producto";
            // 
            // icono
            // 
            this.icono.Image = global::Productos_y_botones.Properties.Resources.aggproduct;
            this.icono.Location = new System.Drawing.Point(27, 21);
            this.icono.Margin = new System.Windows.Forms.Padding(2);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(50, 47);
            this.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icono.TabIndex = 1;
            this.icono.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(72, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(75, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(84, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(238, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dimensión";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(75, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(238, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.ForeColor = System.Drawing.Color.Black;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Refrigerador",
            "Telefono",
            "Cocina",
            "Aire acondicionado",
            "Linea blanca",
            "Multimedia",
            "Computador"});
            this.cmbTipo.Location = new System.Drawing.Point(241, 236);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(157, 28);
            this.cmbTipo.TabIndex = 13;
            // 
            // Bactualizar
            // 
            this.Bactualizar.BackColor = System.Drawing.Color.LightBlue;
            this.Bactualizar.BackgroundColor = System.Drawing.Color.LightBlue;
            this.Bactualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Bactualizar.BorderRadius = 10;
            this.Bactualizar.BorderSize = 0;
            this.Bactualizar.FlatAppearance.BorderSize = 0;
            this.Bactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bactualizar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bactualizar.ForeColor = System.Drawing.Color.Black;
            this.Bactualizar.Location = new System.Drawing.Point(169, 404);
            this.Bactualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Bactualizar.Name = "Bactualizar";
            this.Bactualizar.Size = new System.Drawing.Size(119, 38);
            this.Bactualizar.TabIndex = 15;
            this.Bactualizar.Text = "Actualizar";
            this.Bactualizar.TextColor = System.Drawing.Color.Black;
            this.Bactualizar.UseVisualStyleBackColor = false;
            this.Bactualizar.Click += new System.EventHandler(this.Bactualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.LightBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(367, 404);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 38);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.Black;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripción
            // 
            this.txtDescripción.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripción.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDescripción.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescripción.BorderRadius = 10;
            this.txtDescripción.BorderSize = 2;
            this.txtDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripción.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripción.Location = new System.Drawing.Point(72, 308);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtDescripción.PasswordChar = false;
            this.txtDescripción.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescripción.PlaceholderText = "";
            this.txtDescripción.Size = new System.Drawing.Size(216, 63);
            this.txtDescripción.TabIndex = 12;
            this.txtDescripción.Texts = "";
            this.txtDescripción.UnderlinedStyle = false;
            // 
            // txtDimensión
            // 
            this.txtDimensión.BackColor = System.Drawing.SystemColors.Window;
            this.txtDimensión.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDimensión.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDimensión.BorderRadius = 10;
            this.txtDimensión.BorderSize = 2;
            this.txtDimensión.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensión.ForeColor = System.Drawing.Color.DimGray;
            this.txtDimensión.Location = new System.Drawing.Point(231, 171);
            this.txtDimensión.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDimensión.Multiline = false;
            this.txtDimensión.Name = "txtDimensión";
            this.txtDimensión.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtDimensión.PasswordChar = false;
            this.txtDimensión.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDimensión.PlaceholderText = "";
            this.txtDimensión.Size = new System.Drawing.Size(107, 29);
            this.txtDimensión.TabIndex = 11;
            this.txtDimensión.Texts = "";
            this.txtDimensión.UnderlinedStyle = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.BorderColor = System.Drawing.Color.DarkGray;
            this.txtID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtID.BorderRadius = 10;
            this.txtID.BorderSize = 2;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.DimGray;
            this.txtID.Location = new System.Drawing.Point(72, 171);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtID.PlaceholderText = "";
            this.txtID.Size = new System.Drawing.Size(119, 29);
            this.txtID.TabIndex = 10;
            this.txtID.Texts = "";
            this.txtID.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(72, 102);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(380, 29);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Silver;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(78, 239);
            this.txtPrecio.MaxLength = 11;
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(91, 29);
            this.txtPrecio.TabIndex = 16;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // Agregar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 453);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.Bactualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.txtDimensión);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.icono);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(527, 492);
            this.MinimumSize = new System.Drawing.Size(527, 492);
            this.Name = "Agregar_Producto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.Agregar_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJTextBox txtNombre;
        private CustomControls.RJControls.RJTextBox txtID;
        private CustomControls.RJControls.RJTextBox txtDimensión;
        private CustomControls.RJControls.RJTextBox txtDescripción;
        private System.Windows.Forms.ComboBox cmbTipo;
        private RjControls.RJButton btnGuardar;
        private RjControls.RJButton Bactualizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}