namespace CursoOOCaixaEletronico
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoDepositaCC = new System.Windows.Forms.Button();
            this.botaoSacaCC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoTotalizador = new System.Windows.Forms.TextBox();
            this.botaoDepositaPP = new System.Windows.Forms.Button();
            this.botaoSacaPP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.textoTitularCombo = new System.Windows.Forms.TextBox();
            this.textoNumeroCombo = new System.Windows.Forms.TextBox();
            this.textoSaldoCombo = new System.Windows.Forms.TextBox();
            this.textoValorComboBox = new System.Windows.Forms.TextBox();
            this.botaoSacarComboBox = new System.Windows.Forms.Button();
            this.botaoDepositarComboBox = new System.Windows.Forms.Button();
            this.destinoDaTransferencia = new System.Windows.Forms.ComboBox();
            this.textoTitularDestino = new System.Windows.Forms.TextBox();
            this.textoNumeroDestino = new System.Windows.Forms.TextBox();
            this.textoSaldoDestino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botaoTransferir = new System.Windows.Forms.Button();
            this.botaoImposto = new System.Windows.Forms.Button();
            this.botaoCadastrarNovaConta = new System.Windows.Forms.Button();
            this.botaoLINQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(56, 39);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(56, 115);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 1;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(56, 183);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(345, 39);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 3;
            // 
            // botaoDepositaCC
            // 
            this.botaoDepositaCC.Location = new System.Drawing.Point(345, 83);
            this.botaoDepositaCC.Name = "botaoDepositaCC";
            this.botaoDepositaCC.Size = new System.Drawing.Size(75, 23);
            this.botaoDepositaCC.TabIndex = 4;
            this.botaoDepositaCC.Text = "Depósito CC";
            this.botaoDepositaCC.UseVisualStyleBackColor = true;
            this.botaoDepositaCC.Click += new System.EventHandler(this.botaoDepositaCC_Click);
            // 
            // botaoSacaCC
            // 
            this.botaoSacaCC.Location = new System.Drawing.Point(345, 157);
            this.botaoSacaCC.Name = "botaoSacaCC";
            this.botaoSacaCC.Size = new System.Drawing.Size(75, 23);
            this.botaoSacaCC.TabIndex = 5;
            this.botaoSacaCC.Text = "Saque CC";
            this.botaoSacaCC.UseVisualStyleBackColor = true;
            this.botaoSacaCC.Click += new System.EventHandler(this.botaoSacaCC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número da Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digite o valor";
            // 
            // textoTotalizador
            // 
            this.textoTotalizador.Location = new System.Drawing.Point(320, 237);
            this.textoTotalizador.Name = "textoTotalizador";
            this.textoTotalizador.Size = new System.Drawing.Size(100, 20);
            this.textoTotalizador.TabIndex = 11;
            // 
            // botaoDepositaPP
            // 
            this.botaoDepositaPP.Location = new System.Drawing.Point(345, 112);
            this.botaoDepositaPP.Name = "botaoDepositaPP";
            this.botaoDepositaPP.Size = new System.Drawing.Size(75, 23);
            this.botaoDepositaPP.TabIndex = 12;
            this.botaoDepositaPP.Text = "Depósito PP";
            this.botaoDepositaPP.UseVisualStyleBackColor = true;
            this.botaoDepositaPP.Click += new System.EventHandler(this.botaoDepositaPP_Click);
            // 
            // botaoSacaPP
            // 
            this.botaoSacaPP.Location = new System.Drawing.Point(345, 187);
            this.botaoSacaPP.Name = "botaoSacaPP";
            this.botaoSacaPP.Size = new System.Drawing.Size(75, 23);
            this.botaoSacaPP.TabIndex = 13;
            this.botaoSacaPP.Text = "Saque PP";
            this.botaoSacaPP.UseVisualStyleBackColor = true;
            this.botaoSacaPP.Click += new System.EventHandler(this.botaoSacaPP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total das contas";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(53, 361);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 15;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // textoTitularCombo
            // 
            this.textoTitularCombo.Location = new System.Drawing.Point(53, 398);
            this.textoTitularCombo.Name = "textoTitularCombo";
            this.textoTitularCombo.Size = new System.Drawing.Size(100, 20);
            this.textoTitularCombo.TabIndex = 16;
            // 
            // textoNumeroCombo
            // 
            this.textoNumeroCombo.Location = new System.Drawing.Point(53, 436);
            this.textoNumeroCombo.Name = "textoNumeroCombo";
            this.textoNumeroCombo.Size = new System.Drawing.Size(100, 20);
            this.textoNumeroCombo.TabIndex = 17;
            this.textoNumeroCombo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textoSaldoCombo
            // 
            this.textoSaldoCombo.Location = new System.Drawing.Point(53, 472);
            this.textoSaldoCombo.Name = "textoSaldoCombo";
            this.textoSaldoCombo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldoCombo.TabIndex = 18;
            // 
            // textoValorComboBox
            // 
            this.textoValorComboBox.Location = new System.Drawing.Point(210, 471);
            this.textoValorComboBox.Name = "textoValorComboBox";
            this.textoValorComboBox.Size = new System.Drawing.Size(100, 20);
            this.textoValorComboBox.TabIndex = 19;
            // 
            // botaoSacarComboBox
            // 
            this.botaoSacarComboBox.Location = new System.Drawing.Point(342, 436);
            this.botaoSacarComboBox.Name = "botaoSacarComboBox";
            this.botaoSacarComboBox.Size = new System.Drawing.Size(75, 23);
            this.botaoSacarComboBox.TabIndex = 20;
            this.botaoSacarComboBox.Text = "Sacar";
            this.botaoSacarComboBox.UseVisualStyleBackColor = true;
            this.botaoSacarComboBox.Click += new System.EventHandler(this.botaoSacarComboBox_Click);
            // 
            // botaoDepositarComboBox
            // 
            this.botaoDepositarComboBox.Location = new System.Drawing.Point(342, 468);
            this.botaoDepositarComboBox.Name = "botaoDepositarComboBox";
            this.botaoDepositarComboBox.Size = new System.Drawing.Size(75, 23);
            this.botaoDepositarComboBox.TabIndex = 21;
            this.botaoDepositarComboBox.Text = "Depositar";
            this.botaoDepositarComboBox.UseVisualStyleBackColor = true;
            this.botaoDepositarComboBox.Click += new System.EventHandler(this.botaoDepositarComboBox_Click);
            // 
            // destinoDaTransferencia
            // 
            this.destinoDaTransferencia.FormattingEnabled = true;
            this.destinoDaTransferencia.Location = new System.Drawing.Point(594, 361);
            this.destinoDaTransferencia.Name = "destinoDaTransferencia";
            this.destinoDaTransferencia.Size = new System.Drawing.Size(121, 21);
            this.destinoDaTransferencia.TabIndex = 22;
            this.destinoDaTransferencia.SelectedIndexChanged += new System.EventHandler(this.destinoDaTransferencia_SelectedIndexChanged);
            // 
            // textoTitularDestino
            // 
            this.textoTitularDestino.Location = new System.Drawing.Point(594, 398);
            this.textoTitularDestino.Name = "textoTitularDestino";
            this.textoTitularDestino.Size = new System.Drawing.Size(100, 20);
            this.textoTitularDestino.TabIndex = 23;
            // 
            // textoNumeroDestino
            // 
            this.textoNumeroDestino.Location = new System.Drawing.Point(594, 439);
            this.textoNumeroDestino.Name = "textoNumeroDestino";
            this.textoNumeroDestino.Size = new System.Drawing.Size(100, 20);
            this.textoNumeroDestino.TabIndex = 24;
            // 
            // textoSaldoDestino
            // 
            this.textoSaldoDestino.Location = new System.Drawing.Point(594, 472);
            this.textoSaldoDestino.Name = "textoSaldoDestino";
            this.textoSaldoDestino.Size = new System.Drawing.Size(100, 20);
            this.textoSaldoDestino.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Conta destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Conta origem";
            // 
            // botaoTransferir
            // 
            this.botaoTransferir.Location = new System.Drawing.Point(342, 398);
            this.botaoTransferir.Name = "botaoTransferir";
            this.botaoTransferir.Size = new System.Drawing.Size(75, 23);
            this.botaoTransferir.TabIndex = 28;
            this.botaoTransferir.Text = "Transferir";
            this.botaoTransferir.UseVisualStyleBackColor = true;
            this.botaoTransferir.Click += new System.EventHandler(this.botaoTransferir_Click);
            // 
            // botaoImposto
            // 
            this.botaoImposto.Location = new System.Drawing.Point(667, 39);
            this.botaoImposto.Name = "botaoImposto";
            this.botaoImposto.Size = new System.Drawing.Size(75, 23);
            this.botaoImposto.TabIndex = 29;
            this.botaoImposto.Text = "Imposto";
            this.botaoImposto.UseVisualStyleBackColor = true;
            this.botaoImposto.Click += new System.EventHandler(this.botaoImposto_Click);
            // 
            // botaoCadastrarNovaConta
            // 
            this.botaoCadastrarNovaConta.Location = new System.Drawing.Point(667, 96);
            this.botaoCadastrarNovaConta.Name = "botaoCadastrarNovaConta";
            this.botaoCadastrarNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastrarNovaConta.TabIndex = 30;
            this.botaoCadastrarNovaConta.Text = "Nova Conta";
            this.botaoCadastrarNovaConta.UseVisualStyleBackColor = true;
            this.botaoCadastrarNovaConta.Click += new System.EventHandler(this.botaoCadastrarNovaConta_Click);
            // 
            // botaoLINQ
            // 
            this.botaoLINQ.Location = new System.Drawing.Point(667, 167);
            this.botaoLINQ.Name = "botaoLINQ";
            this.botaoLINQ.Size = new System.Drawing.Size(75, 23);
            this.botaoLINQ.TabIndex = 31;
            this.botaoLINQ.Text = "LINQ";
            this.botaoLINQ.UseVisualStyleBackColor = true;
            this.botaoLINQ.Click += new System.EventHandler(this.botaoLINQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 522);
            this.Controls.Add(this.botaoLINQ);
            this.Controls.Add(this.botaoCadastrarNovaConta);
            this.Controls.Add(this.botaoImposto);
            this.Controls.Add(this.botaoTransferir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textoSaldoDestino);
            this.Controls.Add(this.textoNumeroDestino);
            this.Controls.Add(this.textoTitularDestino);
            this.Controls.Add(this.destinoDaTransferencia);
            this.Controls.Add(this.botaoDepositarComboBox);
            this.Controls.Add(this.botaoSacarComboBox);
            this.Controls.Add(this.textoValorComboBox);
            this.Controls.Add(this.textoSaldoCombo);
            this.Controls.Add(this.textoNumeroCombo);
            this.Controls.Add(this.textoTitularCombo);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botaoSacaPP);
            this.Controls.Add(this.botaoDepositaPP);
            this.Controls.Add(this.textoTotalizador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoSacaCC);
            this.Controls.Add(this.botaoDepositaCC);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoDepositaCC;
        private System.Windows.Forms.Button botaoSacaCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoTotalizador;
        private System.Windows.Forms.Button botaoDepositaPP;
        private System.Windows.Forms.Button botaoSacaPP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.TextBox textoTitularCombo;
        private System.Windows.Forms.TextBox textoNumeroCombo;
        private System.Windows.Forms.TextBox textoSaldoCombo;
        private System.Windows.Forms.TextBox textoValorComboBox;
        private System.Windows.Forms.Button botaoSacarComboBox;
        private System.Windows.Forms.Button botaoDepositarComboBox;
        private System.Windows.Forms.ComboBox destinoDaTransferencia;
        private System.Windows.Forms.TextBox textoTitularDestino;
        private System.Windows.Forms.TextBox textoNumeroDestino;
        private System.Windows.Forms.TextBox textoSaldoDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botaoTransferir;
        private System.Windows.Forms.Button botaoImposto;
        private System.Windows.Forms.Button botaoCadastrarNovaConta;
        private System.Windows.Forms.Button botaoLINQ;
    }
}

