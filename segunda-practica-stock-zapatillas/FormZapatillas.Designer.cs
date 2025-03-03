namespace segunda_practica_stock_zapatillas
{
    partial class FormZapatillas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_DatosZapatillas = new System.Windows.Forms.DataGridView();
            this.PB_Zapatillas = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatosZapatillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Zapatillas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DatosZapatillas
            // 
            this.dgv_DatosZapatillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DatosZapatillas.Location = new System.Drawing.Point(31, 95);
            this.dgv_DatosZapatillas.Name = "dgv_DatosZapatillas";
            this.dgv_DatosZapatillas.Size = new System.Drawing.Size(525, 248);
            this.dgv_DatosZapatillas.TabIndex = 0;
            // 
            // PB_Zapatillas
            // 
            this.PB_Zapatillas.Location = new System.Drawing.Point(585, 95);
            this.PB_Zapatillas.Name = "PB_Zapatillas";
            this.PB_Zapatillas.Size = new System.Drawing.Size(203, 248);
            this.PB_Zapatillas.TabIndex = 1;
            this.PB_Zapatillas.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(338, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "STOCK DE ZAPATILLAS";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormZapatillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.PB_Zapatillas);
            this.Controls.Add(this.dgv_DatosZapatillas);
            this.Name = "FormZapatillas";
            this.Text = "Stock de zapatillas APP";
            this.Load += new System.EventHandler(this.FormZapatillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatosZapatillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Zapatillas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DatosZapatillas;
        private System.Windows.Forms.PictureBox PB_Zapatillas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

