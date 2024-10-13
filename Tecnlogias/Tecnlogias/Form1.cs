using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecnlogias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double potencia = 55;
        int porcentaje = 0;
        int pt = 100;

        private void Calcular_Click(object sender, EventArgs e)
        {
            // Verificamos si el campo de texto tiene un valor válido
            if (int.TryParse(capastxt.Text, out int cantidad))
            {
                StringBuilder resultadoPotencias = new StringBuilder();
                resultadoPotencias.AppendLine("Resultados de potencia por cada capa:");

                // Reiniciamos las variables para calcular correctamente en cada intento
                potencia = 55;
                porcentaje = 0;
                pt = 100;

                for (int i = 0; i < cantidad; i++)
                {
                    porcentaje = porcentaje + 10;
                    pt = pt - porcentaje;
                    potencia = (pt * potencia) / 100;

                    // Agregamos el resultado de la potencia en esta capa
                    resultadoPotencias.AppendLine($"Capa {i + 1}: Potencia = {potencia}");
                }

                // Mostramos todas las potencias resultantes por capa
                MessageBox.Show(resultadoPotencias.ToString(), "Resultados de Potencia");
                this.Close();
            }
            else
            {
                // Mostrar mensaje si el valor ingresado no es válido
                MessageBox.Show("Por favor, ingrese un valor numérico válido en la cantidad de capas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
