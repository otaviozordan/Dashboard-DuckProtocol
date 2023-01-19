
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
            this.textBoxReceber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluirEnv = new System.Windows.Forms.Button();
            this.textBoxEnv = new System.Windows.Forms.TextBox();
            this.btnExcluirRec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btEnviar.Location = new System.Drawing.Point(27, 160);
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
            this.textBoxEnviar.Location = new System.Drawing.Point(167, 160);
            this.textBoxEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnviar.Name = "textBoxEnviar";
            this.textBoxEnviar.Size = new System.Drawing.Size(245, 27);
            this.textBoxEnviar.TabIndex = 4;
            // 
            // textBoxReceber
            // 
            this.textBoxReceber.Location = new System.Drawing.Point(778, 114);
            this.textBoxReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxReceber.Multiline = true;
            this.textBoxReceber.Name = "textBoxReceber";
            this.textBoxReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceber.Size = new System.Drawing.Size(310, 78);
            this.textBoxReceber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(775, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frame Recebido:";
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
            this.label2.Location = new System.Drawing.Point(514, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = " RS458 Modbus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "By CEDEN ";
            // 
            // btnExcluirEnv
            // 
            this.btnExcluirEnv.Location = new System.Drawing.Point(674, 195);
            this.btnExcluirEnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluirEnv.Name = "btnExcluirEnv";
            this.btnExcluirEnv.Size = new System.Drawing.Size(71, 35);
            this.btnExcluirEnv.TabIndex = 11;
            this.btnExcluirEnv.Text = "Excluir";
            this.btnExcluirEnv.UseVisualStyleBackColor = true;
            this.btnExcluirEnv.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxEnv
            // 
            this.textBoxEnv.Location = new System.Drawing.Point(435, 113);
            this.textBoxEnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEnv.Multiline = true;
            this.textBoxEnv.Name = "textBoxEnv";
            this.textBoxEnv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEnv.Size = new System.Drawing.Size(310, 78);
            this.textBoxEnv.TabIndex = 12;
            // 
            // btnExcluirRec
            // 
            this.btnExcluirRec.Location = new System.Drawing.Point(1021, 195);
            this.btnExcluirRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluirRec.Name = "btnExcluirRec";
            this.btnExcluirRec.Size = new System.Drawing.Size(67, 35);
            this.btnExcluirRec.TabIndex = 14;
            this.btnExcluirRec.Text = "Excluir";
            this.btnExcluirRec.UseVisualStyleBackColor = true;
            this.btnExcluirRec.Click += new System.EventHandler(this.btnExcluirRec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Frame Enviado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 736);
            this.Controls.Add(this.btnExcluirRec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEnv);
            this.Controls.Add(this.btnExcluirEnv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReceber);
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
        public System.Windows.Forms.TextBox textBoxReceber;
        private System.Windows.Forms.Button btnExcluirEnv;
        public System.Windows.Forms.TextBox textBoxEnv;
        private System.Windows.Forms.Button btnExcluirRec;
        private System.Windows.Forms.Label label4;
    }
}

