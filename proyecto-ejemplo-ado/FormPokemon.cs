using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ConexionBD conexionBD = new ConexionBD(); //
            listaPokemon = conexionBD.PokemonList();
            dgbPokemons.DataSource = listaPokemon;
            dgbPokemons.Columns["Imagen"].Visible = false;
            PB_imgPokemon.Load(listaPokemon[0].Imagen);
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
    }
}
