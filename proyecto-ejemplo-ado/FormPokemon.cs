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
    public partial class FormPokemon : Form
    {
        private List<Pokemon> listaPokemon;
        public FormPokemon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.PokemonList(); // Aquí obtienes la lista correctamente.

            if (listaPokemon != null && listaPokemon.Count > 0)
            {
                dgbPokemons.DataSource = listaPokemon;
                dgbPokemons.Columns["Imagen"].Visible = false;
                PB_imgPokemon.Load(listaPokemon[0].Imagen);
            }
            else
            {
                MessageBox.Show("No se encontraron Pokémon.");
            }
        }


        private void SelectionChangePokemon(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgbPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                PB_imgPokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                PB_imgPokemon.Load("https://pics.filmaffinity.com/Rango-490328693-large.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
        }
    }
}
