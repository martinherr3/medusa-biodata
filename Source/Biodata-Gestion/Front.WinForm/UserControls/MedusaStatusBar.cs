using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Collections;
using System.Timers;

namespace Medusa.Biodata.FrontEnd.UserControls
{
    /// <summary>
    /// Barra de estado de Medusa
    /// </summary>
    public partial class MedusaStatusBar : StatusStrip
    {
        private System.Timers.Timer aTimer = new System.Timers.Timer();
        delegate void SetInfoCallback(bool value, string text);
        delegate void SetLoadingCallback(bool value);

        /// <summary>
        /// Constructor
        /// </summary>
        public MedusaStatusBar()
        {
            InitializeComponent();
            
            //Agrego el item de cargando
            ToolStripItem item1 = new ToolStripStatusLabel();
            Image loadingImage = Properties.Resources.ajax_loader_4;
            item1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            item1.Name = "loading";
            item1.Image = loadingImage;
            item1.ImageScaling = ToolStripItemImageScaling.None;
            item1.Text = "Cargando...";
            this.Items.Add(item1);
            //Agrego el item de informacion
            ToolStripItem item2 = new ToolStripStatusLabel();
            Image infoImage = Properties.Resources.emblem_important;
            item2.Name = "information";
            item2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            item2.Image = infoImage;
            item2.ImageScaling = ToolStripItemImageScaling.None;
            item2.Text = "";
            item2.Visible = false;
            this.Items.Add(item2);

            //Timer
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 10000;
        }

        [Browsable(true)]
        [DefaultValue(false)]
        public bool Loading
        {
            set 
            {
                SetLoadingState(value);
            }
            get
            {
                return this.Items["loading"].Visible;
            }
        }
   
        [Browsable(true)]
        [DefaultValue("")]
        public string Information
        {
            set
            {
                SetInfoState(true, value);
                aTimer.Enabled = true;
            }
        }

        [Browsable(true)]
        [DefaultValue(10000)]
        public double InfoTimerInterval
        {
            set
            {
                aTimer.Interval = value;
            }
        }

        /// <summary>
        /// Maneja el evento ElapsedEventHandler del Timer
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            this.SetInfoState(false, "");
        }

        /// <summary>
        /// Setea la info en modo thread safe
        /// </summary>
        /// <param name="value"></param>
        /// <param name="text"></param>
        private void SetInfoState(bool value, string text)
        {
            if (this.InvokeRequired)
            {
                SetInfoCallback d = new SetInfoCallback(SetInfoState);
                this.Invoke(d, new object[] { value, text });
            }
            else
            {
                this.Items["information"].Visible = value;
                this.Items["information"].Text = text;
            }
        }

        /// <summary>
        /// Setea el estado de loging en modo thread safe
        /// </summary>
        /// <param name="value"></param>
        private void SetLoadingState(bool value)
        {
            if (this.InvokeRequired)
            {
                SetLoadingCallback d = new SetLoadingCallback(SetLoadingState);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.Items["loading"].Visible = value;
            }
        }
    }
}
