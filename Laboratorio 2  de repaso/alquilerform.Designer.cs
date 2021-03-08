
namespace Laboratorio_2__de_repaso
{
    partial class alquilerform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_dpi = new System.Windows.Forms.ComboBox();
            this.comboBox_placa = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView_clientes = new System.Windows.Forms.DataGridView();
            this.dataGridView_vehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridView_alquilados = new System.Windows.Forms.DataGridView();
            this.comboBox_recorridos = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alquilados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLACA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE ALQUILER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DEVOLUCIÓN";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(137, 181);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // comboBox_dpi
            // 
            this.comboBox_dpi.FormattingEnabled = true;
            this.comboBox_dpi.Location = new System.Drawing.Point(147, 40);
            this.comboBox_dpi.Name = "comboBox_dpi";
            this.comboBox_dpi.Size = new System.Drawing.Size(190, 21);
            this.comboBox_dpi.TabIndex = 6;
            // 
            // comboBox_placa
            // 
            this.comboBox_placa.FormattingEnabled = true;
            this.comboBox_placa.Location = new System.Drawing.Point(147, 80);
            this.comboBox_placa.Name = "comboBox_placa";
            this.comboBox_placa.Size = new System.Drawing.Size(190, 21);
            this.comboBox_placa.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "KILÓMETROS RECORRIDOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView_clientes
            // 
            this.dataGridView_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientes.Location = new System.Drawing.Point(355, 40);
            this.dataGridView_clientes.Name = "dataGridView_clientes";
            this.dataGridView_clientes.Size = new System.Drawing.Size(258, 150);
            this.dataGridView_clientes.TabIndex = 12;
            // 
            // dataGridView_vehiculos
            // 
            this.dataGridView_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_vehiculos.Location = new System.Drawing.Point(619, 40);
            this.dataGridView_vehiculos.Name = "dataGridView_vehiculos";
            this.dataGridView_vehiculos.Size = new System.Drawing.Size(260, 150);
            this.dataGridView_vehiculos.TabIndex = 13;
            // 
            // dataGridView_alquilados
            // 
            this.dataGridView_alquilados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alquilados.Location = new System.Drawing.Point(355, 218);
            this.dataGridView_alquilados.Name = "dataGridView_alquilados";
            this.dataGridView_alquilados.Size = new System.Drawing.Size(311, 150);
            this.dataGridView_alquilados.TabIndex = 14;
            // 
            // comboBox_recorridos
            // 
            this.comboBox_recorridos.FormattingEnabled = true;
            this.comboBox_recorridos.Location = new System.Drawing.Point(137, 232);
            this.comboBox_recorridos.Name = "comboBox_recorridos";
            this.comboBox_recorridos.Size = new System.Drawing.Size(200, 21);
            this.comboBox_recorridos.TabIndex = 15;
            this.comboBox_recorridos.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 26);
            this.button3.TabIndex = 16;
            this.button3.Text = "Desbloqueo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "CLIENTES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "VEHÍCULOS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ALQUILADOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(681, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Alquiler con más kilometros";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(706, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
            // 
            // alquilerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 373);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox_recorridos);
            this.Controls.Add(this.dataGridView_alquilados);
            this.Controls.Add(this.dataGridView_vehiculos);
            this.Controls.Add(this.dataGridView_clientes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_placa);
            this.Controls.Add(this.comboBox_dpi);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "alquilerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alquilerform";
            this.Load += new System.EventHandler(this.alquilerform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alquilados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox_dpi;
        private System.Windows.Forms.ComboBox comboBox_placa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView_clientes;
        private System.Windows.Forms.DataGridView dataGridView_vehiculos;
        private System.Windows.Forms.DataGridView dataGridView_alquilados;
        private System.Windows.Forms.ComboBox comboBox_recorridos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}