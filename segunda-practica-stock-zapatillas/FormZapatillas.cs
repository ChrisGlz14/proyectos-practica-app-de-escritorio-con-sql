using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segunda_practica_stock_zapatillas
{
    public partial class FormZapatillas : Form
    {
        public FormZapatillas()
        {
            InitializeComponent();
        }

        private void FormZapatillas_Load(object sender, EventArgs e)
        {
            ZapatillasStore store = new ZapatillasStore(); //Creamos una nueva instancia de nuestro store
            dgv_DatosZapatillas.DataSource = store.listar(); //A la grilla de datos le asignamos el store con los datos e invocamos la funcion listar.
        }
    }
}
