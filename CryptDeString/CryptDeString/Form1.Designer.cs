namespace CryptDeString
{
    partial class frmPrincipal
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
            this.btnEncryptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFraseSecreta = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaidaString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecrypta = new System.Windows.Forms.Button();
            this.grpEncrypta = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbString = new System.Windows.Forms.TabPage();
            this.tcArquivo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLocalParaSalvar = new System.Windows.Forms.TextBox();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.btnSalvarArquivoDecryptado = new System.Windows.Forms.Button();
            this.btnSalvarArquivoEncryptado = new System.Windows.Forms.Button();
            this.txtCaminhoDoArquivoTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFraseParaEncryptareDecryptarArquivos = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpEncrypta.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbString.SuspendLayout();
            this.tcArquivo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncryptar
            // 
            this.btnEncryptar.Location = new System.Drawing.Point(6, 147);
            this.btnEncryptar.Name = "btnEncryptar";
            this.btnEncryptar.Size = new System.Drawing.Size(68, 34);
            this.btnEncryptar.TabIndex = 0;
            this.btnEncryptar.Text = "Encryptar";
            this.btnEncryptar.UseVisualStyleBackColor = true;
            this.btnEncryptar.Click += new System.EventHandler(this.btnEncryptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frase secreta";
            // 
            // txtFraseSecreta
            // 
            this.txtFraseSecreta.Location = new System.Drawing.Point(6, 30);
            this.txtFraseSecreta.Name = "txtFraseSecreta";
            this.txtFraseSecreta.Size = new System.Drawing.Size(331, 20);
            this.txtFraseSecreta.TabIndex = 2;
            this.txtFraseSecreta.Text = "P@55w0rDM45T3r";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(6, 70);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(331, 20);
            this.txtString.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto a ser encryptado";
            // 
            // txtSaidaString
            // 
            this.txtSaidaString.Location = new System.Drawing.Point(6, 121);
            this.txtSaidaString.Name = "txtSaidaString";
            this.txtSaidaString.Size = new System.Drawing.Size(331, 20);
            this.txtSaidaString.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto encryptado";
            // 
            // btnDecrypta
            // 
            this.btnDecrypta.Location = new System.Drawing.Point(80, 148);
            this.btnDecrypta.Name = "btnDecrypta";
            this.btnDecrypta.Size = new System.Drawing.Size(68, 32);
            this.btnDecrypta.TabIndex = 9;
            this.btnDecrypta.Text = "Decryptar";
            this.btnDecrypta.UseVisualStyleBackColor = true;
            this.btnDecrypta.Click += new System.EventHandler(this.btnDecrypta_Click);
            // 
            // grpEncrypta
            // 
            this.grpEncrypta.Controls.Add(this.btnLimpar);
            this.grpEncrypta.Controls.Add(this.btnEncryptar);
            this.grpEncrypta.Controls.Add(this.txtFraseSecreta);
            this.grpEncrypta.Controls.Add(this.label2);
            this.grpEncrypta.Controls.Add(this.btnDecrypta);
            this.grpEncrypta.Controls.Add(this.txtString);
            this.grpEncrypta.Controls.Add(this.label3);
            this.grpEncrypta.Controls.Add(this.txtSaidaString);
            this.grpEncrypta.Controls.Add(this.label1);
            this.grpEncrypta.Location = new System.Drawing.Point(6, 6);
            this.grpEncrypta.Name = "grpEncrypta";
            this.grpEncrypta.Size = new System.Drawing.Size(349, 196);
            this.grpEncrypta.TabIndex = 13;
            this.grpEncrypta.TabStop = false;
            this.grpEncrypta.Enter += new System.EventHandler(this.grpEncrypta_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbString);
            this.tabControl1.Controls.Add(this.tcArquivo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 308);
            this.tabControl1.TabIndex = 15;
            // 
            // tbString
            // 
            this.tbString.Controls.Add(this.grpEncrypta);
            this.tbString.Location = new System.Drawing.Point(4, 22);
            this.tbString.Name = "tbString";
            this.tbString.Padding = new System.Windows.Forms.Padding(3);
            this.tbString.Size = new System.Drawing.Size(370, 282);
            this.tbString.TabIndex = 0;
            this.tbString.Text = "Strings";
            this.tbString.UseVisualStyleBackColor = true;
            // 
            // tcArquivo
            // 
            this.tcArquivo.Controls.Add(this.groupBox1);
            this.tcArquivo.Location = new System.Drawing.Point(4, 22);
            this.tcArquivo.Name = "tcArquivo";
            this.tcArquivo.Padding = new System.Windows.Forms.Padding(3);
            this.tcArquivo.Size = new System.Drawing.Size(370, 282);
            this.tcArquivo.TabIndex = 1;
            this.tcArquivo.Text = "Arquivos";
            this.tcArquivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLocalParaSalvar);
            this.groupBox1.Controls.Add(this.btnAbrirArquivo);
            this.groupBox1.Controls.Add(this.btnSalvarArquivoDecryptado);
            this.groupBox1.Controls.Add(this.btnSalvarArquivoEncryptado);
            this.groupBox1.Controls.Add(this.txtCaminhoDoArquivoTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFraseParaEncryptareDecryptarArquivos);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 155);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(269, 85);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Local para salvar";
            // 
            // txtLocalParaSalvar
            // 
            this.txtLocalParaSalvar.Location = new System.Drawing.Point(6, 87);
            this.txtLocalParaSalvar.Name = "txtLocalParaSalvar";
            this.txtLocalParaSalvar.Size = new System.Drawing.Size(257, 20);
            this.txtLocalParaSalvar.TabIndex = 6;
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(270, 39);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirArquivo.TabIndex = 2;
            this.btnAbrirArquivo.Text = "Abrir";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalvarArquivoDecryptado
            // 
            this.btnSalvarArquivoDecryptado.Location = new System.Drawing.Point(192, 123);
            this.btnSalvarArquivoDecryptado.Name = "btnSalvarArquivoDecryptado";
            this.btnSalvarArquivoDecryptado.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarArquivoDecryptado.TabIndex = 5;
            this.btnSalvarArquivoDecryptado.Text = "Decriptar";
            this.btnSalvarArquivoDecryptado.UseVisualStyleBackColor = true;
            this.btnSalvarArquivoDecryptado.Click += new System.EventHandler(this.btnSalvarArquivoDecryptado_Click);
            // 
            // btnSalvarArquivoEncryptado
            // 
            this.btnSalvarArquivoEncryptado.Location = new System.Drawing.Point(269, 123);
            this.btnSalvarArquivoEncryptado.Name = "btnSalvarArquivoEncryptado";
            this.btnSalvarArquivoEncryptado.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarArquivoEncryptado.TabIndex = 5;
            this.btnSalvarArquivoEncryptado.Text = "Encriptar";
            this.btnSalvarArquivoEncryptado.UseVisualStyleBackColor = true;
            this.btnSalvarArquivoEncryptado.Click += new System.EventHandler(this.btnSalvarArquivoEncryptado_Click);
            // 
            // txtCaminhoDoArquivoTxt
            // 
            this.txtCaminhoDoArquivoTxt.Location = new System.Drawing.Point(7, 41);
            this.txtCaminhoDoArquivoTxt.Name = "txtCaminhoDoArquivoTxt";
            this.txtCaminhoDoArquivoTxt.Size = new System.Drawing.Size(257, 20);
            this.txtCaminhoDoArquivoTxt.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Frase secreta do arquivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Caminho do *.txt";
            // 
            // txtFraseParaEncryptareDecryptarArquivos
            // 
            this.txtFraseParaEncryptareDecryptarArquivos.Location = new System.Drawing.Point(7, 126);
            this.txtFraseParaEncryptareDecryptarArquivos.Name = "txtFraseParaEncryptareDecryptarArquivos";
            this.txtFraseParaEncryptareDecryptarArquivos.Size = new System.Drawing.Size(179, 20);
            this.txtFraseParaEncryptareDecryptarArquivos.TabIndex = 3;
            this.txtFraseParaEncryptareDecryptarArquivos.Text = "P@55w0rDM45T3r";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(154, 148);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(68, 32);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 330);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.grpEncrypta.ResumeLayout(false);
            this.grpEncrypta.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbString.ResumeLayout(false);
            this.tcArquivo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncryptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFraseSecreta;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaidaString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecrypta;
        private System.Windows.Forms.GroupBox grpEncrypta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbString;
        private System.Windows.Forms.TabPage tcArquivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.TextBox txtCaminhoDoArquivoTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFraseParaEncryptareDecryptarArquivos;
        private System.Windows.Forms.Button btnSalvarArquivoEncryptado;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvarArquivoDecryptado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLocalParaSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

