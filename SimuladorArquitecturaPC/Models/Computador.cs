using System;

namespace SimuladorArquitecturaPC.Models
{
    /// <summary>
    /// Representa un computador de forma simplificada.
    /// Simula el flujo de datos entre Disco, RAM y CPU.
    /// 
    /// Este modelo está orientado a enseñanza, no a comportamiento real de hardware.
    /// </summary>
    public class Computador
    {
        /// <summary>
        /// Simula el almacenamiento en disco duro.
        /// Aquí se guardan los datos de forma persistente.
        /// </summary>
        public string Disco { get; set; }

        /// <summary>
        /// Simula la memoria RAM.
        /// Aquí se cargan los datos temporalmente para ser procesados.
        /// </summary>
        public string RAM { get; set; }

        /// <summary>
        /// Simula la transferencia de datos desde el disco hacia la memoria RAM.
        /// 
        /// En un computador real, los programas deben cargarse en RAM antes de ejecutarse.
        /// </summary>
        /// <returns>Mensaje descriptivo del proceso realizado</returns>
        public string CargarARam()
        {
            // Validación: no hay datos en disco
            if (string.IsNullOrEmpty(Disco))
                return "❌ No hay datos en el DISCO";

            // Transferencia de datos
            RAM = Disco;

            return "📥 Datos cargados de DISCO → RAM";
        }

        /// <summary>
        /// Simula el procesamiento de datos por parte de la CPU.
        /// 
        /// En este caso, el procesamiento consiste en convertir el texto a mayúsculas.
        /// </summary>
        /// <returns>Resultado del procesamiento</returns>
        public string Procesar()
        {
            // Validación: no hay datos en RAM
            if (string.IsNullOrEmpty(RAM))
                return "❌ No hay datos en RAM";

            // Simulación de procesamiento (operación simple)
            string resultado = RAM.ToUpper();

            return "⚙️ CPU procesó datos → " + resultado;
        }
    }
}