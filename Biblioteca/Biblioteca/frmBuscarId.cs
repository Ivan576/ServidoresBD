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
    public partial class frmBuscarId : Form
    {
        public frmBuscarId()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            DaoVer nuevoId = new DaoVer();
            nuevoId.MmostrarLibros();
        }
    }
}
