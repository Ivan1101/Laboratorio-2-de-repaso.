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
    public partial class Vehiculoform : Form
    {
        List<Vehiculos> vehiculos = new List<Vehiculos>();
        public Vehiculoform()
        {
            InitializeComponent();
        }
        public void guardar(string archivo2)
        {
            FileStream stream = new FileStream(archivo2, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            for (int i = 0; i < vehiculos.Count; i++)
            {
                writer.WriteLine(vehiculos[i].Placa);
                writer.WriteLine(vehiculos[i].Marca);
                writer.WriteLine(vehiculos[i].Modelo);
                writer.WriteLine(vehiculos[i].Color);
                writer.WriteLine(vehiculos[i].Precio_kilometro);
            }
            writer.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
