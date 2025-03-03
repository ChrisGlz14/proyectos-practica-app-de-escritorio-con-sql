namespace proyecto_ejemplo_ado
{
    partial class FormPokemon
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
            this.dgbPokemons = new System.Windows.Forms.DataGridView();
            this.PB_imgPokemon = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imgPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbPokemons
            // 
            this.dgbPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbPokemons.Location = new System.Drawing.Point(31, 106);
            this.dgbPokemons.Name = "dgbPokemons";
            this.dgbPokemons.Size = new System.Drawing.Size(432, 227);
            this.dgbPokemons.TabIndex = 0;
            this.dgbPokemons.SelectionChanged += new System.EventHandler(this.SelectionChangePokemon);
            // 
            // PB_imgPokemon
            // 
            this.PB_imgPokemon.Location = new System.Drawing.Point(469, 72);
            this.PB_imgPokemon.Name = "PB_imgPokemon";
            this.PB_imgPokemon.Size = new System.Drawing.Size(315, 261);
            this.PB_imgPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_imgPokemon.TabIndex = 1;
            this.PB_imgPokemon.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PB_imgPokemon);
            this.Controls.Add(this.dgbPokemons);
            this.Name = "FormPokemon";
            this.Text = "Pokedex App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imgPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbPokemons;
        private System.Windows.Forms.PictureBox PB_imgPokemon;
        private System.Windows.Forms.ImageList imageList1;
    }
}

