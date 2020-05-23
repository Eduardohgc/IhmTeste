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

namespace AppIHMSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFec_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Evento ocorre ao carregar o form
        private void Form1_Load(object sender, EventArgs e)
        {
            //Vetor que recebe todos os nomes das portas
            String[] valoresPort = SerialPort.GetPortNames();

            //Adicionar os nomes das postar no comboBox COM Port
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
            cbBoxPort.Text = "Selecione a porta";//Nome inicial para o comboBox

            //Valores de velocidade no comboBox Baud Rate
            int[] valoresBaud = { 2400, 4800, 9600, 19200, 57600, 115200 };
            for (int i = 0; i < valoresBaud.Length; i++)
            {
                cbBoxBaud.Items.Add(valoresBaud[i].ToString());
            }
            cbBoxBaud.Text = "Selecione a velocidade";
        }
    }
}
