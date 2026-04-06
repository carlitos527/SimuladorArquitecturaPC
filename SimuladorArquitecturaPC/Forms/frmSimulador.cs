using SimuladorArquitecturaPC.Models;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorArquitecturaPC.Forms
{
    public partial class frmSimulador : Form
    {
        private Computador pc = new Computador();

        public frmSimulador()
        {
            InitializeComponent();
            InicializarEstado();
        }

        private void InicializarEstado()
        {
            lblCPU.Text = "Inactiva";
            lblCPU.BackColor = Color.LightCoral;
            txtDisco.BackColor = Color.White;
            txtRAM.BackColor = Color.White;
        }

        /// <summary>
        /// Guarda datos en el disco y registra en log interno.
        /// </summary>
        private void btnGuardarDisco_Click(object sender, EventArgs e)
        {
            pc.GuardarEnDisco(txtDisco.Text);

            txtDisco.BackColor = Color.LightGray;
            ActualizarLog();
        }

        /// <summary>
        /// Carga datos desde Disco a RAM y actualiza UI.
        /// </summary>
        private void btnCargarRAM_Click(object sender, EventArgs e)
        {
            string mensaje = pc.CargarARam();
            txtRAM.Text = pc.RAM;
            txtRAM.BackColor = Color.LightBlue;

            ActualizarLog();
        }

        /// <summary>
        /// Ejecuta procesamiento paso a paso en CPU y actualiza estado visual.
        /// </summary>
        private async void btnEjecutarCPU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pc.RAM))
            {
                pc.Estado = Computador.EstadoCPU.Error;
                ActualizarCPUEstado();
                pc.Log.Add("❌ No hay datos en RAM");
                ActualizarLog();
                return;
            }

            pc.Estado = Computador.EstadoCPU.Procesando;
            ActualizarCPUEstado();

            string procesado = "";

            // Procesamiento paso a paso visual
            foreach (char c in pc.RAM)
            {
                procesado += char.ToUpper(c); // convierte a mayúscula
                txtRAM.Text = procesado;      // actualiza la RAM en pantalla
                await Task.Delay(100);        // retraso para ver el flujo
            }

            pc.RAM = procesado;
            pc.Estado = Computador.EstadoCPU.Listo;
            pc.Log.Add($"⚙️ CPU procesó datos → {pc.RAM}");

            ActualizarCPUEstado();
            ActualizarLog();
        }
        /// <summary>
        /// Reinicia el computador y la interfaz.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pc.Reiniciar();

            txtDisco.Clear();
            txtRAM.Clear();
            listLog.Items.Clear();

            InicializarEstado();
            ActualizarLog();
        }

        /// <summary>
        /// Actualiza la interfaz de CPU según el estado del modelo.
        /// </summary>
        private void ActualizarCPUEstado()
        {
            switch (pc.Estado)
            {
                case Computador.EstadoCPU.Inactiva:
                    lblCPU.Text = "Inactiva";
                    lblCPU.BackColor = Color.LightCoral;
                    break;
                case Computador.EstadoCPU.Procesando:
                    lblCPU.Text = "Procesando...";
                    lblCPU.BackColor = Color.Yellow;
                    break;
                case Computador.EstadoCPU.Listo:
                    lblCPU.Text = "Listo";
                    lblCPU.BackColor = Color.LightGreen;
                    break;
                case Computador.EstadoCPU.Error:
                    lblCPU.Text = "Error";
                    lblCPU.BackColor = Color.Red;
                    break;
            }
        }

        /// <summary>
        /// Actualiza el log visual usando el log interno del modelo.
        /// </summary>
        private void ActualizarLog()
        {
            listLog.Items.Clear();
            foreach (string entry in pc.Log)
            {
                listLog.Items.Add(entry);
            }
        }
    }
}