namespace Mds.Biodata.Forms.UserControls
{
    partial class uscAnamnesis
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
            this.gpbAnamnesis = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gpbAnamnesis
            // 
            this.gpbAnamnesis.Location = new System.Drawing.Point(3, 3);
            this.gpbAnamnesis.Name = "gpbAnamnesis";
            this.gpbAnamnesis.Size = new System.Drawing.Size(695, 395);
            this.gpbAnamnesis.TabIndex = 0;
            this.gpbAnamnesis.TabStop = false;
            this.gpbAnamnesis.Text = "Preguntas";
            // 
            // uscAnamnesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbAnamnesis);
            this.Name = "uscAnamnesis";
            this.Size = new System.Drawing.Size(701, 401);
            this.Load += new System.EventHandler(this.uscAnamnesis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAnamnesis;

    }
}
