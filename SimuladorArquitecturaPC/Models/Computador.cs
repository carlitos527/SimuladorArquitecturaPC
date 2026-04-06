using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimuladorArquitecturaPC.Models
{
    /// <summary>
    /// Representa un computador de forma simplificada.
    /// Simula el flujo de datos entre Disco, RAM y CPU.
    /// Este modelo está orientado a enseñanza, no a comportamiento real de hardware.
    /// </summary>
    public class Computador
    {
        // -------------------------------
        // Propiedades principales
        // -------------------------------

        /// <summary>
        /// Simula el almacenamiento en disco duro.
        /// Guarda los datos de forma persistente.
        /// </summary>
        public string Disco { get; set; }

        /// <summary>
        /// Simula la memoria RAM.
        /// Aquí se cargan los datos temporalmente para ser procesados.
        /// </summary>
        public string RAM { get; set; }

        // -------------------------------
        // Historial
        // -------------------------------

        /// <summary>
        /// Historial de todos los valores guardados en Disco.
        /// </summary>
        public List<string> HistorialDisco { get; private set; } = new List<string>();

        /// <summary>
        /// Historial de todos los valores cargados en RAM.
        /// </summary>
        public List<string> HistorialRAM { get; private set; } = new List<string>();

        // -------------------------------
        // Log interno
        // -------------------------------

        /// <summary>
        /// Registro de eventos internos del computador.
        /// </summary>
        public List<string> Log { get; private set; } = new List<string>();

        // -------------------------------
        // Estado de CPU
        // -------------------------------

        public enum EstadoCPU { Inactiva, Procesando, Listo, Error }
        public EstadoCPU Estado { get;  set; } = EstadoCPU.Inactiva;

        // -------------------------------
        // Métodos
        // -------------------------------

        /// <summary>
        /// Guarda datos en el disco y registra el evento.
        /// </summary>
        public void GuardarEnDisco(string datos)
        {
            Disco = datos;
            HistorialDisco.Add(datos);

            // Agregar timestamp al log
            Log.Add($"[{DateTime.Now:HH:mm:ss}] 💾 Datos guardados en Disco → {datos}");
        }

        /// <summary>
        /// Transfiere datos desde Disco hacia RAM.
        /// </summary>
        /// <returns>Mensaje descriptivo del proceso</returns>
        public string CargarARam()
        {
            if (string.IsNullOrEmpty(Disco))
            {
                Estado = EstadoCPU.Error;
                Log.Add($"[{DateTime.Now:HH:mm:ss}] ❌ No hay datos en Disco");
                return "❌ No hay datos en Disco";
            }

            RAM = Disco;
            HistorialRAM.Add(RAM);
            Estado = EstadoCPU.Listo;

            Log.Add($"[{DateTime.Now:HH:mm:ss}] 📥 Datos cargados de Disco → RAM:  {RAM}");

            return "📥 Datos cargados de Disco → RAM:   {RAM}";
        }

        /// <summary>
        /// Simula el procesamiento de datos por parte de la CPU.
        /// Convierte los datos de RAM a mayúsculas paso a paso para simulación visual.
        /// </summary>
        /// <returns>Resultado procesado</returns>
        public async Task<string> ProcesarAsync()
        {
            if (string.IsNullOrEmpty(RAM))
            {
                Estado = EstadoCPU.Error;
                Log.Add($"[{DateTime.Now:HH:mm:ss}] ❌ No hay datos en RAM");
                return "❌ No hay datos en RAM";
            }

            Estado = EstadoCPU.Procesando;
            Log.Add($"[{DateTime.Now:HH:mm:ss}] ⚙️ CPU inició procesamiento");
            string resultado = "";

            // Simulación de procesamiento carácter por carácter
            foreach (char c in RAM)
            {
                resultado += char.ToUpper(c);
                await Task.Delay(50); // simula ciclos de CPU
            }

            Estado = EstadoCPU.Listo;
            Log.Add($"[{DateTime.Now:HH:mm:ss}] ⚙️ CPU procesó datos → {resultado}");


            return "⚙️ CPU procesó datos → " + resultado;
        }

        /// <summary>
        /// Reinicia el computador a estado inicial.
        /// </summary>
        public void Reiniciar()
        {
            Disco = "";
            RAM = "";
            Estado = EstadoCPU.Inactiva;
            HistorialDisco.Clear();
            HistorialRAM.Clear();
            Log.Add("♻️ Computador reiniciado");
        }
    }
}