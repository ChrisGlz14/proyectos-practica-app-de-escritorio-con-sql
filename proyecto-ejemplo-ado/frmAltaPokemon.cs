using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace proyecto_ejemplo_ado
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon nuevoPoke = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                nuevoPoke.Numero = int.Parse(txtNumero.Text);
                nuevoPoke.Nombre = txtNombre.Text;
                nuevoPoke.Biografia = txtDescripcion.Text;

                negocio.agregar(nuevoPoke);

                MessageBox.Show("Agregado exitosamente...");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
