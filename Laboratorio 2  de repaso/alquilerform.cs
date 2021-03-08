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
        public alquilerform()
        {
            InitializeComponent();
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

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
            dataGridView1.Refresh();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = vehiculos;
            dataGridView2.Refresh();

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = alquilados;
            dataGridView3.Refresh();

        }

        void encontrarmayor()
        {
            Alquiler tempalquilados = new Alquiler();


            (alquilados = alquilados.OrderByDescending(p => p.Total).ToList()).ToString();
            comboBox3.ValueMember = "Total";
            comboBox3.DataSource = null;
            comboBox3.DataSource = alquilados;
            comboBox3.Refresh();

        }
        void limpiar()
        {
            comboBox1.Text = null;
            comboBox2.Text = null;
            textBox1.Text = null;
            comboBox1.Refresh();
            comboBox2.Refresh();
        }
        private void alquilerform_Load(object sender, EventArgs e)
        {
            Alquiler alquiladotemp = new Alquiler();
            alquiladotemp.Nombre = comboBox1.SelectedValue.ToString();
            comboBox2.ValueMember = "Placa";
            comboBox2.DataSource = vehiculos;
            alquiladotemp.Placa = comboBox2.SelectedValue.ToString();

            comboBox2.ValueMember = "Marca";
            comboBox2.DataSource = vehiculos;
            alquiladotemp.Marca = comboBox2.SelectedValue.ToString();


            comboBox2.ValueMember = "Modelo";
            comboBox2.DataSource = vehiculos;
            alquiladotemp.Modelo = comboBox2.SelectedValue.ToString();

            comboBox2.ValueMember = "Color";
            comboBox2.DataSource = vehiculos;
            alquiladotemp.Color = comboBox2.SelectedValue.ToString();

            comboBox2.ValueMember = "Precio_kilometro";
            comboBox2.DataSource = vehiculos;
            alquiladotemp.Precio_kilometro = Convert.ToInt32(comboBox2.SelectedValue);

            alquiladotemp.Fechad = Convert.ToDateTime(dateTimePicker2.Text);

            comboBox2.ValueMember = "Precio_kilometro";
            comboBox2.DataSource = vehiculos;
            int kilometro = Convert.ToInt32(comboBox2.SelectedValue);
            int kmrecorrido = Convert.ToInt32(textBox1.Text);
            alquiladotemp.Total = (kilometro * kmrecorrido);




            alquilados.Add(alquiladotemp);
            guardar();

            limpiar();
            mostrar();
            MessageBox.Show("Vehiculo agregado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu vmenu = new Menu();
            vmenu.Show();
            this.SetVisibleCore(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alquiler tempalquilados = new Alquiler();
            tempalquilados.Nombre = comboBox1.SelectedValue.ToString();
            comboBox2.ValueMember = "Placa";
            comboBox2.DataSource = vehiculos;
            tempalquilados.Placa = comboBox2.SelectedValue.ToString();

            comboBox2.ValueMember = "Marca";
            comboBox2.DataSource = vehiculos;
            tempalquilados.Marca = comboBox2.SelectedValue.ToString();


            comboBox2.ValueMember = "Modelo";
            comboBox2.DataSource = vehiculos;
            tempalquilados.Modelo = comboBox2.SelectedValue.ToString();

            comboBox2.ValueMember = "Color";
            comboBox2.DataSource = vehiculos;
            tempalquilados.Color = comboBox2.SelectedValue.ToString();

            comboBox2.ValueMember = "Precio_kilometro";
            comboBox2.DataSource = vehiculos;
            tempalquilados.Precio_kilometro = Convert.ToInt32(comboBox2.SelectedValue);

            tempalquilados.Fechad = Convert.ToDateTime(dateTimePicker2.Text);

            comboBox2.ValueMember = "Precio_kilometro";
            comboBox2.DataSource = vehiculos;
            int kilometro = Convert.ToInt32(comboBox2.SelectedValue);
            int kmrecorrido = Convert.ToInt32(textBox1.Text);
            tempalquilados.Total = (kilometro * kmrecorrido);




            alquilados.Add(tempalquilados);
            guardar();

            limpiar();
            mostrar();
            MessageBox.Show("Vehiculo agregado correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            textBox1.Enabled = true;

            comboBox1.DisplayMember = "Nit";
            comboBox1.ValueMember = "Nombre";
            comboBox1.DataSource = null;
            comboBox1.DataSource = clientes;
            comboBox1.Refresh();

            comboBox2.DisplayMember = "Placa";
            comboBox2.DataSource = null;
            comboBox2.DataSource = vehiculos;
            comboBox2.Refresh();
            button3.Visible = false;
        }
    }
}
