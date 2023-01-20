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
        String Frame;

        //Variavel para discarte de pacotes incompletos
        String Trash;

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
            if (serialPort1.IsOpen == true)          //porta está aberta
                serialPort1.Write(textBoxEnviar.Text);  //envia o texto presente no textbox Enviar
        }

        private void btnExcluirRec_Click(object sender, EventArgs e)
        {
            textBoxEnviar.Text = "";
        }

        void MyDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            Trash = serialPort1.ReadTo("preamble");
            Frame = serialPort1.ReadTo("endFrame");

            this.Invoke(new EventHandler(tratarDados));
        }

        public class dataRecive
        {
            public string idRx { get; set; }
            public string idTx { get; set; }
            public string data { get; set; }
            public dataRecive(string _idRx, string _idTx, string _data)
            {
                _idRx = idRx;
                _idTx = idTx;
                _data = data;
            }
        }

        private void tratarDados(object s, EventArgs e)
        {
            string idRec = null;
            string idTras = null;
            string data = null;

            // frame --> preamble/idRx/idTx/datadata/endFrame
            string decompFrame = Frame;
            int n = decompFrame.Length;

            /*
             * Não implementado -> Pacote dinamico
            if (true /*decompFrame[0].Equals("/"))
            {
                textBoxRec.AppendText("Pacote intacto\n");
                for (int i = 1; i < n; i++)
                {
                    if (decompFrame[i] == "/")
                    {
                        textBoxRec.Text = "Brake\n";
                        break;
                    }

                    idRx += decompFrame[i];
                }
            }
            else
            {
                decompFrame = "Pacote corrompido";
                textBoxRec.AppendText("Pacote corrompido\n");
            }
            */

            if (n != 20)
            {
                MessageBox.Show("Pacote incorreto recebido");
                MessageBox.Show(Frame);
            }
            for (int i = 1; i < n; i++)
            {
                if (0<i && i<5)
                {
                    idRec += decompFrame[i];
                }
                if (5 < i && i < 10)
                {
                    idTras += decompFrame[i];
                }
                if (10 < i && i < 19)
                {
                    data += decompFrame[i];
                }
            
            }
            textBoxPrompt.AppendText("\n Frame recebido de: " + idTras + " ---> ");
            textBoxPrompt.AppendText(idRec);
            textBoxPrompt.AppendText(idTras);
            textBoxPrompt.AppendText(data);
            textBoxPrompt.AppendText("\t \n");

            if(string.Compare(idRec, textoBox_meuId.Text) == 0)
            {
                atualizarPagina(data, idTras);
            }
        }

        void atualizarPagina(string data, string  idTx)
        {
            switch (data)
            {
                case "ind1-Act":
                    Indicador1.Text = "Ativo\n" + idTx;
                    Indicador1.BackColor = Color.LimeGreen;
                    break;
                case "ind1-Dea":
                    Indicador1.Text = "Inativo\n" + idTx;
                    Indicador1.BackColor = Color.Red;
                    break;

                case "ind2-Act":
                    Indicador2.Text = "Ativo\n" + idTx;
                    Indicador2.BackColor = Color.LimeGreen;
                    break;
                case "ind2-Dea":
                    Indicador2.Text = "Inativo\n" + idTx;
                    Indicador2.BackColor = Color.Red;
                    break;

                case "ind3-Act":
                    Indicador3.Text = "Ativo\n" + idTx;
                    Indicador3.BackColor = Color.LimeGreen;
                    break;
                case "ind3-Dea":
                    Indicador3.Text = "Inativo\n" + idTx;
                    Indicador3.BackColor = Color.Red;
                    break;

                case "ind4-Act":
                    Indicador4.Text = "Ativo\n" + idTx;
                    Indicador4.BackColor = Color.LimeGreen;
                    break;
                case "ind4-Dea":
                    Indicador4.Text = "Inativo\n" + idTx;
                    Indicador4.BackColor = Color.Red;
                    break;

                default:
                    MessageBox.Show("Comando não reconhecido");
                    break;
            }
        }

        void prepararPayload(string destino, string data)
        {
            string payload;
            string meuId = textoBox_meuId.Text;

            if(destino.Length > 4)
            {
                MessageBox.Show("Endereço de destino ultrapassou 4 characteres");
                return;
            }

            if (meuId.Length > 4)
            {
                MessageBox.Show("Seu endereço ultrapassou 4 characteres");
                return;
            }

            if (data.Length > 8)
            {
                MessageBox.Show("Seu pacote ultrapassou 4 characteres");
                return;
            }

            if (destino.Length == 0)
            {
                MessageBox.Show("Endereço de destino esta vazio");
                return;
            }

            if (meuId.Length == 0)
            {
                MessageBox.Show("Seu endereço esta vazio");
                return;
            }

            if (data.Length == 0)
            {
                MessageBox.Show("Seu pacote esta vazio");
                return;
            }

            if (string.Compare(meuId, destino) == 0)
            {
                MessageBox.Show("Seu id é igual ao id do destino");
                return;
            }

            // frame --> preamble/idRx/idTx/datadata/endFrame
            payload = "preamble/" + destino + "/" + meuId + "/" + data + "/endFrame";

            serialPort1.Write(payload);

            textBoxPrompt.AppendText("\n" + "Envinado payload: " + payload);

        }

        private void OnOff1_Click(object sender, EventArgs e)
        {
            if(OnOff1.Text == "Acionado")
            {
                OnOff1.Text = "Desacionado";
                OnOff1.BackColor = Color.Red;
            }
            else if (OnOff1.Text == "Desacionado")
            {
                OnOff1.Text = "Acionado";
                OnOff1.BackColor = Color.LimeGreen;
            }
            else //Primeiro Acionamento
            {
                OnOff1.Text = "Acionado";
                OnOff1.BackColor = Color.LimeGreen;
            }

            string comando;
            if (OnOff1.Text == "Acionado")
            {
                comando = "enable";
            }
            else
            {
                comando = "disabled";
            }
            prepararPayload(destino1.Text, comando);
        }

        private void OnOff2_Click(object sender, EventArgs e)
        {
            if (OnOff2.Text == "Acionado")
            {
                OnOff2.Text = "Desacionado";
                OnOff2.BackColor = Color.Red;
            }
            else if (OnOff2.Text == "Desacionado")
            {
                OnOff2.Text = "Acionado";
                OnOff2.BackColor = Color.LimeGreen;
            }
            else //Primeiro Acionamento
            {
                OnOff2.Text = "Acionado";
                OnOff2.BackColor = Color.LimeGreen;
            }

            string comando;
            if (OnOff2.Text == "Acionado")
            {
                comando = "enable";
            }
            else
            {
                comando = "disabled";
            }
            prepararPayload(destino2.Text, comando);
        }

        private void OnOff3_Click(object sender, EventArgs e)
        {
            if (OnOff3.Text == "Acionado")
            {
                OnOff3.Text = "Desacionado";
                OnOff3.BackColor = Color.Red;
            }
            else if (OnOff3.Text == "Desacionado")
            {
                OnOff3.Text = "Acionado";
                OnOff3.BackColor = Color.LimeGreen;
            }
            else //Primeiro Acionamento
            {
                OnOff3.Text = "Acionado";
                OnOff3.BackColor = Color.LimeGreen;
            }

            string comando;
            if (OnOff3.Text == "Acionado")
            {
                comando = "enable";
            }
            else
            {
                comando = "disabled";
            }
            prepararPayload(destino3.Text, comando);
        }

        private void OnOff4_Click(object sender, EventArgs e)
        {
            if (OnOff4.Text == "Acionado")
            {
                OnOff4.Text = "Desacionado";
                OnOff4.BackColor = Color.Red;
            }
            else if (OnOff4.Text == "Desacionado")
            {
                OnOff4.Text = "Acionado";
                OnOff4.BackColor = Color.LimeGreen;
            }
            else //Primeiro Acionamento
            {
                OnOff4.Text = "Acionado";
                OnOff4.BackColor = Color.LimeGreen;
            }

            string comando;
            if (OnOff4.Text == "Acionado")
            {
                comando = "enable";
            }
            else
            {
                comando = "disabled";
            }
            prepararPayload(destino4.Text, comando);
        }

        private void Indicador1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para ativar/desativar use:\n preamble/<Id de quem está enviando>/"+ textoBox_meuId.Text + "/ind1-Act/endFrame" + "\n preamble /< Id de quem está enviando >/ "+ textoBox_meuId.Text + " / ind1-Dea / endFrame");
        }

        private void Indicador2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para ativar/desativar use:\n preamble/<Id de quem está enviando>/" + textoBox_meuId.Text + "/ind2-Act/endFrame" + "\n preamble /< Id de quem está enviando >/ " + textoBox_meuId.Text + " / ind2-Dea / endFrame");
        }

        private void Indicador3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para ativar/desativar use:\n preamble/<Id de quem está enviando>/" + textoBox_meuId.Text + "/ind3-Act/endFrame" + "\n preamble /< Id de quem está enviando >/ " + textoBox_meuId.Text + " / ind3-Dea / endFrame");
        }

        private void Indicador4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para ativar/desativar use:\n preamble/<Id de quem está enviando>/" + textoBox_meuId.Text + "/ind4-Act/endFrame" + "\n preamble /< Id de quem está enviando >/ " + textoBox_meuId.Text + " / ind4-Dea / endFrame");
        }
    }
}