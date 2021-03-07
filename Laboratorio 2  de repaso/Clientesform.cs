using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public void guardar(string archivo1)
        {
            FileStream stream = new FileStream(archivo1, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            for (int i = 0; i < clientes.Count; i++)
            {
                writer.WriteLine(clientes[i].Nit);
                writer.WriteLine(clientes[i].Nombre);
                writer.WriteLine(clientes[i].Dirección);
            }
            writer.Close();
        }
        void leer_datos(string archivo1)
        {
            FileStream stream = new FileStream(archivo1, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Clientes clientetemp = new Clientes();
                clientetemp.Nit = reader.ReadLine();
                clientetemp.Nombre = reader.ReadLine();
                clientetemp.Dirección = reader.ReadLine();
                clientes.Add(clientetemp);

            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }
        void limpiar()
        {
            textBox_nit.Text = "";
            textBox_nombre.Text = "";
            textBox_direccion.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Menu vmenu = new Menu();
            vmenu.Show();
            this.SetVisibleCore(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //declaramos un objeto cliente de la clase clientes
                Clientes clientetempo = new Clientes();
                clientetempo.Nit = textBox_nit.Text;
                clientetempo.Nombre = textBox_nombre.Text;
                clientetempo.Dirección = textBox_direccion.Text;
                clientes.Add(clientetempo);
                guardar("clientes.txt");
                limpiar();
                MessageBox.Show("Cliente agregado correctamente");
        
        }

        private void Clientesform_Load(object sender, EventArgs e)
        {
            leer_datos("clientes.txt");
        }
    }
}
