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
    public partial class Form6 : Form
    {

        private Mascota[] mascotas;
        public Form6(Mascota[] mascotas)
        {
            InitializeComponent();
            this.mascotas = mascotas;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreBuscado = textBox1.Text.Trim().ToLower();
            bool mascotaEncontrada = false;

            // Buscar la mascota por nombre
            foreach (var mascota in mascotas)
            {
                if (mascota != null && mascota.Nombre.ToLower() == nombreBuscado)
                {
                    mascotaEncontrada = true;

                    // Diagnóstico basado en el peso
                    string diagnostico = ObtenerDiagnosticoPorPeso(mascota.Peso);

                    // Actualizar el label con el diagnóstico
                    label2.Text = $"Diagnóstico de {mascota.Nombre}: {diagnostico}";

                    // Actualizar el ProgressBar
                    MostrarGraficoPeso(mascota.Peso);

                    // Mostrar las recomendaciones según el diagnóstico
                    MostrarRecomendaciones(diagnostico);

                    break;
                }
            }



            if (!mascotaEncontrada)
            {
                MessageBox.Show("No se encontró una mascota con ese nombre.");
            }

        }

        // Método que realiza el diagnóstico por peso
        private string ObtenerDiagnosticoPorPeso(double peso)
        {
            if (peso < 5) // Peso bajo
            {
                return "Bajo peso";
            }
            else if (peso >= 5 && peso <= 15) // Peso adecuado
            {
                return "Peso adecuado";
            }
            else // Sobrepeso
            {
                return "Sobrepeso";
            }
        }

        // Método para mostrar el gráfico de progreso (ProgressBar)
        private void MostrarGraficoPeso(double peso)
        {
            // Establecer el rango del ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            // Calcular el valor del ProgressBar basado en el peso (ajustar rango según sea necesario)
            int progreso = (int)((peso / 30) * 100); // Suponiendo un rango de peso de 0 a 30
            progressBar1.Value = Math.Min(progreso, 100); // Evitar que el valor supere el máximo de 100
        }

        private void MostrarRecomendaciones(string diagnostico)
        {
            if (diagnostico == "Bajo peso")
            {
                label3.Text = "Recomendaciones: Aumentar la cantidad de comida y consultar con un veterinario.";
            }
            else if (diagnostico == "Peso adecuado")
            {
                label3.Text = "Recomendaciones: Mantener la dieta actual y realizar ejercicio regularmente.";
            }
            else if (diagnostico == "Sobrepeso")
            {
                label3.Text = "Recomendaciones: Reducir la cantidad de comida, aumentar el ejercicio y consultar con un veterinario.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}