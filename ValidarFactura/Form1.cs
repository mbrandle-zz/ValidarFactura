using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValidarFactura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                lblEstatus.Text = "";
                lblEstado.Text = "";
                ConsultaCFDI.ConsultaCFDIServiceClient nConsulta = new ConsultaCFDI.ConsultaCFDIServiceClient();
                ConsultaCFDI.Acuse nAcuse = new ConsultaCFDI.Acuse();
                nAcuse = nConsulta.Consulta("?re=AAF931108RQ6&rr=BASM871212111&tt=0000003789.590000&id=d6c01ec0-fd0e-4234-bdc9-6955a308b533");
                //MessageBox.Show("Estatus " + nAcuse.CodigoEstatus + " Estado: " + nAcuse.Estado);

                lblEstatus.Text = nAcuse.CodigoEstatus;
                lblEstado.Text = nAcuse.Estado;

                txtCodigo.Text = "?re=AAF931108RQ6&rr=BASM871212111&tt=0000003789.590000&id=d6c01ec0-fd0e-4234-bdc9-6955a308b533";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
