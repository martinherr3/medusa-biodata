namespace Mds.Biodata.Forms.UserControls
{
    partial class uscTimpanometria
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linerCentral = new Pavr.Drawing.Liner();
            this.dgvTablaReflejosIzq = new System.Windows.Forms.DataGridView();
            this.gpbIzquierdo = new System.Windows.Forms.GroupBox();
            this.rad10Izq = new System.Windows.Forms.RadioButton();
            this.rad05Izq = new System.Windows.Forms.RadioButton();
            this.lblReflexSensitivityIzq = new System.Windows.Forms.Label();
            this.gpbDerecho = new System.Windows.Forms.GroupBox();
            this.dgvTablaReflejosDer = new System.Windows.Forms.DataGridView();
            this.rad10Der = new System.Windows.Forms.RadioButton();
            this.rad05Der = new System.Windows.Forms.RadioButton();
            this.lblReflexSensitivityDer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaReflejosIzq)).BeginInit();
            this.gpbIzquierdo.SuspendLayout();
            this.gpbDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaReflejosDer)).BeginInit();
            this.SuspendLayout();
            // 
            // linerCentral
            // 
            this.linerCentral.BackColor = System.Drawing.Color.Transparent;
            this.linerCentral.CreateButtonText = "New Timpanometria";
            this.linerCentral.LegendCaption = "Leyendas";
            this.linerCentral.LineColor = null;
            this.linerCentral.Location = new System.Drawing.Point(6, 6);
            this.linerCentral.MatrixLinesColor = System.Drawing.Color.LightGray;
            this.linerCentral.Name = "linerCentral";
            this.linerCentral.PointColor = System.Drawing.Color.Black;
            this.linerCentral.Size = new System.Drawing.Size(469, 322);
            this.linerCentral.TabIndex = 8;
            this.linerCentral.XInterval = "-300, 200, 100, +";
            this.linerCentral.YInterval = "0, 5, 1, +";
            // 
            // dgvTablaReflejosIzq
            // 
            this.dgvTablaReflejosIzq.AllowUserToAddRows = false;
            this.dgvTablaReflejosIzq.AllowUserToDeleteRows = false;
            this.dgvTablaReflejosIzq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaReflejosIzq.Location = new System.Drawing.Point(6, 41);
            this.dgvTablaReflejosIzq.Name = "dgvTablaReflejosIzq";
            this.dgvTablaReflejosIzq.Size = new System.Drawing.Size(321, 102);
            this.dgvTablaReflejosIzq.TabIndex = 10;
            // 
            // gpbIzquierdo
            // 
            this.gpbIzquierdo.Controls.Add(this.rad10Izq);
            this.gpbIzquierdo.Controls.Add(this.rad05Izq);
            this.gpbIzquierdo.Controls.Add(this.lblReflexSensitivityIzq);
            this.gpbIzquierdo.Controls.Add(this.dgvTablaReflejosIzq);
            this.gpbIzquierdo.Location = new System.Drawing.Point(487, 19);
            this.gpbIzquierdo.Name = "gpbIzquierdo";
            this.gpbIzquierdo.Size = new System.Drawing.Size(334, 149);
            this.gpbIzquierdo.TabIndex = 11;
            this.gpbIzquierdo.TabStop = false;
            this.gpbIzquierdo.Text = "Oido Izquierdo";
            // 
            // rad10Izq
            // 
            this.rad10Izq.AutoSize = true;
            this.rad10Izq.Location = new System.Drawing.Point(234, 16);
            this.rad10Izq.Name = "rad10Izq";
            this.rad10Izq.Size = new System.Drawing.Size(40, 17);
            this.rad10Izq.TabIndex = 13;
            this.rad10Izq.Text = "1.0";
            this.rad10Izq.UseVisualStyleBackColor = true;
            // 
            // rad05Izq
            // 
            this.rad05Izq.AutoSize = true;
            this.rad05Izq.Checked = true;
            this.rad05Izq.Location = new System.Drawing.Point(125, 18);
            this.rad05Izq.Name = "rad05Izq";
            this.rad05Izq.Size = new System.Drawing.Size(34, 17);
            this.rad05Izq.TabIndex = 12;
            this.rad05Izq.TabStop = true;
            this.rad05Izq.Text = ".5";
            this.rad05Izq.UseVisualStyleBackColor = true;
            // 
            // lblReflexSensitivityIzq
            // 
            this.lblReflexSensitivityIzq.AutoSize = true;
            this.lblReflexSensitivityIzq.Location = new System.Drawing.Point(3, 20);
            this.lblReflexSensitivityIzq.Name = "lblReflexSensitivityIzq";
            this.lblReflexSensitivityIzq.Size = new System.Drawing.Size(92, 13);
            this.lblReflexSensitivityIzq.TabIndex = 11;
            this.lblReflexSensitivityIzq.Text = "Reflejo Estapedial";
            // 
            // gpbDerecho
            // 
            this.gpbDerecho.Controls.Add(this.dgvTablaReflejosDer);
            this.gpbDerecho.Controls.Add(this.rad10Der);
            this.gpbDerecho.Controls.Add(this.rad05Der);
            this.gpbDerecho.Controls.Add(this.lblReflexSensitivityDer);
            this.gpbDerecho.Location = new System.Drawing.Point(487, 179);
            this.gpbDerecho.Name = "gpbDerecho";
            this.gpbDerecho.Size = new System.Drawing.Size(334, 149);
            this.gpbDerecho.TabIndex = 14;
            this.gpbDerecho.TabStop = false;
            this.gpbDerecho.Text = "Oido Derecho";
            // 
            // dgvTablaReflejosDer
            // 
            this.dgvTablaReflejosDer.AllowUserToAddRows = false;
            this.dgvTablaReflejosDer.AllowUserToDeleteRows = false;
            this.dgvTablaReflejosDer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaReflejosDer.Location = new System.Drawing.Point(6, 41);
            this.dgvTablaReflejosDer.Name = "dgvTablaReflejosDer";
            this.dgvTablaReflejosDer.Size = new System.Drawing.Size(321, 102);
            this.dgvTablaReflejosDer.TabIndex = 14;
            // 
            // rad10Der
            // 
            this.rad10Der.AutoSize = true;
            this.rad10Der.Location = new System.Drawing.Point(234, 15);
            this.rad10Der.Name = "rad10Der";
            this.rad10Der.Size = new System.Drawing.Size(40, 17);
            this.rad10Der.TabIndex = 13;
            this.rad10Der.Text = "1.0";
            this.rad10Der.UseVisualStyleBackColor = true;
            // 
            // rad05Der
            // 
            this.rad05Der.AutoSize = true;
            this.rad05Der.Checked = true;
            this.rad05Der.Location = new System.Drawing.Point(125, 15);
            this.rad05Der.Name = "rad05Der";
            this.rad05Der.Size = new System.Drawing.Size(34, 17);
            this.rad05Der.TabIndex = 12;
            this.rad05Der.TabStop = true;
            this.rad05Der.Text = ".5";
            this.rad05Der.UseVisualStyleBackColor = true;
            // 
            // lblReflexSensitivityDer
            // 
            this.lblReflexSensitivityDer.AutoSize = true;
            this.lblReflexSensitivityDer.Location = new System.Drawing.Point(3, 19);
            this.lblReflexSensitivityDer.Name = "lblReflexSensitivityDer";
            this.lblReflexSensitivityDer.Size = new System.Drawing.Size(92, 13);
            this.lblReflexSensitivityDer.TabIndex = 11;
            this.lblReflexSensitivityDer.Text = "Reflejo Estapedial";
            // 
            // uscTimpanometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbDerecho);
            this.Controls.Add(this.gpbIzquierdo);
            this.Controls.Add(this.linerCentral);
            this.Name = "uscTimpanometria";
            this.Size = new System.Drawing.Size(829, 341);
            this.Load += new System.EventHandler(this.uscTimpanometria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaReflejosIzq)).EndInit();
            this.gpbIzquierdo.ResumeLayout(false);
            this.gpbIzquierdo.PerformLayout();
            this.gpbDerecho.ResumeLayout(false);
            this.gpbDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaReflejosDer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Pavr.Drawing.Liner linerCentral;
        private System.Windows.Forms.DataGridView dgvTablaReflejosIzq;
        private System.Windows.Forms.GroupBox gpbIzquierdo;
        private System.Windows.Forms.RadioButton rad10Izq;
        private System.Windows.Forms.RadioButton rad05Izq;
        private System.Windows.Forms.Label lblReflexSensitivityIzq;
        private System.Windows.Forms.GroupBox gpbDerecho;
        private System.Windows.Forms.RadioButton rad10Der;
        private System.Windows.Forms.RadioButton rad05Der;
        private System.Windows.Forms.Label lblReflexSensitivityDer;
        private System.Windows.Forms.DataGridView dgvTablaReflejosDer;
    }
}
