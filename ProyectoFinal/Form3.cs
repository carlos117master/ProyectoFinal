using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            MostrarUsuarios(dataGridView1);
        }
       //aqui crea una variable tipo DataTable y llama a la table de form2 luego el contenido que tiene lo vuelca en el dataGridView
        public static void MostrarUsuarios(DataGridView dataGridViewUsuarios)
        {
            DataTable dataTable = Form2.table;
            dataGridViewUsuarios.DataSource = dataTable;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
