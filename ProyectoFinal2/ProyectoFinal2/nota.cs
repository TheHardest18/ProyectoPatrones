using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2
{
    public partial class nota : Form
    {
        

        public int not;
        private nota()
        {
            InitializeComponent();
        }
        private static nota Instancia = null;
        public static nota getNota()
        {
            if (Instancia == null)
            {
                Instancia = new nota();
            }

            return Instancia;
        }

        private void nota1_Click(object sender, EventArgs e)
        {
            
        }

        private void nota_Load(object sender, EventArgs e)
        {

        }
    }
}
