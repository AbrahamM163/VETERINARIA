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
    public partial class Form3 : Form
    {

        private Mascota[] mascotas;
        private int totalMascotas;
        public Form3(Mascota[] mascotasExternas , int cantidad)
        {
            InitializeComponent();
            this.mascotas = mascotasExternas;
            this.totalMascotas = cantidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double suma = 0;
            int contadorMascotas = 0;

            for (int i = 0; i < totalMascotas; i++)
            {
                if (mascotas[i] != null && mascotas[i].Peso > 0)
                {
                    suma += mascotas[i].Peso;
                    contadorMascotas++;
                }
            }

            if (contadorMascotas > 0)
            {
                double promedio = suma / contadorMascotas;
                label1.Text = $"Peso promedio: {promedio:F2} kg";
            }
            else
            {
                label1.Text = "No hay mascotas registradas.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
