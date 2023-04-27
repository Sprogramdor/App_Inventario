namespace Productos_y_botones
{
    partial class BuscarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProducto));
            this.dataG = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboB = new System.Windows.Forms.ComboBox();
            this.pictureNO = new System.Windows.Forms.PictureBox();
            this.Bbuscar = new Productos_y_botones.RjControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNO)).BeginInit();
            this.SuspendLayout();
            // 
            // dataG
            // 
            this.dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG.Location = new System.Drawing.Point(27, 129);
            this.dataG.Name = "dataG";
            this.dataG.ReadOnly = true;
            this.dataG.Size = new System.Drawing.Size(675, 303);
            this.dataG.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(-3, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 33);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(213, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar  Producto";
            // 
            // ComboB
            // 
            this.ComboB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ComboB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboB.FormattingEnabled = true;
            this.ComboB.Items.AddRange(new object[] {
            "-Tipo de Producto -",
            "Refrigerador",
            "Telefono",
            "Cocina",
            "Aire acondicionado",
            "Linea blanca",
            "Multimedia",
            "Computador"});
            this.ComboB.Location = new System.Drawing.Point(180, 75);
            this.ComboB.Name = "ComboB";
            this.ComboB.Size = new System.Drawing.Size(326, 31);
            this.ComboB.TabIndex = 5;
            // 
            // pictureNO
            // 
            this.pictureNO.Image = global::Productos_y_botones.Properties.Resources.emoji;
            this.pictureNO.Location = new System.Drawing.Point(180, 129);
            this.pictureNO.Name = "pictureNO";
            this.pictureNO.Size = new System.Drawing.Size(362, 303);
            this.pictureNO.TabIndex = 6;
            this.pictureNO.TabStop = false;
            // 
            // Bbuscar
            // 
            this.Bbuscar.BackColor = System.Drawing.Color.White;
            this.Bbuscar.BackgroundColor = System.Drawing.Color.White;
            this.Bbuscar.BorderColor = System.Drawing.Color.LightSlateGray;
            this.Bbuscar.BorderRadius = 10;
            this.Bbuscar.BorderSize = 1;
            this.Bbuscar.FlatAppearance.BorderSize = 0;
            this.Bbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bbuscar.ForeColor = System.Drawing.Color.LightGray;
            this.Bbuscar.Image = global::Productos_y_botones.Properties.Resources.bi;
            this.Bbuscar.Location = new System.Drawing.Point(512, 71);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(47, 41);
            this.Bbuscar.TabIndex = 2;
            this.Bbuscar.TextColor = System.Drawing.Color.LightGray;
            this.Bbuscar.UseVisualStyleBackColor = false;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 484);
            this.Controls.Add(this.pictureNO);
            this.Controls.Add(this.ComboB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bbuscar);
            this.Controls.Add(this.dataG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(751, 523);
            this.MinimumSize = new System.Drawing.Size(751, 523);
            this.Name = "BuscarProducto";
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.BuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataG;
        private RjControls.RJButton Bbuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboB;
        private System.Windows.Forms.PictureBox pictureNO;
    }
}