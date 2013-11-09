namespace Inventario
{
    partial class Agregar_Invetario
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre_Producto = new System.Windows.Forms.TextBox();
            this.txtCantidad_del_Producto = new System.Windows.Forms.NumericUpDown();
            this.txtUnidad_de_medida = new System.Windows.Forms.DomainUpDown();
            this.txtNombre_del_Proovedor = new System.Windows.Forms.TextBox();
            this.txtEmpresa_del_proovedor = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btbGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad_del_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de Proovedor ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Empresa de Proovedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefono del Proovedor";
            // 
            // txtNombre_Producto
            // 
            this.txtNombre_Producto.Location = new System.Drawing.Point(12, 63);
            this.txtNombre_Producto.Name = "txtNombre_Producto";
            this.txtNombre_Producto.Size = new System.Drawing.Size(179, 20);
            this.txtNombre_Producto.TabIndex = 7;
            // 
            // txtCantidad_del_Producto
            // 
            this.txtCantidad_del_Producto.Location = new System.Drawing.Point(243, 63);
            this.txtCantidad_del_Producto.Name = "txtCantidad_del_Producto";
            this.txtCantidad_del_Producto.Size = new System.Drawing.Size(64, 20);
            this.txtCantidad_del_Producto.TabIndex = 9;
            this.txtCantidad_del_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnidad_de_medida
            // 
            this.txtUnidad_de_medida.Items.Add("Kg");
            this.txtUnidad_de_medida.Items.Add("Lts");
            this.txtUnidad_de_medida.Items.Add("gr.");
            this.txtUnidad_de_medida.Location = new System.Drawing.Point(377, 64);
            this.txtUnidad_de_medida.Name = "txtUnidad_de_medida";
            this.txtUnidad_de_medida.Size = new System.Drawing.Size(57, 20);
            this.txtUnidad_de_medida.TabIndex = 10;
            this.txtUnidad_de_medida.Text = "Kg";
            this.txtUnidad_de_medida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombre_del_Proovedor
            // 
            this.txtNombre_del_Proovedor.Location = new System.Drawing.Point(12, 155);
            this.txtNombre_del_Proovedor.Name = "txtNombre_del_Proovedor";
            this.txtNombre_del_Proovedor.Size = new System.Drawing.Size(138, 20);
            this.txtNombre_del_Proovedor.TabIndex = 11;
            // 
            // txtEmpresa_del_proovedor
            // 
            this.txtEmpresa_del_proovedor.Location = new System.Drawing.Point(176, 155);
            this.txtEmpresa_del_proovedor.Name = "txtEmpresa_del_proovedor";
            this.txtEmpresa_del_proovedor.Size = new System.Drawing.Size(121, 20);
            this.txtEmpresa_del_proovedor.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(316, 155);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // btbGuardar
            // 
            this.btbGuardar.Location = new System.Drawing.Point(42, 223);
            this.btbGuardar.Name = "btbGuardar";
            this.btbGuardar.Size = new System.Drawing.Size(75, 23);
            this.btbGuardar.TabIndex = 14;
            this.btbGuardar.Text = "Guardar";
            this.btbGuardar.UseVisualStyleBackColor = true;
            this.btbGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agregar_Invetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 270);
            this.Controls.Add(this.btbGuardar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmpresa_del_proovedor);
            this.Controls.Add(this.txtNombre_del_Proovedor);
            this.Controls.Add(this.txtUnidad_de_medida);
            this.Controls.Add(this.txtCantidad_del_Producto);
            this.Controls.Add(this.txtNombre_Producto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Agregar_Invetario";
            this.Text = "Agregar Producto a Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad_del_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre_Producto;
        private System.Windows.Forms.NumericUpDown txtCantidad_del_Producto;
        private System.Windows.Forms.DomainUpDown txtUnidad_de_medida;
        private System.Windows.Forms.TextBox txtNombre_del_Proovedor;
        private System.Windows.Forms.TextBox txtEmpresa_del_proovedor;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btbGuardar;
    }
}