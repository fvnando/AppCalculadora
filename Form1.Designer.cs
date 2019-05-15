namespace AppCalculadora1
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
            this.btNumerador = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_soma = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_multiplicacao = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.bt_divisao = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.bt_subtracao = new System.Windows.Forms.Button();
            this.bt_virgula = new System.Windows.Forms.Button();
            this.labelValor = new System.Windows.Forms.Label();
            this.bt_CE = new System.Windows.Forms.Button();
            this.bt_Igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNumerador
            // 
            this.btNumerador.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btNumerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNumerador.Location = new System.Drawing.Point(12, 126);
            this.btNumerador.Name = "btNumerador";
            this.btNumerador.Size = new System.Drawing.Size(70, 53);
            this.btNumerador.TabIndex = 0;
            this.btNumerador.Text = "7";
            this.btNumerador.UseVisualStyleBackColor = true;
            this.btNumerador.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValor
            // 
            this.txtValor.AutoSize = true;
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(12, 9);
            this.txtValor.MaximumSize = new System.Drawing.Size(300, 80);
            this.txtValor.MinimumSize = new System.Drawing.Size(300, 80);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(300, 80);
            this.txtValor.TabIndex = 1;
            this.txtValor.Text = "0";
            this.txtValor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "6";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_soma
            // 
            this.bt_soma.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bt_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_soma.Location = new System.Drawing.Point(242, 185);
            this.bt_soma.Name = "bt_soma";
            this.bt_soma.Size = new System.Drawing.Size(70, 53);
            this.bt_soma.TabIndex = 3;
            this.bt_soma.Text = "+";
            this.bt_soma.UseVisualStyleBackColor = true;
            this.bt_soma.Click += new System.EventHandler(this.bt_soma_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(90, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "5";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_multiplicacao
            // 
            this.bt_multiplicacao.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bt_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_multiplicacao.Location = new System.Drawing.Point(242, 126);
            this.bt_multiplicacao.Name = "bt_multiplicacao";
            this.bt_multiplicacao.Size = new System.Drawing.Size(70, 53);
            this.bt_multiplicacao.TabIndex = 6;
            this.bt_multiplicacao.Text = "*";
            this.bt_multiplicacao.UseVisualStyleBackColor = true;
            this.bt_multiplicacao.Click += new System.EventHandler(this.bt_multiplicacao_Click);
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(166, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 53);
            this.button6.TabIndex = 7;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(88, 126);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 53);
            this.button7.TabIndex = 8;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(166, 244);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 53);
            this.button8.TabIndex = 9;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_divisao
            // 
            this.bt_divisao.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bt_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_divisao.Location = new System.Drawing.Point(242, 244);
            this.bt_divisao.Name = "bt_divisao";
            this.bt_divisao.Size = new System.Drawing.Size(70, 53);
            this.bt_divisao.TabIndex = 10;
            this.bt_divisao.Text = "/";
            this.bt_divisao.UseVisualStyleBackColor = true;
            this.bt_divisao.Click += new System.EventHandler(this.bt_divisao_Click);
            // 
            // button10
            // 
            this.button10.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(88, 244);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 53);
            this.button10.TabIndex = 11;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(12, 244);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 53);
            this.button11.TabIndex = 12;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            // 
            // btC
            // 
            this.btC.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.Location = new System.Drawing.Point(12, 362);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(70, 53);
            this.btC.TabIndex = 13;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // button13
            // 
            this.button13.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(12, 303);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(146, 53);
            this.button13.TabIndex = 14;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_subtracao
            // 
            this.bt_subtracao.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bt_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_subtracao.Location = new System.Drawing.Point(242, 303);
            this.bt_subtracao.Name = "bt_subtracao";
            this.bt_subtracao.Size = new System.Drawing.Size(70, 53);
            this.bt_subtracao.TabIndex = 15;
            this.bt_subtracao.Text = "-";
            this.bt_subtracao.UseVisualStyleBackColor = true;
            this.bt_subtracao.Click += new System.EventHandler(this.bt_subtracao_Click);
            // 
            // bt_virgula
            // 
            this.bt_virgula.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bt_virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_virgula.Location = new System.Drawing.Point(164, 303);
            this.bt_virgula.Name = "bt_virgula";
            this.bt_virgula.Size = new System.Drawing.Size(70, 53);
            this.bt_virgula.TabIndex = 16;
            this.bt_virgula.Text = ",";
            this.bt_virgula.UseVisualStyleBackColor = true;
            this.bt_virgula.Click += new System.EventHandler(this.Bt_virgula);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(17, 13);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(0, 25);
            this.labelValor.TabIndex = 18;
            // 
            // bt_CE
            // 
            this.bt_CE.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bt_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CE.Location = new System.Drawing.Point(88, 362);
            this.bt_CE.Name = "bt_CE";
            this.bt_CE.Size = new System.Drawing.Size(70, 53);
            this.bt_CE.TabIndex = 19;
            this.bt_CE.Text = "CE";
            this.bt_CE.UseVisualStyleBackColor = true;
            this.bt_CE.Click += new System.EventHandler(this.bt_CE_Click);
            // 
            // bt_Igual
            // 
            this.bt_Igual.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bt_Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Igual.Location = new System.Drawing.Point(166, 362);
            this.bt_Igual.Name = "bt_Igual";
            this.bt_Igual.Size = new System.Drawing.Size(146, 53);
            this.bt_Igual.TabIndex = 20;
            this.bt_Igual.Text = "=";
            this.bt_Igual.UseVisualStyleBackColor = true;
            this.bt_Igual.Click += new System.EventHandler(this.bt_Igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(325, 418);
            this.Controls.Add(this.bt_Igual);
            this.Controls.Add(this.bt_CE);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.bt_virgula);
            this.Controls.Add(this.bt_subtracao);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.bt_divisao);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bt_multiplicacao);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_soma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btNumerador);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNumerador;
        private System.Windows.Forms.Label txtValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_soma;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_multiplicacao;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button bt_divisao;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button bt_subtracao;
        private System.Windows.Forms.Button bt_virgula;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button bt_CE;
        private System.Windows.Forms.Button bt_Igual;
    }
}

