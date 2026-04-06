using SimuladorArquitecturaPC.Models;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorArquitecturaPC.Forms
{
    /// <summary>
    /// Formulario principal que simula el flujo de datos de un computador:
    /// Disco → RAM → CPU.
    /// Permite visualizar estados y comportamiento de cada componente.
    /// </summary>
    public partial class frmSimulador : Form
    {
        /// <summary>
        /// Instancia del modelo que representa el computador.
        /// Contiene la lógica de Disco, RAM y CPU.
        /// </summary>
        private Computador pc = new Computador();

        /// <summary>
        /// Constructor del formulario.
        /// Inicializa componentes y define estado inicial del sistema.
        /// </summary>
        public frmSimulador()
        {
            InitializeComponent();

            InicializarEstado();
        }

        /// <summary>
        /// Define el estado inicial de la CPU al arrancar la aplicación.
        /// </summary>
        private void InicializarEstado()
        {
            lblCPU.Text = "Inactiva";
            lblCPU.BackColor = Color.LightCoral; // 🔴 CPU apagada/inactiva
        }

        /// <summary>
        /// Evento: Guarda datos en el disco.
        /// Simula almacenamiento persistente.
        /// </summary>
        private void btnGuardarDisco_Click(object sender, EventArgs e)
        {
            pc.Disco = txtDisco.Text;

            txtDisco.BackColor = Color.LightGray; // 💾 Indica uso de disco

            listLog.Items.Add("💾 Datos guardados en DISCO");
        }

        /// <summary>
        /// Evento: Carga datos desde el disco a la RAM.
        /// Simula transferencia de datos para ejecución.
        /// </summary>
        private void btnCargarRAM_Click(object sender, EventArgs e)
        {
            string mensaje = pc.CargarARam();

            txtRAM.Text = pc.RAM;
            txtRAM.BackColor = Color.LightBlue; // 🧠 RAM activa

            listLog.Items.Add(mensaje);
        }

        /// <summary>
        /// Evento: Ejecuta el procesamiento en CPU.
        /// Incluye validación, simulación de tiempo y cambio de estados visuales.
        /// </summary>
        private async void btnEjecutarCPU_Click(object sender, EventArgs e)
        {
            // Validación: la CPU no puede procesar sin datos en RAM
            if (string.IsNullOrEmpty(pc.RAM))
            {
                lblCPU.Text = "Error";
                lblCPU.BackColor = Color.Red;

                listLog.Items.Add("❌ No hay datos en RAM");
                return;
            }

            // Estado: CPU en procesamiento
            lblCPU.Text = "Procesando...";
            lblCPU.BackColor = Color.Yellow;

            await Task.Delay(1000); // Simulación de tiempo de ejecución

            // Procesamiento lógico
            string resultado = pc.Procesar();
            listLog.Items.Add(resultado);

            // Estado final: CPU terminó
            lblCPU.Text = "Listo";
            lblCPU.BackColor = Color.LightGreen;

            listLog.Items.Add("🟢 CPU finalizó el proceso");
        }

        /// <summary>
        /// Evento: Limpia todos los datos del sistema.
        /// Reinicia el estado del computador.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDisco.Clear();
            txtRAM.Clear();
            listLog.Items.Clear();

            pc = new Computador(); // Reinicio del modelo

            InicializarEstado(); // 🔴 Reinicia estado visual
        }
    }
}