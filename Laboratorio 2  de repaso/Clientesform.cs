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
    public partial class Clientesform : Form
    {  //Lista
        List<Clientes> clientes = new List<Clientes>();
        public Clientesform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu vmenu = new Menu();
            vmenu.Show();
            this.SetVisibleCore(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //declaramos un objeto cliente de la clase clientes
                Clientes tempcliente = new Clientes();
                tempcliente.Nit = textBox1.Text;
                tempcliente.Nombre = textBox2.Text;
                tempcliente.Dirección = textBox3.Text;
                //para asignarle los datos leidos del archivo
                clientes.Add(tempcliente);
                //luego guardar el tempcliente en la lista de clienters
                guardar();

                limpiar();
                MessageBox.Show("Cliente agregado correctamente");
            }
            catch (Exception)
            {
                // Condición para emitir si falta en llenar un campo
                MessageBox.Show("No se han llenado todos los datos", "Mi Mesaje Predeterminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
