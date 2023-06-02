
namespace ExamenTacticasoft
{
    partial class MenuCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCompra));
            this.dtgv_ProductosVenta = new System.Windows.Forms.DataGridView();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ProductosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ProductosVenta
            // 
            this.dtgv_ProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ProductosVenta.Location = new System.Drawing.Point(34, 69);
            this.dtgv_ProductosVenta.Name = "dtgv_ProductosVenta";
            this.dtgv_ProductosVenta.RowTemplate.Height = 25;
            this.dtgv_ProductosVenta.Size = new System.Drawing.Size(756, 471);
            this.dtgv_ProductosVenta.TabIndex = 0;
            // 
            // btn_pedido
            // 
            this.btn_pedido.Location = new System.Drawing.Point(856, 488);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(147, 52);
            this.btn_pedido.TabIndex = 1;
            this.btn_pedido.Text = "Realizar Pedido";
            this.btn_pedido.UseVisualStyleBackColor = true;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Productos Disponibles";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Atras.Image")));
            this.btn_Atras.Location = new System.Drawing.Point(966, 12);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(79, 61);
            this.btn_Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Atras.TabIndex = 7;
            this.btn_Atras.TabStop = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // MenuCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1057, 585);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pedido);
            this.Controls.Add(this.dtgv_ProductosVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuCompra";
            this.Text = "MenuCompra";
            this.Load += new System.EventHandler(this.MenuCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ProductosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ProductosVenta;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Atras;
    }
}