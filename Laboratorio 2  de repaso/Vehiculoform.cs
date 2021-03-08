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
        void leer_datos(string archivo2)
        {
            FileStream stream = new FileStream(archivo2, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Vehiculos vehiculostemp = new Vehiculos();
                vehiculostemp.Placa = reader.ReadLine();
                vehiculostemp.Marca = reader.ReadLine();
                vehiculostemp.Modelo = reader.ReadLine();
                vehiculostemp.Color = reader.ReadLine();
                vehiculostemp.Precio_kilometro = float.Parse(reader.ReadLine());
                vehiculos.Add(vehiculostemp);

            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }
        void limpiar()
        {
            textBox_placa.Text = "";
            textBox_marca.Text = "";
            textBox_modelo.Text = "";
            comboBox1.Text = "";
            textBox_precio.Text = "";
        }
        private int verificar_repeticion(string placa) // retorna 1 si se encuentra en la lista
        {
            int resultado = 0;
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].Placa.Contains(placa))
                    resultado = 1;
            }
            return resultado;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

                Vehiculos tempvehiculo = new Vehiculos();
                tempvehiculo.Placa = textBox_placa.Text;
                tempvehiculo.Marca = textBox_marca.Text;
                tempvehiculo.Modelo = textBox_modelo.Text;
                tempvehiculo.Color = comboBox1.Text;
                tempvehiculo.Precio_kilometro = float.Parse(textBox_precio.Text);

                if (verificar_repeticion(textBox_placa.Text) != 1)
                {
                    vehiculos.Add(tempvehiculo);
                    guardar("vehiculos.txt");
                    limpiar();
                    MessageBox.Show("Vehiculo agregado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pueden agregar vehiculos repetidos en la base de datos");
                }

            }

        private void Vehiculoform_Load(object sender, EventArgs e)
        {
            leer_datos("vehiculos.txt");
        }
    }
}
