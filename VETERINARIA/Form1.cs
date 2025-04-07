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
    public partial class Form1 : Form
    {
        Mascota[] mascotas = new Mascota[10]; // Puedes ajustar el tamaño
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //Registro de mascotas

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador >= mascotas.Length)
            {
                MessageBox.Show("Límite de mascotas alcanzado.");
                return;
            }

            // Crear mascota desde los TextBox
            Mascota nueva = new Mascota
            {
                Nombre = textBox3.Text,
                Tipo = textBox2.Text,
                Edad = int.Parse(textBox1.Text)
            };

            mascotas[contador] = nueva;
            contador++;

            listBox1.Items.Add(nueva.ToString());

            // Limpiar campos
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Focus();
        }
    



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




