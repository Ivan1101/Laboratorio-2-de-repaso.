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
    public partial class alquilerform : Form
    {
        List<Clientes> clientes = new List<Clientes>();
        string archivo1 = "clientes.txt";
        List<Vehiculos> vehiculos = new List<Vehiculos>();
        string archivo2 = "vehiculos.txt";
        List<Alquiler> alquilados = new List<Alquiler>();
        string archivo4 = "alquilados.txt";
        public void bloqueo_principal()
        {
            comboBox_dpi.Enabled = false;
            comboBox_placa.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            textBox1.Enabled = false;
            button3.Visible = true;
        }
        public alquilerform()
        {
            InitializeComponent();
            bloqueo_principal();
        }
        void leer_datos()
        {
            FileStream stream = new FileStream(archivo1, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Clientes cliente_temp = new Clientes();
                cliente_temp.Nit = reader.ReadLine();
                cliente_temp.Nombre = reader.ReadLine();
                cliente_temp.Dirección = reader.ReadLine();
                clientes.Add(cliente_temp);
            }
            reader.Close();


            FileStream stream2 = new FileStream(archivo2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);
            while (reader2.Peek() > -1)
            {
                Vehiculos vehiculostemp = new Vehiculos();
                vehiculostemp.Placa = reader2.ReadLine();
                vehiculostemp.Marca = reader2.ReadLine();
                vehiculostemp.Modelo = reader2.ReadLine();
                vehiculostemp.Color = reader2.ReadLine();
                vehiculostemp.Precio_kilometro = float.Parse(reader2.ReadLine());
                vehiculos.Add(vehiculostemp);
            }
            reader2.Close();

            FileStream stream4 = new FileStream(archivo4, FileMode.Open, FileAccess.Read);
            StreamReader reader4 = new StreamReader(stream4);
            while (reader4.Peek() > -1)
            {
                Alquiler alquiladotemp = new Alquiler();
                alquiladotemp.Nombre = reader4.ReadLine();
                alquiladotemp.Placa = reader4.ReadLine();
                alquiladotemp.Marca = reader4.ReadLine();
                alquiladotemp.Modelo = reader4.ReadLine();
                alquiladotemp.Color = reader4.ReadLine();
                alquiladotemp.Precio_kilometro = float.Parse(reader4.ReadLine());
                alquiladotemp.Fechad = Convert.ToDateTime(reader4.ReadLine());
                alquiladotemp.Total = float.Parse(reader4.ReadLine());
                alquilados.Add(alquiladotemp);

            }
            reader4.Close();
        }
        public void guardar()
        {
            FileStream stream2 = new FileStream(archivo4, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer2 = new StreamWriter(stream2);

            for (int i = 0; i < alquilados.Count; i++)
            {
                writer2.WriteLine(alquilados[i].Nombre);
                writer2.WriteLine(alquilados[i].Placa);
                writer2.WriteLine(alquilados[i].Marca);
                writer2.WriteLine(alquilados[i].Modelo);
                writer2.WriteLine(alquilados[i].Color);
                writer2.WriteLine(alquilados[i].Precio_kilometro);
                writer2.WriteLine(alquilados[i].Fechad);
                writer2.WriteLine(alquilados[i].Total);
            }
            writer2.Close();
        }

        void mostrar()
        {

            dataGridView_clientes.DataSource = null;
            dataGridView_clientes.DataSource = clientes;
            dataGridView_clientes.Refresh();

            dataGridView_vehiculos.DataSource = null;
            dataGridView_vehiculos.DataSource = vehiculos;
            dataGridView_vehiculos.Refresh();

            dataGridView_alquilados.DataSource = null;
            dataGridView_alquilados.DataSource = alquilados;
            dataGridView_alquilados.Refresh();

        }

        void buscarmayor()
        {


            (alquilados = alquilados.OrderByDescending(p => p.Total).ToList()).ToString();
            comboBox_recorridos.ValueMember = "Total";
            comboBox_recorridos.DataSource = null;
            comboBox_recorridos.DataSource = alquilados;
            comboBox_recorridos.Refresh();

        }
        void limpiar()
        {
            comboBox_dpi.Text = "";
            comboBox_placa.Text = "";
            textBox1.Text = "";
            comboBox_dpi.Refresh();
            comboBox_placa.Refresh();
        }
        private void alquilerform_Load(object sender, EventArgs e)
        {

            leer_datos();
            mostrar();
            buscarmayor();
            label10.Text = "Q " + comboBox_recorridos.Text;
            comboBox_dpi.Refresh();
            comboBox_placa.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu v1 = new Menu();
            v1.Show();
            this.SetVisibleCore(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alquiler alquiladotemp = new Alquiler();
            alquiladotemp.Nombre = comboBox_dpi.SelectedValue.ToString();
            comboBox_placa.ValueMember = "Placa";
            comboBox_placa.DataSource = vehiculos;
            alquiladotemp.Placa = comboBox_placa.SelectedValue.ToString();

            comboBox_placa.ValueMember = "Marca";
            comboBox_placa.DataSource = vehiculos;
            alquiladotemp.Marca = comboBox_placa.SelectedValue.ToString();


            comboBox_placa.ValueMember = "Modelo";
            comboBox_placa.DataSource = vehiculos;
            alquiladotemp.Modelo = comboBox_placa.SelectedValue.ToString();

            comboBox_placa.ValueMember = "Color";
            comboBox_placa.DataSource = vehiculos;
            alquiladotemp.Color = comboBox_placa.SelectedValue.ToString();

            comboBox_placa.ValueMember = "Precio_kilometro";
            comboBox_placa.DataSource = vehiculos;
            alquiladotemp.Precio_kilometro = Convert.ToInt32(comboBox_placa.SelectedValue);

            alquiladotemp.Fechad = Convert.ToDateTime(dateTimePicker2.Text);

            comboBox_placa.ValueMember = "Precio_kilometro";
            comboBox_placa.DataSource = vehiculos;
            int kilometro = Convert.ToInt32(comboBox_placa.SelectedValue);
            int kmrecorrido = Convert.ToInt32(textBox1.Text);
            alquiladotemp.Total = (kilometro * kmrecorrido);


            alquilados.Add(alquiladotemp);
            guardar();
            limpiar();
            mostrar();
            MessageBox.Show("Vehiculo alquilado correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox_dpi.Enabled = true;
            comboBox_placa.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            textBox1.Enabled = true;

            comboBox_dpi.DisplayMember = "Nit";
            comboBox_dpi.ValueMember = "Nombre";
            comboBox_dpi.DataSource = null;
            comboBox_dpi.DataSource = clientes;
            comboBox_dpi.Refresh();

            comboBox_placa.DisplayMember = "Placa";
            comboBox_placa.DataSource = null;
            comboBox_placa.DataSource = vehiculos;
            comboBox_placa.Refresh();
            button3.Visible = false;
        }
    }
}
