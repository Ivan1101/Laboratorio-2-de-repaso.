using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2__de_repaso
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientesform Vclientes = new Clientesform();
            Vclientes.Show();
            this.SetVisibleCore(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehiculoform Vvehiculo = new Vehiculoform();
            Vvehiculo.Show();
            this.SetVisibleCore(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alquilerform valquier = new alquilerform();
            valquier.Show();
            this.SetVisibleCore(false);

        }
    }
}
