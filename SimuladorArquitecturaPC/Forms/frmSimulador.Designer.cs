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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimulador));
            this.txtDisco = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.listLog = new System.Windows.Forms.ListBox();
            this.btnGuardarDisco = new System.Windows.Forms.Button();
            this.btnCargarRAM = new System.Windows.Forms.Button();
            this.btnEjecutarCPU = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisco
            // 
            this.txtDisco.Location = new System.Drawing.Point(156, 12);
            this.txtDisco.Multiline = true;
            this.txtDisco.Name = "txtDisco";
            this.txtDisco.Size = new System.Drawing.Size(174, 79);
            this.txtDisco.TabIndex = 0;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(211, 12);
            this.txtRAM.Multiline = true;
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(200, 67);
            this.txtRAM.TabIndex = 1;
            // 
            // lblCPU
            // 
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(812, 29);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(127, 72);
            this.lblCPU.TabIndex = 2;
            this.lblCPU.Text = "Esperando...";
            // 
            // listLog
            // 
            this.listLog.Location = new System.Drawing.Point(144, 14);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(409, 147);
            this.listLog.TabIndex = 3;
            // 
            // btnGuardarDisco
            // 
            this.btnGuardarDisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardarDisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDisco.Location = new System.Drawing.Point(183, 98);
            this.btnGuardarDisco.Name = "btnGuardarDisco";
            this.btnGuardarDisco.Size = new System.Drawing.Size(123, 42);
            this.btnGuardarDisco.TabIndex = 4;
            this.btnGuardarDisco.Text = "💾 Guardar";
            this.btnGuardarDisco.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGuardarDisco.Click += new System.EventHandler(this.btnGuardarDisco_Click);
            // 
            // btnCargarRAM
            // 
            this.btnCargarRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarRAM.Location = new System.Drawing.Point(146, 85);
            this.btnCargarRAM.Name = "btnCargarRAM";
            this.btnCargarRAM.Size = new System.Drawing.Size(136, 48);
            this.btnCargarRAM.TabIndex = 5;
            this.btnCargarRAM.Text = "📥 Cargar";
            this.btnCargarRAM.Click += new System.EventHandler(this.btnCargarRAM_Click);
            // 
            // btnEjecutarCPU
            // 
            this.btnEjecutarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutarCPU.Location = new System.Drawing.Point(10, 98);
            this.btnEjecutarCPU.Name = "btnEjecutarCPU";
            this.btnEjecutarCPU.Size = new System.Drawing.Size(135, 43);
            this.btnEjecutarCPU.TabIndex = 6;
            this.btnEjecutarCPU.Text = "⚙️ Ejecutar";
            this.btnEjecutarCPU.Click += new System.EventHandler(this.btnEjecutarCPU_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(810, 104);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 30);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "🧹  Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGuardarDisco);
            this.panel1.Controls.Add(this.txtDisco);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 152);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnEjecutarCPU);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(840, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 152);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtRAM);
            this.panel3.Controls.Add(this.btnCargarRAM);
            this.panel3.Location = new System.Drawing.Point(393, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 152);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(30, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(95, 75);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblCPU);
            this.panel5.Controls.Add(this.btnLimpiar);
            this.panel5.Controls.Add(this.listLog);
            this.panel5.Location = new System.Drawing.Point(12, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(975, 173);
            this.panel5.TabIndex = 11;
            // 
            // frmSimulador
            // 
            this.ClientSize = new System.Drawing.Size(1004, 380);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSimulador";
            this.Text = "Simulador Arquitectura PC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}