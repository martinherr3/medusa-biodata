namespace Mds.Biodata.Forms
{
    partial class frmEstudio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpSeleccionPaciente = new System.Windows.Forms.TabPage();
            this.tbpAccionARealizar = new System.Windows.Forms.TabPage();
            this.tbpEstudio = new System.Windows.Forms.TabPage();
            this.btnSiguiente = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpSeleccionPaciente);
            this.tabControl1.Controls.Add(this.tbpAccionARealizar);
            this.tabControl1.Controls.Add(this.tbpEstudio);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpSeleccionPaciente
            // 
            this.tbpSeleccionPaciente.Location = new System.Drawing.Point(4, 22);
            this.tbpSeleccionPaciente.Name = "tbpSeleccionPaciente";
            this.tbpSeleccionPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSeleccionPaciente.Size = new System.Drawing.Size(660, 523);
            this.tbpSeleccionPaciente.TabIndex = 0;
            this.tbpSeleccionPaciente.Text = "Selección de Paciente";
            this.tbpSeleccionPaciente.UseVisualStyleBackColor = true;
            // 
            // tbpAccionARealizar
            // 
            this.tbpAccionARealizar.Location = new System.Drawing.Point(4, 22);
            this.tbpAccionARealizar.Name = "tbpAccionARealizar";
            this.tbpAccionARealizar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAccionARealizar.Size = new System.Drawing.Size(631, 522);
            this.tbpAccionARealizar.TabIndex = 1;
            this.tbpAccionARealizar.Text = "Acción a realizar";
            this.tbpAccionARealizar.UseVisualStyleBackColor = true;
            // 
            // tbpEstudio
            // 
            this.tbpEstudio.Location = new System.Drawing.Point(4, 22);
            this.tbpEstudio.Name = "tbpEstudio";
            this.tbpEstudio.Size = new System.Drawing.Size(631, 522);
            this.tbpEstudio.TabIndex = 2;
            this.tbpEstudio.Text = "Estudio";
            this.tbpEstudio.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = null;
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiguiente.Location = new System.Drawing.Point(562, 569);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(114, 30);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Texto = "Siguiente";
            // 
            // frmEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 601);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEstudio";
            this.Text = "frmEstudio";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpSeleccionPaciente;
        private System.Windows.Forms.TabPage tbpAccionARealizar;
        private System.Windows.Forms.TabPage tbpEstudio;
        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnSiguiente;
    }
}