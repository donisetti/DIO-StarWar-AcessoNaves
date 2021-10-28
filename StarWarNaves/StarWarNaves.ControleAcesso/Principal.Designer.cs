
namespace StarWarNaves.ControleAcesso
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSicronizar = new System.Windows.Forms.Button();
            this.btnControle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSicronizar
            // 
            this.btnSicronizar.Location = new System.Drawing.Point(9, 12);
            this.btnSicronizar.Name = "btnSicronizar";
            this.btnSicronizar.Size = new System.Drawing.Size(195, 105);
            this.btnSicronizar.TabIndex = 0;
            this.btnSicronizar.Text = "Sincronizar";
            this.btnSicronizar.UseVisualStyleBackColor = true;
            this.btnSicronizar.Click += new System.EventHandler(this.btnSicronizar_Click);
            // 
            // btnControle
            // 
            this.btnControle.Location = new System.Drawing.Point(225, 12);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(193, 105);
            this.btnControle.TabIndex = 1;
            this.btnControle.Text = "Controle";
            this.btnControle.UseVisualStyleBackColor = true;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 137);
            this.Controls.Add(this.btnControle);
            this.Controls.Add(this.btnSicronizar);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSicronizar;
        private System.Windows.Forms.Button btnControle;
    }
}

