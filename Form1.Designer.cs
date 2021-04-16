namespace Tarefa_Exercicio_2
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
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_Cpf = new System.Windows.Forms.TextBox();
            this.txb_Num = new System.Windows.Forms.TextBox();
            this.txb_Agencia = new System.Windows.Forms.TextBox();
            this.txb_Saldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Limite = new System.Windows.Forms.TextBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Ler = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.txb_Valor = new System.Windows.Forms.TextBox();
            this.btn_Dep = new System.Windows.Forms.Button();
            this.btn_Saq = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(118, 52);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(100, 20);
            this.txb_Nome.TabIndex = 0;
            // 
            // txb_Cpf
            // 
            this.txb_Cpf.Location = new System.Drawing.Point(118, 78);
            this.txb_Cpf.Name = "txb_Cpf";
            this.txb_Cpf.Size = new System.Drawing.Size(100, 20);
            this.txb_Cpf.TabIndex = 1;
            // 
            // txb_Num
            // 
            this.txb_Num.Location = new System.Drawing.Point(118, 104);
            this.txb_Num.Name = "txb_Num";
            this.txb_Num.Size = new System.Drawing.Size(100, 20);
            this.txb_Num.TabIndex = 2;
            // 
            // txb_Agencia
            // 
            this.txb_Agencia.Location = new System.Drawing.Point(118, 130);
            this.txb_Agencia.Name = "txb_Agencia";
            this.txb_Agencia.Size = new System.Drawing.Size(100, 20);
            this.txb_Agencia.TabIndex = 3;
            // 
            // txb_Saldo
            // 
            this.txb_Saldo.Location = new System.Drawing.Point(118, 156);
            this.txb_Saldo.Name = "txb_Saldo";
            this.txb_Saldo.ReadOnly = true;
            this.txb_Saldo.Size = new System.Drawing.Size(100, 20);
            this.txb_Saldo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cpf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número Conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saldo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Limite:";
            // 
            // txb_Limite
            // 
            this.txb_Limite.Location = new System.Drawing.Point(118, 182);
            this.txb_Limite.Name = "txb_Limite";
            this.txb_Limite.ReadOnly = true;
            this.txb_Limite.Size = new System.Drawing.Size(100, 20);
            this.txb_Limite.TabIndex = 11;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(47, 208);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gravar.TabIndex = 12;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Ler
            // 
            this.btn_Ler.Location = new System.Drawing.Point(128, 208);
            this.btn_Ler.Name = "btn_Ler";
            this.btn_Ler.Size = new System.Drawing.Size(75, 23);
            this.btn_Ler.TabIndex = 13;
            this.btn_Ler.Text = "Ler";
            this.btn_Ler.UseVisualStyleBackColor = true;
            this.btn_Ler.Click += new System.EventHandler(this.btn_Ler_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(209, 208);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 14;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // txb_Valor
            // 
            this.txb_Valor.Location = new System.Drawing.Point(52, 27);
            this.txb_Valor.Name = "txb_Valor";
            this.txb_Valor.Size = new System.Drawing.Size(100, 20);
            this.txb_Valor.TabIndex = 15;
            // 
            // btn_Dep
            // 
            this.btn_Dep.Location = new System.Drawing.Point(18, 50);
            this.btn_Dep.Name = "btn_Dep";
            this.btn_Dep.Size = new System.Drawing.Size(75, 23);
            this.btn_Dep.TabIndex = 16;
            this.btn_Dep.Text = "Deposito";
            this.btn_Dep.UseVisualStyleBackColor = true;
            this.btn_Dep.Click += new System.EventHandler(this.btn_Dep_Click);
            // 
            // btn_Saq
            // 
            this.btn_Saq.Location = new System.Drawing.Point(99, 50);
            this.btn_Saq.Name = "btn_Saq";
            this.btn_Saq.Size = new System.Drawing.Size(75, 23);
            this.btn_Saq.TabIndex = 17;
            this.btn_Saq.Text = "Saque";
            this.btn_Saq.UseVisualStyleBackColor = true;
            this.btn_Saq.Click += new System.EventHandler(this.btn_Saq_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "CAIXA ELETRÔNICO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Saq);
            this.groupBox1.Controls.Add(this.txb_Valor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_Dep);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(57, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAQUE/DEPÓSITO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Ler);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.txb_Limite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Saldo);
            this.Controls.Add(this.txb_Agencia);
            this.Controls.Add(this.txb_Num);
            this.Controls.Add(this.txb_Cpf);
            this.Controls.Add(this.txb_Nome);
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Cpf;
        private System.Windows.Forms.TextBox txb_Num;
        private System.Windows.Forms.TextBox txb_Agencia;
        private System.Windows.Forms.TextBox txb_Saldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Limite;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Ler;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.TextBox txb_Valor;
        private System.Windows.Forms.Button btn_Dep;
        private System.Windows.Forms.Button btn_Saq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

