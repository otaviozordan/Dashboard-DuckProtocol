using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  // necessário para ter acesso as portas

namespace Monitor_CAN
{
    public partial class Form1 : Form
    {
        byte[] ReceivedMessage;
        int intRecivedMessage;

        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
        }

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataBits = 8;
                    serialPort1.ReceivedBytesThreshold = 9;
                    serialPort1.RtsEnable = true;
                    serialPort1.DtrEnable = true;
                    serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
                    serialPort1.DataReceived += port_DataReceived;
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta 
                serialPort1.Close();            //fecha a porta
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)          //porta está aberta
                serialPort1.Write(textBoxEnviar.Text);  //envia o texto presente no textbox Enviar
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intbytes = serialPort1.BytesToRead;
            byte[] buffer = new byte[intbytes];
            serialPort1.Read(buffer, 0, intbytes);

            for (int i=0; i<intbytes; i++) {
                if (buffer[i] == 1)
                {

                }
            }

            ReceivedMessage = new byte[intbytes];  //create an array of the same size
            Array.Copy(buffer, ReceivedMessage, intbytes);  //copy it across

            this.Invoke(new EventHandler(DoUpDate));
        }

        private void DoUpDate(object s, EventArgs e)
        {
            textBoxReceber.AppendText(System.Text.Encoding.ASCII.GetString(ReceivedMessage));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxReceber.Text = "";
        }
    }
}