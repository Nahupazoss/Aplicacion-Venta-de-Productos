
namespace ExamenTacticasoft
{
    partial class FormModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarProducto));
            this.txt_nombrePRD = new System.Windows.Forms.TextBox();
            this.txt_PrecioPRD = new System.Windows.Forms.TextBox();
            this.txt_CategoriaPRD = new System.Windows.Forms.TextBox();
            this.btn_AgregarPRD = new System.Windows.Forms.PictureBox();
            this.btn_Atras = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarPRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombrePRD
            // 
            this.txt_nombrePRD.Location = new System.Drawing.Point(54, 106);
            this.txt_nombrePRD.Name = "txt_nombrePRD";
            this.txt_nombrePRD.PlaceholderText = "NOMBRE ";
            this.txt_nombrePRD.Size = new System.Drawing.Size(263, 23);
            this.txt_nombrePRD.TabIndex = 1;
            // 
            // txt_PrecioPRD
            // 
            this.txt_PrecioPRD.Location = new System.Drawing.Point(54, 155);
            this.txt_PrecioPRD.Name = "txt_PrecioPRD";
            this.txt_PrecioPRD.PlaceholderText = "PRECIO ";
            this.txt_PrecioPRD.Size = new System.Drawing.Size(263, 23);
            this.txt_PrecioPRD.TabIndex = 2;
            // 
            // txt_CategoriaPRD
            // 
            this.txt_CategoriaPRD.Location = new System.Drawing.Point(54, 206);
            this.txt_CategoriaPRD.Name = "txt_CategoriaPRD";
            this.txt_CategoriaPRD.PlaceholderText = "CATEGORIA";
            this.txt_CategoriaPRD.Size = new System.Drawing.Size(263, 23);
            this.txt_CategoriaPRD.TabIndex = 3;
            // 
            // btn_AgregarPRD
            // 
            this.btn_AgregarPRD.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarPRD.Image")));
            this.btn_AgregarPRD.Location = new System.Drawing.Point(123, 307);
            this.btn_AgregarPRD.Name = "btn_AgregarPRD";
            this.btn_AgregarPRD.Size = new System.Drawing.Size(119, 97);
            this.btn_AgregarPRD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AgregarPRD.TabIndex = 4;
            this.btn_AgregarPRD.TabStop = false;
            this.btn_AgregarPRD.Click += new System.EventHandler(this.btn_AgregarPRD_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Atras.Image")));
            this.btn_Atras.Location = new System.Drawing.Point(293, 0);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(79, 61);
            this.btn_Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Atras.TabIndex = 6;
            this.btn_Atras.TabStop = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "MODIFICAR PRODUCTO";
            // 
            // FormModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(372, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_AgregarPRD);
            this.Controls.Add(this.txt_CategoriaPRD);
            this.Controls.Add(this.txt_PrecioPRD);
            this.Controls.Add(this.txt_nombrePRD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificarProducto";
            this.Load += new System.EventHandler(this.FormModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarPRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombrePRD;
        private System.Windows.Forms.TextBox txt_PrecioPRD;
        private System.Windows.Forms.TextBox txt_CategoriaPRD;
        private System.Windows.Forms.PictureBox btn_AgregarPRD;
        private System.Windows.Forms.PictureBox btn_Atras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}