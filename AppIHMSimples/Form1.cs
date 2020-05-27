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
        delegate void funcaoRecepcao();
        public Form1()
        {
            InitializeComponent();
            
            //Parte da thread com a recpção dos dados
            serialPort1.DataReceived += SerialPort1_DataReceived;     
        }

        //Thread delega a recepção para a função que ler os dados
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            funcaoRecepcao recepcaoDelegate = new funcaoRecepcao(RecepcaoSerial);
            Invoke(recepcaoDelegate);
        }

        //Função que lê os dados na serial
        public void RecepcaoSerial()
        {
            txtRecep.Text += serialPort1.ReadExisting();
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
            cbBoxPort.Text = "COM1";//Nome inicial para o comboBox

            //Valores de velocidade no comboBox Baud Rate
            int[] valoresBaud = { 2400, 4800, 9600, 19200, 57600, 115200 };
            for (int i = 0; i < valoresBaud.Length; i++)
            {
                cbBoxBaud.Items.Add(valoresBaud[i].ToString());
            }
            cbBoxBaud.Text = "9600";

            //Valores do tamanho dos dados
            cbBoxData.Items.Add("7");
            cbBoxData.Items.Add("8");
            cbBoxData.Text = "8";

            //Valores do Bit Stop
            cbBoxStop.Items.Add("NONE");
            cbBoxStop.Items.Add("ONE");
            cbBoxStop.Items.Add("TWO");
            cbBoxStop.Text = "NONE";

            //Valores do Parity
            cbBoxParity.Items.Add("NONE");
            cbBoxParity.Items.Add("EVEN");
            cbBoxParity.Items.Add("ODD");
            cbBoxParity.Items.Add("MARK");
            cbBoxParity.Items.Add("SPACE");
            cbBoxParity.Text = "NONE";
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            //Verificar se a porta estar aberta, caso esteja fechar lá, caso não abrir com os parâmetros dos comboBox
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
            else
            {
                //Tratamento de erro caso algum parâmetro esteja errado ou não exista
                try
                {
                    //Abrindo a porta com
                    serialPort1.PortName = cbBoxPort.Text;
                    serialPort1.BaudRate = int.Parse(cbBoxBaud.Text);
                    serialPort1.DataBits = int.Parse(cbBoxData.Text);
                    serialPort1.StopBits = (StopBits)(cbBoxStop.SelectedIndex);//Casting para tipo StopBits e Selecinar o item do comboBox
                    serialPort1.Parity = (Parity)(cbBoxParity.SelectedIndex);//O mesmo que foi digitado a cima
                    serialPort1.Open();

                    //Desabilitando os botões caso não exista erro
                    btnCom.Enabled = false;
                    btnDes.Enabled = true;
                    btnFec.Enabled = false;
                    cbBoxPort.Enabled = false;
                    cbBoxBaud.Enabled = false;
                    cbBoxData.Enabled = false;
                    cbBoxStop.Enabled = false;
                    cbBoxParity.Enabled = false;
                    pnlMsg.BackColor = Color.Green;
                    label1.Text = "Close Port";

                }
                catch
                {
                    MessageBox.Show("Erro de comunicação com a porta!");
                    //Caso exista erro voltar as configurações anteriores
                    btnCom.Enabled = true;
                    btnDes.Enabled = false;
                    btnFec.Enabled = true;
                    cbBoxPort.Enabled = true;
                    cbBoxBaud.Enabled = true;
                    cbBoxData.Enabled = true;
                    cbBoxStop.Enabled = true;
                    cbBoxParity.Enabled = true;
                    pnlMsg.BackColor = Color.Red;
                    label1.Text = "Open Port";
                }
            }

            
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            try
            {
                //Fechando a porta
                serialPort1.Close();

                //Desabilitando os botões caso não exista erro
                
                btnCom.Enabled = true;
                btnDes.Enabled = false;
                btnFec.Enabled = true;
                cbBoxPort.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxData.Enabled = true;
                cbBoxStop.Enabled = true;
                cbBoxParity.Enabled = true;
                pnlMsg.BackColor = Color.Red;
                label1.Text = "Open Port";

            }
            catch
            {
                MessageBox.Show("Erro de comunicação com a porta!");
                //Caso exista erro voltar as configurações anteriores
                btnCom.Enabled = false;
                btnDes.Enabled = true;
                btnFec.Enabled = false;
                cbBoxPort.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxData.Enabled = false;
                cbBoxStop.Enabled = false;
                cbBoxParity.Enabled = false;
                pnlMsg.BackColor = Color.Green;
                label1.Text = "Close Port";
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Verificação se a porta estar aberta, caso não gerar um Mesage Box
            if (serialPort1.IsOpen)
            {
                //Caso o checkBox esteja selecionado enviar com quebra de linha
                if (chbEnviar.Checked)
                {
                    serialPort1.Write(txtEnviar.Text + "\r");
                }
                else
                {
                    serialPort1.Write(txtEnviar.Text);
                }
                txtEnviar.Text = null;

            }
            else
            {
                MessageBox.Show("Erro de comunicação com a porta!");
            }


        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtRecep.Text = null;
        }
    }
}
