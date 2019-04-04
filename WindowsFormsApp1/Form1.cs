using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            COMPORTBOX.Items.AddRange(ports);
            
        }

        private void OPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = COMPORTBOX.Text;
                serialPort1.BaudRate = Convert.ToInt32(BAUDBOX.Text);
                serialPort1.DataBits = Convert.ToInt32(DATABOX.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), STOPBOX.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), PARITYBOX.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void SENDDATA_Click(object sender, EventArgs e)
        {
            serialPort1.Write("hello");
        }

        
    }
}
