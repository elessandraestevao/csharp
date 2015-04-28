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
            this.textoTotalizador.Location = new System.Drawing.Point(325, 351);
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
            this.label5.Location = new System.Drawing.Point(56, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total das contas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 414);
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
    }
}

