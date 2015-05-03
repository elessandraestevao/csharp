namespace CursoOOCaixaEletronico
{
    partial class CadastroDeConta
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
            this.textoTitularNovaConta = new System.Windows.Forms.TextBox();
            this.textoNumeroNovaConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoCadastrarNovaConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitularNovaConta
            // 
            this.textoTitularNovaConta.Location = new System.Drawing.Point(64, 50);
            this.textoTitularNovaConta.Name = "textoTitularNovaConta";
            this.textoTitularNovaConta.Size = new System.Drawing.Size(100, 20);
            this.textoTitularNovaConta.TabIndex = 0;
            // 
            // textoNumeroNovaConta
            // 
            this.textoNumeroNovaConta.Location = new System.Drawing.Point(64, 129);
            this.textoNumeroNovaConta.Name = "textoNumeroNovaConta";
            this.textoNumeroNovaConta.Size = new System.Drawing.Size(100, 20);
            this.textoNumeroNovaConta.TabIndex = 1;
            this.textoNumeroNovaConta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número da conta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // botaoCadastrarNovaConta
            // 
            this.botaoCadastrarNovaConta.Location = new System.Drawing.Point(64, 212);
            this.botaoCadastrarNovaConta.Name = "botaoCadastrarNovaConta";
            this.botaoCadastrarNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastrarNovaConta.TabIndex = 4;
            this.botaoCadastrarNovaConta.Text = "Cadastrar";
            this.botaoCadastrarNovaConta.UseVisualStyleBackColor = true;
            this.botaoCadastrarNovaConta.Click += new System.EventHandler(this.botaoCadastrarNovaConta_Click);
            // 
            // CadastroDeConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.botaoCadastrarNovaConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoNumeroNovaConta);
            this.Controls.Add(this.textoTitularNovaConta);
            this.Name = "CadastroDeConta";
            this.Text = "CadastroDeConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitularNovaConta;
        private System.Windows.Forms.TextBox textoNumeroNovaConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoCadastrarNovaConta;
    }
}