
namespace ExamenTacticasoft
{
    partial class FormModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarCliente));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_atras = new System.Windows.Forms.PictureBox();
            this.btn_ModificarCliente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.AccessibleDescription = "";
            this.txt_nombre.AccessibleName = "";
            this.txt_nombre.Location = new System.Drawing.Point(60, 121);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "NOMBRE";
            this.txt_nombre.Size = new System.Drawing.Size(288, 23);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.Tag = "";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(60, 193);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PlaceholderText = "TELEFONO";
            this.txt_telefono.Size = new System.Drawing.Size(288, 23);
            this.txt_telefono.TabIndex = 3;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(60, 266);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PlaceholderText = "CORREO";
            this.txt_correo.Size = new System.Drawing.Size(288, 23);
            this.txt_correo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "MODIFICAR CLIENTE";
            // 
            // btn_atras
            // 
            this.btn_atras.Image = ((System.Drawing.Image)(resources.GetObject("btn_atras.Image")));
            this.btn_atras.Location = new System.Drawing.Point(310, -1);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(93, 59);
            this.btn_atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_atras.TabIndex = 7;
            this.btn_atras.TabStop = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_ModificarCliente
            // 
            this.btn_ModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModificarCliente.Image")));
            this.btn_ModificarCliente.Location = new System.Drawing.Point(152, 354);
            this.btn_ModificarCliente.Name = "btn_ModificarCliente";
            this.btn_ModificarCliente.Size = new System.Drawing.Size(119, 97);
            this.btn_ModificarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ModificarCliente.TabIndex = 8;
            this.btn_ModificarCliente.TabStop = false;
            this.btn_ModificarCliente.Click += new System.EventHandler(this.btn_ModificarCliente_Click);
            // 
            // FormModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(406, 530);
            this.Controls.Add(this.btn_ModificarCliente);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificarCliente";
            this.Text = "FormModificarCliente";
            this.Load += new System.EventHandler(this.FormModificarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_atras;
        private System.Windows.Forms.PictureBox btn_ModificarCliente;
    }
}