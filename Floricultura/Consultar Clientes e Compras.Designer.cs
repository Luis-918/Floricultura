namespace Floricultura
{
    partial class Consultar_Clientes_e_Compras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // título_cadastro
            // 
            this.título_cadastro.AutoSize = true;
            this.título_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.título_cadastro.Location = new System.Drawing.Point(295, 35);
            this.título_cadastro.Name = "título_cadastro";
            this.título_cadastro.Size = new System.Drawing.Size(511, 35);
            this.título_cadastro.TabIndex = 6;
            this.título_cadastro.Text = "Tela de Consulta, Atualizar e Excluir";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1077, 463);
            this.dataGridView1.TabIndex = 7;
            // 
            // Consultar_Clientes_e_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 694);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.título_cadastro);
            this.MaximumSize = new System.Drawing.Size(1117, 733);
            this.MinimumSize = new System.Drawing.Size(1117, 733);
            this.Name = "Consultar_Clientes_e_Compras";
            this.Text = "Consultar Clientes e Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label título_cadastro;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}