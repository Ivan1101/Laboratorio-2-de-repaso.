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
            tempalquilados.Color = comboBox2.SelectedValue.ToString();

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

        }
    }
}
