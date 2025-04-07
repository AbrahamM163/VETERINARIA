using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VETERINARIA
{
    public partial class Form4 : Form
    {

        private Mascota[] mascotas;

        public Form4(Mascota[] mascotas)
        {
            InitializeComponent();
            this.mascotas = mascotas;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Edad", "Edad");
            dataGridView1.Columns.Add("Peso", "Peso");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreBuscado = textBox1.Text.Trim().ToLower();

            // Limpiar resultados anteriores
            dataGridView1.Rows.Clear();

            bool encontrado = false;

            foreach (var m in mascotas)
            {
                if (m != null && m.Nombre.ToLower().Contains(nombreBuscado))
                {
                    dataGridView1.Rows.Add(m.Nombre, m.Tipo, m.Edad, m.Peso);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ninguna mascota con ese nombre.");
            }
        }

    }

      
    }

