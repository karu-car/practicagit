using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2_3Entornos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            {
                string textoTelegrama;
                char tipoTelegrama = ' ';
                int numPalabras = 0;
                double coste;

                //Leo el telegrama
                textoTelegrama = txtTelegrama.Text.Trim(); //.Trim() para quitar espacios extra

                // --- Lógica de tipoTelegrama ---
                if (chkUrgente.Checked)
                {
                    tipoTelegrama = 'u';
                }
                else
                {
                    tipoTelegrama = 'o';
                }

                // --- Conteo de palabras ---
                // (Añado comprobación por si el texto está vacío)
                if (textoTelegrama == "")
                {
                    numPalabras = 0;
                }
                else
                {
                    string[] palabras = textoTelegrama.Split(' ');
                    numPalabras = palabras.Length;
                }

                //Si el telegrama es ordinario
                if (tipoTelegrama == 'o')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 2.5;
                    }
                    else
                    {
                        // --- Fórmula ordinario ---
                        coste = 2.5 + 0.5 * (numPalabras - 10);
                    }
                }
                else
                //Si el telegrama es urgente (tipoTelegrama == 'u')
                {
                    // (El bloque 'else' anidado para coste=0 era redundante)
                    if (tipoTelegrama == 'u')
                    {
                        if (numPalabras <= 10)
                        {
                            coste = 5;
                        }
                        else
                        {
                            coste = 5 + 0.75 * (numPalabras - 10);
                        }
                    }
                    else
                    {
                        coste = 0;
                    }
                }

                // txtPrecio.Text = coste.ToString() + " euros";
                // (Mejora opcional: Formatear a 2 decimales)
                txtPrecio.Text = coste.ToString("0.00") + " euros";
            }
        }
    }
}
