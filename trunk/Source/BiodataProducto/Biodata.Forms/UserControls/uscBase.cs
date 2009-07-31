using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Architecture.Utils;

namespace Mds.Biodata.Forms.UserControls
{
    public partial class uscBase : UserControl
    {
        private Int32? _EstudioActualID;

        public Int32? EstudioActualID
        {
            get { return _EstudioActualID; }
            set { _EstudioActualID = value; }
        }

        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        public uscBase()
        {
            InitializeComponent();
        }

        public virtual Estudio ObtenerDatosEstudio()
        {
            return null;
        }

        public virtual void CargarDatosEstudio(Estudio pEstudio)
        {
            
        }
    }
}
