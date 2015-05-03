namespace Capitulo4Formularios
{
    partial class CadastroDeContas
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
            this.label1 = new System.Windows.Forms.Label();
            this.textoNovoTitular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNovoNumero = new System.Windows.Forms.TextBox();
            this.botaoCadastrarNovaConta = new System.Windows.Forms.Button();
            this.comboTipoDeConta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular";
            // 
            // textoNovoTitular
            // 
            this.textoNovoTitular.Location = new System.Drawing.Point(69, 96);
            this.textoNovoTitular.Name = "textoNovoTitular";
            this.textoNovoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoNovoTitular.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número da conta";
            // 
            // textoNovoNumero
            // 
            this.textoNovoNumero.Location = new System.Drawing.Point(69, 155);
            this.textoNovoNumero.Name = "textoNovoNumero";
            this.textoNovoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNovoNumero.TabIndex = 3;
            // 
            // botaoCadastrarNovaConta
            // 
            this.botaoCadastrarNovaConta.Location = new System.Drawing.Point(69, 226);
            this.botaoCadastrarNovaConta.Name = "botaoCadastrarNovaConta";
            this.botaoCadastrarNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastrarNovaConta.TabIndex = 4;
            this.botaoCadastrarNovaConta.Text = "Cadastrar";
            this.botaoCadastrarNovaConta.UseVisualStyleBackColor = true;
            this.botaoCadastrarNovaConta.Click += new System.EventHandler(this.botaoCadastrarNovaConta_Click);
            // 
            // comboTipoDeConta
            // 
            this.comboTipoDeConta.FormattingEnabled = true;
            this.comboTipoDeConta.Location = new System.Drawing.Point(69, 35);
            this.comboTipoDeConta.Name = "comboTipoDeConta";
            this.comboTipoDeConta.Size = new System.Drawing.Size(121, 21);
            this.comboTipoDeConta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de conta";
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboTipoDeConta);
            this.Controls.Add(this.botaoCadastrarNovaConta);
            this.Controls.Add(this.textoNovoNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoNovoTitular);
            this.Controls.Add(this.label1);
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.Load += new System.EventHandler(this.CadastroDeContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoNovoTitular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNovoNumero;
        private System.Windows.Forms.Button botaoCadastrarNovaConta;
        private System.Windows.Forms.ComboBox comboTipoDeConta;
        private System.Windows.Forms.Label label3;
    }
}