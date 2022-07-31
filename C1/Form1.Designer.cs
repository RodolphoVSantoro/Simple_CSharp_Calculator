namespace C1
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
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Potencia = new System.Windows.Forms.Button();
            this.Radiciacao = new System.Windows.Forms.Button();
            this.Fatorial = new System.Windows.Forms.Button();
            this.combinacao = new System.Windows.Forms.Button();
            this.Arranjo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(47, 33);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(100, 20);
            this.n1.TabIndex = 0;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(47, 61);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(100, 20);
            this.n2.TabIndex = 1;
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(153, 30);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(75, 23);
            this.soma.TabIndex = 2;
            this.soma.Text = "Somar";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(234, 30);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(75, 23);
            this.subtracao.TabIndex = 3;
            this.subtracao.Text = "Subtrair";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(153, 59);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(75, 23);
            this.multiplicacao.TabIndex = 4;
            this.multiplicacao.Text = "Multiplicar";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(234, 59);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(75, 23);
            this.divisao.TabIndex = 5;
            this.divisao.Text = "Dividir";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "N2";
            // 
            // Potencia
            // 
            this.Potencia.Location = new System.Drawing.Point(153, 88);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(75, 23);
            this.Potencia.TabIndex = 8;
            this.Potencia.Text = "N1^N2";
            this.Potencia.UseVisualStyleBackColor = true;
            this.Potencia.Click += new System.EventHandler(this.Potencia_Click);
            // 
            // Radiciacao
            // 
            this.Radiciacao.Location = new System.Drawing.Point(153, 117);
            this.Radiciacao.Name = "Radiciacao";
            this.Radiciacao.Size = new System.Drawing.Size(156, 23);
            this.Radiciacao.TabIndex = 9;
            this.Radiciacao.Text = "Raiz Aproximada";
            this.Radiciacao.UseVisualStyleBackColor = true;
            this.Radiciacao.Click += new System.EventHandler(this.Radiciacao_Click);
            // 
            // Fatorial
            // 
            this.Fatorial.Location = new System.Drawing.Point(234, 88);
            this.Fatorial.Name = "Fatorial";
            this.Fatorial.Size = new System.Drawing.Size(75, 23);
            this.Fatorial.TabIndex = 10;
            this.Fatorial.Text = "N1!";
            this.Fatorial.UseVisualStyleBackColor = true;
            this.Fatorial.Click += new System.EventHandler(this.Fatorial_Click);
            // 
            // combinacao
            // 
            this.combinacao.Location = new System.Drawing.Point(153, 147);
            this.combinacao.Name = "combinacao";
            this.combinacao.Size = new System.Drawing.Size(75, 23);
            this.combinacao.TabIndex = 11;
            this.combinacao.Text = "C(N1,N2)";
            this.combinacao.UseVisualStyleBackColor = true;
            this.combinacao.Click += new System.EventHandler(this.combinacao_Click);
            // 
            // Arranjo
            // 
            this.Arranjo.Location = new System.Drawing.Point(234, 147);
            this.Arranjo.Name = "Arranjo";
            this.Arranjo.Size = new System.Drawing.Size(75, 23);
            this.Arranjo.TabIndex = 12;
            this.Arranjo.Text = "A(N1,N2)";
            this.Arranjo.UseVisualStyleBackColor = true;
            this.Arranjo.Click += new System.EventHandler(this.Arranjo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 185);
            this.Controls.Add(this.Arranjo);
            this.Controls.Add(this.combinacao);
            this.Controls.Add(this.Fatorial);
            this.Controls.Add(this.Radiciacao);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button Radiciacao;
        private System.Windows.Forms.Button Fatorial;
        private System.Windows.Forms.Button combinacao;
        private System.Windows.Forms.Button Arranjo;
    }
}

