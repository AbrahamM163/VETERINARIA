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
    public partial class Form5 : Form
    {

        private Mascota[] mascotas;
        public Form5(Mascota[] mascotas)
        {
            InitializeComponent();
            this.mascotas = mascotas;
        }

        // Este método ordenará las mascotas por edad
        private void OrdenarMascotasPorEdad()
        {
            // Ordenamos el arreglo utilizando el algoritmo de burbuja
            for (int i = 0; i < mascotas.Length - 1; i++)
            {
                for (int j = 0; j < mascotas.Length - 1 - i; j++)
                {
                    // Asegurarnos de que los elementos no sean null
                    if (mascotas[j] != null && mascotas[j + 1] != null)
                    {
                        // Comparar solo si ambos objetos son válidos
                        if (mascotas[j].Edad > mascotas[j + 1].Edad)
                        {
                            // Intercambiamos las mascotas
                            Mascota temp = mascotas[j];
                            mascotas[j] = mascotas[j + 1];
                            mascotas[j + 1] = temp;
                        }
                    }
                }
            }
        }

        // Método para cargar los datos al DataGridView
        private void CargarDatosEnDataGridView()
        {
            // Limpiar resultados anteriores
            dataGridView1.Rows.Clear();

            // Agregar las mascotas ordenadas al DataGridView
            foreach (var mascota in mascotas)
            {
                if (mascota != null) // Asegúrate de que no esté vacía
                {
                    dataGridView1.Rows.Add(mascota.Edad, mascota.Nombre, mascota.Tipo, mascota.Peso);
                }
            }
        }




        // Este es el botón que ordena y muestra los resultados
        private void button1_Click(object sender, EventArgs e)
        {
            OrdenarMascotasPorEdad();
            CargarDatosEnDataGridView();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Edad", "Edad");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Peso", "Peso");
        }


    }

}

