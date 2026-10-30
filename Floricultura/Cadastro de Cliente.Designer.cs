namespace Floricultura
{
    partial class Cadastro_Cliente
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
            this.título_cadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // título_cadastro
            // 
            this.título_cadastro.AutoSize = true;
            this.título_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.título_cadastro.Location = new System.Drawing.Point(410, 52);
            this.título_cadastro.Name = "título_cadastro";
            this.título_cadastro.Size = new System.Drawing.Size(250, 35);
            this.título_cadastro.TabIndex = 5;
            this.título_cadastro.Text = "Tela de Cadastro";
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 694);
            this.Controls.Add(this.título_cadastro);
            this.MaximumSize = new System.Drawing.Size(1117, 733);
            this.MinimumSize = new System.Drawing.Size(1117, 733);
            this.Name = "Cadastro_Cliente";
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label título_cadastro;
    }
}