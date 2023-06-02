
namespace ExamenTacticasoft
{
    partial class OpcionesAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesAdmin));
            this.btn_verProducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_atras = new System.Windows.Forms.PictureBox();
            this.btn_VerClientes = new System.Windows.Forms.Button();
            this.btn_VerVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_atras)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_verProducto
            // 
            this.btn_verProducto.Location = new System.Drawing.Point(117, 180);
            this.btn_verProducto.Name = "btn_verProducto";
            this.btn_verProducto.Size = new System.Drawing.Size(203, 62);
            this.btn_verProducto.TabIndex = 1;
            this.btn_verProducto.Text = "Ver Prodructos";
            this.btn_verProducto.UseVisualStyleBackColor = true;
            this.btn_verProducto.Click += new System.EventHandler(this.btn_verProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_atras
            // 
            this.btn_atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_atras.Image")));
            this.btn_atras.Location = new System.Drawing.Point(-1, 12);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(93, 59);
            this.btn_atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_atras.TabIndex = 4;
            this.btn_atras.TabStop = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_VerClientes
            // 
            this.btn_VerClientes.Location = new System.Drawing.Point(117, 298);
            this.btn_VerClientes.Name = "btn_VerClientes";
            this.btn_VerClientes.Size = new System.Drawing.Size(203, 62);
            this.btn_VerClientes.TabIndex = 5;
            this.btn_VerClientes.Text = "Ver Clientes";
            this.btn_VerClientes.UseVisualStyleBackColor = true;
            this.btn_VerClientes.Click += new System.EventHandler(this.btn_VerClientes_Click);
            // 
            // btn_VerVentas
            // 
            this.btn_VerVentas.Location = new System.Drawing.Point(117, 67);
            this.btn_VerVentas.Name = "btn_VerVentas";
            this.btn_VerVentas.Size = new System.Drawing.Size(203, 62);
            this.btn_VerVentas.TabIndex = 6;
            this.btn_VerVentas.Text = "Ver Ventas";
            this.btn_VerVentas.UseVisualStyleBackColor = true;
            // 
            // OpcionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(828, 413);
            this.Controls.Add(this.btn_VerVentas);
            this.Controls.Add(this.btn_VerClientes);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_verProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpcionesAdmin";
            this.Text = "OpcionesAdmin";
            this.Load += new System.EventHandler(this.OpcionesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_atras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_verProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_atras;
        private System.Windows.Forms.Button btn_VerClientes;
        private System.Windows.Forms.Button btn_VerVentas;
    }
}