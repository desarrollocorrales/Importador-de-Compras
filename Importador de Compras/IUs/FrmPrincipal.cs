using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace Importador_de_Compras.IUs
{
    public partial class FrmPrincipal : Form
    {
        string sFileName;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarXML();
        }
        private void BuscarXML()
        {
            sFileName = null;
            DialogResult dr = ofdXML.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                textBox1.Text = ofdXML.FileName;
                sFileName = ofdXML.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarConceptos();
        }
        private void MostrarConceptos()
        {
            if (sFileName != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                XmlTextReader reader = new XmlTextReader(sFileName);

                Comprobante factura = (Comprobante)serializer.Deserialize(reader);

                gridConceptos.DataSource = factura.Conceptos;
                gvConceptos.BestFitColumns();
            }
        }
    }
}
