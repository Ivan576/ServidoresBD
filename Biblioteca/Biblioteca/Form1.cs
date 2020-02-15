using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            clsAgregar agregaL = new clsAgregar();
            agregaL.ISBN = Convert.ToInt32(txtISBN.Text);
            agregaL.Titulo = txtTitulo.Text;
            agregaL.NumEdicion = Convert.ToInt32(txtNoEdicion.Text);
            agregaL.AñoP = Convert.ToInt32(txtAñoP.Text);
            agregaL.Autor = txtAutor.Text;
            agregaL.PaisP = txtPaisP.Text;
            agregaL.Sinopsis = txtSinopsis.Text;
            agregaL.Carrera = txtCarrera.Text;
            agregaL.Materia = txtMateria.Text;
            

            DaoAgregar metodo = new DaoAgregar();
            if (metodo.MAgregarlibro(agregaL))
            {

                MessageBox.Show("Agregado Correctamente");
            }
            else
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dtgLibros.DataSource = new DaoVer().MmostrarLibros();
        }

        private void btnEliminat_Click(object sender, EventArgs e)
        {
            FrmeliminarLibro ventana = new FrmeliminarLibro();
            ventana.Show();
        }
    }
}
