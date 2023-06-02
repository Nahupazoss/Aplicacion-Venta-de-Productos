
namespace ExamenTacticasoft
{
    partial class FormAgregarProductocs
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarProductocs));
            this.txt_nombrePRD = new System.Windows.Forms.TextBox();
            this.txt_PrecioPRD = new System.Windows.Forms.TextBox();
            this.txt_CategoriaPRD = new System.Windows.Forms.TextBox();
            this.btn_AgregarPRD = new System.Windows.Forms.PictureBox();
            this.btn_Atras = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarPRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(12, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(219, 23);
            label1.TabIndex = 4;
            label1.Text = "AGREGAR PRODUCTO";
            // 
            // txt_nombrePRD
            // 
            this.txt_nombrePRD.Location = new System.Drawing.Point(71, 123);
            this.txt_nombrePRD.Name = "txt_nombrePRD";
            this.txt_nombrePRD.PlaceholderText = "NOMBRE ";
            this.txt_nombrePRD.Size = new System.Drawing.Size(263, 23);
            this.txt_nombrePRD.TabIndex = 0;
            // 
            // txt_PrecioPRD
            // 
            this.txt_PrecioPRD.Location = new System.Drawing.Point(71, 209);
            this.txt_PrecioPRD.Name = "txt_PrecioPRD";
            this.txt_PrecioPRD.PlaceholderText = "PRECIO ";
            this.txt_PrecioPRD.Size = new System.Drawing.Size(263, 23);
            this.txt_PrecioPRD.TabIndex = 1;
            // 
            // txt_CategoriaPRD
            // 
            this.txt_CategoriaPRD.Location = new System.Drawing.Point(71, 291);
            this.txt_CategoriaPRD.Name = "txt_CategoriaPRD";
            this.txt_CategoriaPRD.PlaceholderText = "CATEGORIA";
            this.txt_CategoriaPRD.Size = new System.Drawing.Size(263, 23);
            this.txt_CategoriaPRD.TabIndex = 2;
            // 
            // btn_AgregarPRD
            // 
            this.btn_AgregarPRD.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarPRD.Image")));
            this.btn_AgregarPRD.Location = new System.Drawing.Point(147, 379);
            this.btn_AgregarPRD.Name = "btn_AgregarPRD";
            this.btn_AgregarPRD.Size = new System.Drawing.Size(119, 137);
            this.btn_AgregarPRD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AgregarPRD.TabIndex = 3;
            this.btn_AgregarPRD.TabStop = false;
            this.btn_AgregarPRD.Click += new System.EventHandler(this.btn_AgregarPRD_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_Atras.Image")));
            this.btn_Atras.Location = new System.Drawing.Point(343, 1);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(79, 61);
            this.btn_Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Atras.TabIndex = 5;
            this.btn_Atras.TabStop = false;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // FormAgregarProductocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(422, 557);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(label1);
            this.Controls.Add(this.btn_AgregarPRD);
            this.Controls.Add(this.txt_CategoriaPRD);
            this.Controls.Add(this.txt_PrecioPRD);
            this.Controls.Add(this.txt_nombrePRD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregarProductocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarProductocs";
            this.Load += new System.EventHandler(this.FormAgregarProductocs_Load);
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
    }
}