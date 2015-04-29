namespace Curso.Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textoNumeroUm = new System.Windows.Forms.TextBox();
            this.textoNumeroDois = new System.Windows.Forms.TextBox();
            this.botaoSomar = new System.Windows.Forms.Button();
            this.botaoSubtrair = new System.Windows.Forms.Button();
            this.botaoMultiplicar = new System.Windows.Forms.Button();
            this.botaoDividir = new System.Windows.Forms.Button();
            this.textoNumeroResposta = new System.Windows.Forms.TextBox();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoNumeroUm
            // 
            this.textoNumeroUm.Location = new System.Drawing.Point(25, 27);
            this.textoNumeroUm.Name = "textoNumeroUm";
            this.textoNumeroUm.Size = new System.Drawing.Size(100, 20);
            this.textoNumeroUm.TabIndex = 0;
            // 
            // textoNumeroDois
            // 
            this.textoNumeroDois.Location = new System.Drawing.Point(147, 27);
            this.textoNumeroDois.Name = "textoNumeroDois";
            this.textoNumeroDois.Size = new System.Drawing.Size(100, 20);
            this.textoNumeroDois.TabIndex = 1;
            this.textoNumeroDois.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // botaoSomar
            // 
            this.botaoSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSomar.Location = new System.Drawing.Point(82, 78);
            this.botaoSomar.Name = "botaoSomar";
            this.botaoSomar.Size = new System.Drawing.Size(43, 23);
            this.botaoSomar.TabIndex = 2;
            this.botaoSomar.Text = "+";
            this.botaoSomar.UseVisualStyleBackColor = true;
            this.botaoSomar.Click += new System.EventHandler(this.botaoSomar_Click);
            // 
            // botaoSubtrair
            // 
            this.botaoSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSubtrair.Location = new System.Drawing.Point(147, 78);
            this.botaoSubtrair.Name = "botaoSubtrair";
            this.botaoSubtrair.Size = new System.Drawing.Size(43, 23);
            this.botaoSubtrair.TabIndex = 3;
            this.botaoSubtrair.Text = "-";
            this.botaoSubtrair.UseVisualStyleBackColor = true;
            this.botaoSubtrair.Click += new System.EventHandler(this.botaoSubtrair_Click);
            // 
            // botaoMultiplicar
            // 
            this.botaoMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMultiplicar.Location = new System.Drawing.Point(82, 120);
            this.botaoMultiplicar.Name = "botaoMultiplicar";
            this.botaoMultiplicar.Size = new System.Drawing.Size(43, 23);
            this.botaoMultiplicar.TabIndex = 4;
            this.botaoMultiplicar.Text = "*";
            this.botaoMultiplicar.UseVisualStyleBackColor = true;
            this.botaoMultiplicar.Click += new System.EventHandler(this.botaoMultiplicar_Click);
            // 
            // botaoDividir
            // 
            this.botaoDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDividir.Location = new System.Drawing.Point(147, 120);
            this.botaoDividir.Name = "botaoDividir";
            this.botaoDividir.Size = new System.Drawing.Size(43, 23);
            this.botaoDividir.TabIndex = 5;
            this.botaoDividir.Text = "/";
            this.botaoDividir.UseVisualStyleBackColor = true;
            this.botaoDividir.Click += new System.EventHandler(this.botaoDividir_Click);
            // 
            // textoNumeroResposta
            // 
            this.textoNumeroResposta.Location = new System.Drawing.Point(82, 186);
            this.textoNumeroResposta.Name = "textoNumeroResposta";
            this.textoNumeroResposta.ReadOnly = true;
            this.textoNumeroResposta.Size = new System.Drawing.Size(100, 20);
            this.textoNumeroResposta.TabIndex = 6;
            this.textoNumeroResposta.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(92, 226);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 23);
            this.botaoLimpar.TabIndex = 7;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 261);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.textoNumeroResposta);
            this.Controls.Add(this.botaoDividir);
            this.Controls.Add(this.botaoMultiplicar);
            this.Controls.Add(this.botaoSubtrair);
            this.Controls.Add(this.botaoSomar);
            this.Controls.Add(this.textoNumeroDois);
            this.Controls.Add(this.textoNumeroUm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumeroUm;
        private System.Windows.Forms.TextBox textoNumeroDois;
        private System.Windows.Forms.Button botaoSomar;
        private System.Windows.Forms.Button botaoSubtrair;
        private System.Windows.Forms.Button botaoMultiplicar;
        private System.Windows.Forms.Button botaoDividir;
        private System.Windows.Forms.TextBox textoNumeroResposta;
        private System.Windows.Forms.Button botaoLimpar;
    }
}

