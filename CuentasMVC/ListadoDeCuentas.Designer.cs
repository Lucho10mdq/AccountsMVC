namespace CuentasMVC
{
    partial class ListadoDeCuentas
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
            this.lblListado = new System.Windows.Forms.Label();
            this.dtgListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(132, 36);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(165, 20);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Listado de Cuentas";
            // 
            // dtgListado
            // 
            this.dtgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListado.Location = new System.Drawing.Point(12, 78);
            this.dtgListado.Name = "dtgListado";
            this.dtgListado.Size = new System.Drawing.Size(424, 150);
            this.dtgListado.TabIndex = 1;
            // 
            // ListadoDeCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.dtgListado);
            this.Controls.Add(this.lblListado);
            this.Name = "ListadoDeCuentas";
            this.Text = "ListadoDeCuentas";
            this.Load += new System.EventHandler(this.ListadoDeCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.DataGridView dtgListado;
    }
}