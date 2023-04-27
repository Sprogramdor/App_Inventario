namespace Productos_y_botones
{
    partial class VerProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProductos));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Tablav = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Bborrar = new Productos_y_botones.RjControls.RJButton();
            this.Beditar = new Productos_y_botones.RjControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Tablav)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Productos_y_botones.Properties.Resources.delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.Frozen = true;
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::Productos_y_botones.Properties.Resources.edit;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // Tablav
            // 
            this.Tablav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablav.Location = new System.Drawing.Point(48, 127);
            this.Tablav.Name = "Tablav";
            this.Tablav.ReadOnly = true;
            this.Tablav.Size = new System.Drawing.Size(701, 317);
            this.Tablav.TabIndex = 0;
            this.Tablav.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tablav_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos Disponibles";
            // 
            // Bborrar
            // 
            this.Bborrar.BackColor = System.Drawing.Color.Red;
            this.Bborrar.BackgroundColor = System.Drawing.Color.Red;
            this.Bborrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Bborrar.BorderRadius = 15;
            this.Bborrar.BorderSize = 0;
            this.Bborrar.FlatAppearance.BorderSize = 0;
            this.Bborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bborrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bborrar.ForeColor = System.Drawing.Color.White;
            this.Bborrar.Location = new System.Drawing.Point(641, 485);
            this.Bborrar.Name = "Bborrar";
            this.Bborrar.Size = new System.Drawing.Size(108, 40);
            this.Bborrar.TabIndex = 2;
            this.Bborrar.Text = "Eliminar";
            this.Bborrar.TextColor = System.Drawing.Color.White;
            this.Bborrar.UseVisualStyleBackColor = false;
            this.Bborrar.Click += new System.EventHandler(this.Bborrar_Click_1);
            // 
            // Beditar
            // 
            this.Beditar.BackColor = System.Drawing.Color.DarkGray;
            this.Beditar.BackgroundColor = System.Drawing.Color.DarkGray;
            this.Beditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Beditar.BorderRadius = 15;
            this.Beditar.BorderSize = 0;
            this.Beditar.FlatAppearance.BorderSize = 0;
            this.Beditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Beditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beditar.ForeColor = System.Drawing.Color.White;
            this.Beditar.Location = new System.Drawing.Point(502, 485);
            this.Beditar.Name = "Beditar";
            this.Beditar.Size = new System.Drawing.Size(112, 40);
            this.Beditar.TabIndex = 3;
            this.Beditar.Text = "Actualizar";
            this.Beditar.TextColor = System.Drawing.Color.White;
            this.Beditar.UseVisualStyleBackColor = false;
            this.Beditar.Click += new System.EventHandler(this.Beditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(-3, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 37);
            this.panel1.TabIndex = 4;
            // 
            // VerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Beditar);
            this.Controls.Add(this.Bborrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tablav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(814, 615);
            this.MinimumSize = new System.Drawing.Size(814, 615);
            this.Name = "VerProductos";
            this.Text = "VerProductos";
            this.Load += new System.EventHandler(this.VerProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView Tablav;
        private System.Windows.Forms.Label label1;
        private RjControls.RJButton Bborrar;
        private RjControls.RJButton Beditar;
        private System.Windows.Forms.Panel panel1;
    }
}