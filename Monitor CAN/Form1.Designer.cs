
namespace Monitor_CAN
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.textBoxEnviar = new System.Windows.Forms.TextBox();
            this.textBoxRec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluirRec = new System.Windows.Forms.Button();
            this.OnOff1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.destino1 = new System.Windows.Forms.TextBox();
            this.destino2 = new System.Windows.Forms.TextBox();
            this.OnOff2 = new System.Windows.Forms.Button();
            this.destino4 = new System.Windows.Forms.TextBox();
            this.OnOff4 = new System.Windows.Forms.Button();
            this.destino3 = new System.Windows.Forms.TextBox();
            this.OnOff3 = new System.Windows.Forms.Button();
            this.textoBox_meuId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(27, 108);
            this.btConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(117, 32);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 110);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(27, 153);
            this.btEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(117, 32);
            this.btEnviar.TabIndex = 3;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // textBoxEnviar
            // 
            this.textBoxEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnviar.Location = new System.Drawing.Point(167, 158);
            this.textBoxEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnviar.Name = "textBoxEnviar";
            this.textBoxEnviar.Size = new System.Drawing.Size(282, 27);
            this.textBoxEnviar.TabIndex = 4;
            // 
            // textBoxRec
            // 
            this.textBoxRec.Location = new System.Drawing.Point(561, 103);
            this.textBoxRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRec.Multiline = true;
            this.textBoxRec.Name = "textBoxRec";
            this.textBoxRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRec.Size = new System.Drawing.Size(552, 84);
            this.textBoxRec.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prompt:";
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = " RS458 Modbus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "By CEDEN ";
            // 
            // btnExcluirRec
            // 
            this.btnExcluirRec.Location = new System.Drawing.Point(476, 152);
            this.btnExcluirRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluirRec.Name = "btnExcluirRec";
            this.btnExcluirRec.Size = new System.Drawing.Size(79, 35);
            this.btnExcluirRec.TabIndex = 14;
            this.btnExcluirRec.Text = "Limpar";
            this.btnExcluirRec.UseVisualStyleBackColor = true;
            this.btnExcluirRec.Click += new System.EventHandler(this.btnExcluirRec_Click);
            // 
            // OnOff1
            // 
            this.OnOff1.BackColor = System.Drawing.Color.Honeydew;
            this.OnOff1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOff1.Location = new System.Drawing.Point(97, 332);
            this.OnOff1.Name = "OnOff1";
            this.OnOff1.Size = new System.Drawing.Size(102, 94);
            this.OnOff1.TabIndex = 15;
            this.OnOff1.Text = "Acionar";
            this.OnOff1.UseVisualStyleBackColor = false;
            this.OnOff1.Click += new System.EventHandler(this.OnOff1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Comandos:";
            // 
            // destino1
            // 
            this.destino1.AccessibleDescription = "";
            this.destino1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destino1.Location = new System.Drawing.Point(81, 431);
            this.destino1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destino1.Name = "destino1";
            this.destino1.Size = new System.Drawing.Size(132, 27);
            this.destino1.TabIndex = 17;
            this.destino1.Tag = "";
            // 
            // destino2
            // 
            this.destino2.AccessibleDescription = "";
            this.destino2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destino2.Location = new System.Drawing.Point(294, 431);
            this.destino2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destino2.Name = "destino2";
            this.destino2.Size = new System.Drawing.Size(132, 27);
            this.destino2.TabIndex = 19;
            this.destino2.Tag = "";
            // 
            // OnOff2
            // 
            this.OnOff2.BackColor = System.Drawing.Color.Honeydew;
            this.OnOff2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOff2.Location = new System.Drawing.Point(310, 332);
            this.OnOff2.Name = "OnOff2";
            this.OnOff2.Size = new System.Drawing.Size(102, 94);
            this.OnOff2.TabIndex = 18;
            this.OnOff2.Text = "Acionar";
            this.OnOff2.UseVisualStyleBackColor = false;
            this.OnOff2.Click += new System.EventHandler(this.OnOff2_Click);
            // 
            // destino4
            // 
            this.destino4.AccessibleDescription = "";
            this.destino4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destino4.Location = new System.Drawing.Point(294, 628);
            this.destino4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destino4.Name = "destino4";
            this.destino4.Size = new System.Drawing.Size(132, 27);
            this.destino4.TabIndex = 23;
            this.destino4.Tag = "";
            // 
            // OnOff4
            // 
            this.OnOff4.BackColor = System.Drawing.Color.Honeydew;
            this.OnOff4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOff4.Location = new System.Drawing.Point(310, 529);
            this.OnOff4.Name = "OnOff4";
            this.OnOff4.Size = new System.Drawing.Size(102, 94);
            this.OnOff4.TabIndex = 22;
            this.OnOff4.Text = "Acionar";
            this.OnOff4.UseVisualStyleBackColor = false;
            this.OnOff4.Click += new System.EventHandler(this.OnOff4_Click);
            // 
            // destino3
            // 
            this.destino3.AccessibleDescription = "";
            this.destino3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destino3.Location = new System.Drawing.Point(81, 628);
            this.destino3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destino3.Name = "destino3";
            this.destino3.Size = new System.Drawing.Size(132, 27);
            this.destino3.TabIndex = 21;
            this.destino3.Tag = "";
            // 
            // OnOff3
            // 
            this.OnOff3.BackColor = System.Drawing.Color.Honeydew;
            this.OnOff3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOff3.Location = new System.Drawing.Point(97, 529);
            this.OnOff3.Name = "OnOff3";
            this.OnOff3.Size = new System.Drawing.Size(102, 94);
            this.OnOff3.TabIndex = 20;
            this.OnOff3.Text = "Acionar";
            this.OnOff3.UseVisualStyleBackColor = false;
            this.OnOff3.Click += new System.EventHandler(this.OnOff3_Click);
            // 
            // textoBox_meuId
            // 
            this.textoBox_meuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBox_meuId.Location = new System.Drawing.Point(868, 249);
            this.textoBox_meuId.Name = "textoBox_meuId";
            this.textoBox_meuId.Size = new System.Drawing.Size(234, 34);
            this.textoBox_meuId.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(754, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Meu Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 736);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textoBox_meuId);
            this.Controls.Add(this.destino4);
            this.Controls.Add(this.OnOff4);
            this.Controls.Add(this.destino3);
            this.Controls.Add(this.OnOff3);
            this.Controls.Add(this.destino2);
            this.Controls.Add(this.OnOff2);
            this.Controls.Add(this.destino1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OnOff1);
            this.Controls.Add(this.btnExcluirRec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRec);
            this.Controls.Add(this.textBoxEnviar);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btConectar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.TextBox textBoxEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxRec;
        private System.Windows.Forms.Button btnExcluirRec;
        private System.Windows.Forms.Button OnOff1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox destino1;
        private System.Windows.Forms.TextBox destino2;
        private System.Windows.Forms.Button OnOff2;
        private System.Windows.Forms.TextBox destino4;
        private System.Windows.Forms.Button OnOff4;
        private System.Windows.Forms.TextBox destino3;
        private System.Windows.Forms.Button OnOff3;
        private System.Windows.Forms.TextBox textoBox_meuId;
        private System.Windows.Forms.Label label5;
    }
}

