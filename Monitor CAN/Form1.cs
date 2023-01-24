using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.IO.Ports;  // necessário para ter acesso as portas

namespace Monitor_CAN
{
    public partial class Form1 : Form
    {
        byte[] frame = new byte[3];

        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;

            comboBoxId1.Text = "0x10";
            comboBoxId2.Text = "0x10";
            comboBoxId3.Text = "0x10";
            comboBoxId4.Text = "0x10";
            comboBoxIdInd1.Text = "0x10";
            comboBoxIdInd2.Text = "0x10";
            comboBoxIdInd3.Text = "0x10";
            comboBoxIdInd4.Text = "0x10";
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
                    serialPort1.RtsEnable = true;
                    serialPort1.DtrEnable = true;
                    serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(MyDataReceivedHandler);

                    //Tamanho do buffer e quando disparar DataReciverd
                    serialPort1.ReadBufferSize = 8000; //1000 bytes
                    serialPort1.ReceivedBytesThreshold = 1; 
                    serialPort1.Open();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
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
            if (serialPort1.IsOpen == true) //Porta está aberta
            {
                byte id, end, data;
                id = pegarValorHexTextBox(textBoxEnviarId);
                end = pegarValorHexTextBox(textBoxEnviarEnd);
                data = pegarValorHexTextBox(textBoxEnviarData);
                enviarPayload(id, end, data);
            }
        }

        private void btnExcluirRec_Click(object sender, EventArgs e)
        {
            textBoxPrompt.Text = "";
        }

        private void OnOff1_Click(object sender, EventArgs e)
        {
            byte data = 0x3d; //Acionamento data 13
            if(OnOff1.Text == "Acionado")
            {
                OnOff1.Text = "Desacionado";
                OnOff1.BackColor = Color.Red;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb0, data);
            }
            else //Primeiro Acionamento
            {
                OnOff1.Text = "Acionado";
                OnOff1.BackColor = Color.LimeGreen;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb1, data);
            }
        }

        private void OnOff2_Click(object sender, EventArgs e)
        {
            byte data = 0x3c; //Acionamento data 12
            if (OnOff2.Text == "Acionado")
            {
                OnOff2.Text = "Desacionado";
                OnOff2.BackColor = Color.Red;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb0, data);
            }
            else //Primeiro Acionamento
            {
                OnOff2.Text = "Acionado";
                OnOff2.BackColor = Color.LimeGreen;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb1, data);
            }
        }

        private void OnOff3_Click(object sender, EventArgs e)
        {
            byte data = 0x3b; //Acionamento data 11
            if (OnOff3.Text == "Acionado")
            {
                OnOff3.Text = "Desacionado";
                OnOff3.BackColor = Color.Red;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb0, data);
            }
            else //Primeiro Acionamento
            {
                OnOff3.Text = "Acionado";
                OnOff3.BackColor = Color.LimeGreen;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb1, data);
            }
        }

        private void OnOff4_Click(object sender, EventArgs e)
        {

            byte data = 0x3a; //Acionamento data 10
            if (OnOff4.Text == "Acionado")
            {
                OnOff4.Text = "Desacionado";
                OnOff4.BackColor = Color.Red;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb0, data);
            }
            else //Primeiro Acionamento
            {
                OnOff4.Text = "Acionado";
                OnOff4.BackColor = Color.LimeGreen;
                enviarPayload(pegarValorHexCombo(comboBoxId1), 0xb1, data);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (btnRefresh.Text == "Ativar Busca" && serialPort1.IsOpen)
            {
                btnRefresh.BackColor = Color.LimeGreen;
                timerBusca.Enabled = true;
                btnRefresh.Text = "Desativar Busca";
            }
            else
            {
                btnRefresh.BackColor = Color.White;
                timerBusca.Enabled = false;
                btnRefresh.Text = "Ativar Busca";
                if (!serialPort1.IsOpen)
                {
                   MessageBox.Show("Porta COM fechada.");
                }
            }
        }

        private void timerBusca_Tick(object sender, EventArgs e)
        {
            solicitarValores();
        }

        private void solicitarValores()
        {
            timerBusca.Enabled = false;

            byte idS1 = pegarValorHexCombo(comboBoxIdInd1);
            byte idS2 = pegarValorHexCombo(comboBoxIdInd2);
            byte idS3 = pegarValorHexCombo(comboBoxIdInd3);
            byte idS4 = pegarValorHexCombo(comboBoxIdInd4);

            byte[] lastFrame = new byte[3];
            lastFrame = frame;

            const int timeResponse = 1000;

            Task.Run(async () =>
            {
                //Dispara primeira request
                enviarPayload(idS1, 0xb2, 0x39);
                //Espera resposta
                await Task.Delay(timeResponse);
                if(frame[0] == 0x0f && lastFrame != frame)
                {
                    atualizarIndicador(Indicador1, frame);
                }

                //Dispara segunda request
                enviarPayload(idS2, 0xb2, 0x38);
                //Espera resposta
                await Task.Delay(timeResponse);
                if (frame[0] == 0x0f && lastFrame != frame)
                {
                    atualizarIndicador(Indicador2, frame);
                }

                //Dispara terceira request
                enviarPayload(idS3, 0xb2, 0x37);
                //Espera resposta
                await Task.Delay(timeResponse);
                if (frame[0] == 0x0f && lastFrame != frame)
                {
                    atualizarIndicador(Indicador3, frame);
                }

                //Dispara qaurta request
                enviarPayload(idS4, 0xb2, 0x36);
                //Espera resposta
                await Task.Delay(timeResponse);
                if (frame[0] == 0x0f && lastFrame != frame)
                {
                    atualizarIndicador(Indicador4, frame);
                }

            });
            timerBusca.Enabled = true;
        }

        private void atualizarIndicador(Button indicador, byte[] frame)
        {
            if (frame[1] == 0xb3)
            {
                if (frame[2] == 0x31)
                {
                    indicador.Text = "ON";
                    indicador.BackColor = Color.LimeGreen;
                }
                else if (frame[2] == 0x30)
                {
                    indicador.Text = "OFF";
                    indicador.BackColor = Color.Red;
                }
                else
                {
                    indicador.Text = "Indefinido";
                    indicador.BackColor = Color.White;
                }
            }
        }

        public byte pegarValorHexCombo(ComboBox combo)
        {
            String hex = combo.Text;
            byte b = Convert.ToByte(hex, 16); // 15;
            return b;
        }

        public byte pegarValorHexTextBox(TextBox box)
        {
            String hex = box.Text;
            byte b = Convert.ToByte(hex, 16); // 15;
            return b;
        }

        private void enviarPayload(byte id, byte end, byte data)
        {
            byte[] payload = new byte[5];

            //Payload --> 0x02 + id + end + val + 0x03
            payload[0] = 0x02;
            payload[1] = id;
            payload[2] = end;
            payload[3] = data;
            payload[4] = 0x03;

            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write(payload, 0, 5);
            }
        }

        void MyDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            byte buffer;
            for (int i = 0; i < serialPort1.BytesToRead; i++)
            {
                buffer = (byte)serialPort1.ReadByte();
                if (buffer == 0x02)
                {
                    break;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                buffer = (byte)serialPort1.ReadByte();
                frame[i] = buffer;

                if (buffer == 0x03)
                {
                    break;
                }
            }

            this.Invoke(new EventHandler(tratarDados));
        }

        private void tratarDados(object s, EventArgs e)
        {
            if (frame.Length != 3)
            {
                textBoxPrompt.AppendText("Frame corrompido");
            }
            if (serialPort1.ReadByte() != 0x03)
            {
                textBoxPrompt.AppendText("Frame corrompido");
            }

            textBoxPrompt.AppendText("\n Recebido: " + Encoding.UTF8.GetString(frame));
        }
    }
}