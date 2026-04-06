namespace SimuladorArquitecturaPC.Forms
{
    partial class frmSimulador
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDisco;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ListBox listLog;

        private System.Windows.Forms.Button btnGuardarDisco;
        private System.Windows.Forms.Button btnCargarRAM;
        private System.Windows.Forms.Button btnEjecutarCPU;
        private System.Windows.Forms.Button btnLimpiar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDisco = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.listLog = new System.Windows.Forms.ListBox();

            this.btnGuardarDisco = new System.Windows.Forms.Button();
            this.btnCargarRAM = new System.Windows.Forms.Button();
            this.btnEjecutarCPU = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // txtDisco
            this.txtDisco.Multiline = true;
            this.txtDisco.Location = new System.Drawing.Point(20, 40);
            this.txtDisco.Size = new System.Drawing.Size(200, 100);
            this.txtDisco.Name = "txtDisco";

            // txtRAM
            this.txtRAM.Multiline = true;
            this.txtRAM.Location = new System.Drawing.Point(250, 40);
            this.txtRAM.Size = new System.Drawing.Size(200, 100);
            this.txtRAM.Name = "txtRAM";

            // lblCPU
            this.lblCPU.Location = new System.Drawing.Point(500, 40);
            this.lblCPU.Size = new System.Drawing.Size(200, 30);
            this.lblCPU.Text = "Esperando...";
            this.lblCPU.Name = "lblCPU";

            // listLog
            this.listLog.Location = new System.Drawing.Point(20, 200);
            this.listLog.Size = new System.Drawing.Size(650, 150);
            this.listLog.Name = "listLog";

            // btnGuardarDisco
            this.btnGuardarDisco.Location = new System.Drawing.Point(20, 150);
            this.btnGuardarDisco.Size = new System.Drawing.Size(200, 30);
            this.btnGuardarDisco.Text = "Guardar en Disco";
            this.btnGuardarDisco.Name = "btnGuardarDisco";
            this.btnGuardarDisco.Click += new System.EventHandler(this.btnGuardarDisco_Click);

            // btnCargarRAM
            this.btnCargarRAM.Location = new System.Drawing.Point(250, 150);
            this.btnCargarRAM.Size = new System.Drawing.Size(200, 30);
            this.btnCargarRAM.Text = "Cargar a RAM";
            this.btnCargarRAM.Name = "btnCargarRAM";
            this.btnCargarRAM.Click += new System.EventHandler(this.btnCargarRAM_Click);

            // btnEjecutarCPU
            this.btnEjecutarCPU.Location = new System.Drawing.Point(480, 150);
            this.btnEjecutarCPU.Size = new System.Drawing.Size(190, 30);
            this.btnEjecutarCPU.Text = "Ejecutar CPU";
            this.btnEjecutarCPU.Name = "btnEjecutarCPU";
            this.btnEjecutarCPU.Click += new System.EventHandler(this.btnEjecutarCPU_Click);

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(500, 80);
            this.btnLimpiar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.Controls.Add(this.txtDisco);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.btnGuardarDisco);
            this.Controls.Add(this.btnCargarRAM);
            this.Controls.Add(this.btnEjecutarCPU);
            this.Controls.Add(this.btnLimpiar);

            this.Text = "Simulador Arquitectura PC";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}