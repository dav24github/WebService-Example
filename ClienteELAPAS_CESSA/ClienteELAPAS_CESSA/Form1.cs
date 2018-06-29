using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteELAPAS_CESSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioCESSA.WebService1SoapClient wsC = new ServicioCESSA.WebService1SoapClient();
            ServicioELAPAS.WebService1SoapClient wsE = new ServicioELAPAS.WebService1SoapClient();

            int id = int.Parse(textBox1.Text);

            label2.Text = "Elapas -> " + wsE.getDeudaELAPAS(id);
            label3.Text = "Cessa -> " + wsC.getDeudaCESSA(id);
            label4.Text = "Total -> " + (wsE.getDeudaELAPAS(id) + wsC.getDeudaCESSA(id));
        }
    }
}
