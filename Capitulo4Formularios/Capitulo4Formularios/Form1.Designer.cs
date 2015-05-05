namespace Capitulo4Formularios
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
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.botaoRemoverConta = new System.Windows.Forms.Button();
            this.botaoLINQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(57, 32);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 0;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(57, 77);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 1;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(57, 124);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 2;
            this.textoNumero.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(57, 171);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 3;
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(57, 226);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(75, 23);
            this.botaoNovaConta.TabIndex = 4;
            this.botaoNovaConta.Text = "Nova conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // botaoRemoverConta
            // 
            this.botaoRemoverConta.Location = new System.Drawing.Point(152, 226);
            this.botaoRemoverConta.Name = "botaoRemoverConta";
            this.botaoRemoverConta.Size = new System.Drawing.Size(96, 23);
            this.botaoRemoverConta.TabIndex = 5;
            this.botaoRemoverConta.Text = "Remover conta";
            this.botaoRemoverConta.UseVisualStyleBackColor = true;
            this.botaoRemoverConta.Click += new System.EventHandler(this.botaoRemoverConta_Click);
            // 
            // botaoLINQ
            // 
            this.botaoLINQ.Location = new System.Drawing.Point(272, 226);
            this.botaoLINQ.Name = "botaoLINQ";
            this.botaoLINQ.Size = new System.Drawing.Size(75, 23);
            this.botaoLINQ.TabIndex = 6;
            this.botaoLINQ.Text = "LINQ";
            this.botaoLINQ.UseVisualStyleBackColor = true;
            this.botaoLINQ.Click += new System.EventHandler(this.botaoLINQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.botaoLINQ);
            this.Controls.Add(this.botaoRemoverConta);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.comboContas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button botaoRemoverConta;
        private System.Windows.Forms.Button botaoLINQ;
    }
}

