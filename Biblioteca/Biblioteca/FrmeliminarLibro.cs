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
    public partial class FrmeliminarLibro : Form
    {
        public FrmeliminarLibro()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsEliminar Elimina = new clsEliminar();
            Elimina.ID = Convert.ToInt32(txtEliminar.Text);

            DaoEliminar metodo = new DaoEliminar();
            if (metodo.MeliminarLibro(Elimina))
            {

                MessageBox.Show("Eliminado Correctamente");
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Algo salio mal");
            }
        }
    }
}
