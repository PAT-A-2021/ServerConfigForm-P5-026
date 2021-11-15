using System;
using ServiceMtk_P1_20190140026;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_026
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));
            labelOnOrOff.Text = "Server on";
            labelKet.Text = "Klik off untuk mematikan server";
            Host.Open();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            Host.Close();
            labelOnOrOff.Text = "Server off";
            labelKet.Text = "Klik ON untuk menjalankan server";
        }
    }
}
