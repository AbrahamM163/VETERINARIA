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

namespace VETERINARIA
{
    public partial class Form1 : Form
    {
        public Mascota[] mascotas = new Mascota[10]; // Puedes ajustar el tamaño
        public int contador = 0;
        public Form1(Mascota[] mascotasCompartidas, int contadorInicial)
        {
            InitializeComponent();
            this.mascotas = mascotasCompartidas;
            this.contador = contadorInicial;
        }

        //Registro de mascotas

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador >= mascotas.Length)
            {
                MessageBox.Show("Límite de mascotas alcanzado.");
                return;
            }

            // Validar que la edad sea un número entero válido
            if (!int.TryParse(textBox1.Text, out int edad))
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido para la edad.");
                textBox1.Focus();
                return;
            }

            // Validar que el peso sea un número decimal válido
            if (!double.TryParse(textBox4.Text, out double peso))
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido para el peso.");
                textBox4.Focus();
                return;
            }


            // Crear mascota desde los TextBox
            Mascota nueva = new Mascota
            {
                Nombre = textBox3.Text,
                Tipo = textBox2.Text,
                Edad = int.Parse(textBox1.Text),
                Peso = double.Parse(textBox4.Text)

            };

            mascotas[contador] = nueva;
            contador++;

            dataGridView1.Rows.Add(nueva.Nombre, nueva.Tipo, nueva.Edad, nueva.Peso);

            // Limpiar campos
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Focus();
        }

        public int ObtenerContador() // Para devolver el contador actualizado al menú
        {
            return contador;
        }

        private void ExportarDatosAArchivoTxt()
        {
            // Definir la ruta donde se guardará el archivo .txt
            string filePath = "mascotas_registradas.txt";
            string currentDirectory = Directory.GetCurrentDirectory();
            MessageBox.Show($"El archivo se guardará en: {currentDirectory}\\{filePath}");

            // Usamos StreamWriter para escribir en el archivo
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                
                writer.WriteLine("Nombre\tTipo\tEdad\tPeso");

                // Recorrer el arreglo de mascotas y escribir sus datos en el archivo
                for (int i = 0; i < contador; i++)
                {
                    // Asegurarse de que la mascota no sea null
                    if (mascotas[i] != null)
                    {
                        // Escribir los datos de la mascota separados por tabuladores
                        writer.WriteLine($"{mascotas[i].Nombre}\t{mascotas[i].Tipo}\t{mascotas[i].Edad}\t{mascotas[i].Peso}");
                    }
                }
            }

            // Notificar al usuario que los datos fueron exportados con éxito
            MessageBox.Show("Los datos han sido exportados exitosamente en el archivo 'mascotas_registradas.txt'.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportarDatosAArchivoTxt();
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


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}




