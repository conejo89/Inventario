namespace Inventario
{
    partial class Inventario_disponible
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
            this.salir = new System.Windows.Forms.Button();
            this.bttaceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre_Producto = new System.Windows.Forms.TextBox();
            this.txtEmpresa_del_proovedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BttBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(424, 318);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 0;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // bttaceptar
            // 
            this.bttaceptar.Location = new System.Drawing.Point(95, 318);
            this.bttaceptar.Name = "bttaceptar";
            this.bttaceptar.Size = new System.Drawing.Size(75, 23);
            this.bttaceptar.TabIndex = 17;
            this.bttaceptar.Text = "Aceptar";
            this.bttaceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de Producto";
            // 
            // txtNombre_Producto
            // 
            this.txtNombre_Producto.Location = new System.Drawing.Point(126, 53);
            this.txtNombre_Producto.Name = "txtNombre_Producto";
            this.txtNombre_Producto.Size = new System.Drawing.Size(179, 20);
            this.txtNombre_Producto.TabIndex = 14;
            // 
            // txtEmpresa_del_proovedor
            // 
            this.txtEmpresa_del_proovedor.Location = new System.Drawing.Point(126, 105);
            this.txtEmpresa_del_proovedor.Name = "txtEmpresa_del_proovedor";
            this.txtEmpresa_del_proovedor.Size = new System.Drawing.Size(179, 20);
            this.txtEmpresa_del_proovedor.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Empresa de Proovedor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // BttBuscar
            // 
            this.BttBuscar.Location = new System.Drawing.Point(380, 68);
            this.BttBuscar.Name = "BttBuscar";
            this.BttBuscar.Size = new System.Drawing.Size(75, 41);
            this.BttBuscar.TabIndex = 21;
            this.BttBuscar.Text = "Buscar";
            this.BttBuscar.UseVisualStyleBackColor = true;
            this.BttBuscar.Click += new System.EventHandler(this.BttBuscar_Click);
            // 
            // Inventario_disponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 353);
            this.Controls.Add(this.BttBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmpresa_del_proovedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttaceptar);
            this.Controls.Add(this.txtNombre_Producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Name = "Inventario_disponible";
            this.Text = "Inventario_disponible";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button bttaceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre_Producto;
        private System.Windows.Forms.TextBox txtEmpresa_del_proovedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BttBuscar;
    }
}