namespace CalculadoraForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btn7 = new Button();
            btnDiv = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnVirgula = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMulti = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnSubtracao = new Button();
            btnAdicao = new Button();
            btnLimpar = new Button();
            btnIgual = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(23, 21);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(276, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btn7
            // 
            btn7.Location = new Point(23, 139);
            btn7.Name = "btn7";
            btn7.Size = new Size(56, 55);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(243, 139);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(56, 55);
            btnDiv.TabIndex = 2;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(171, 139);
            btn9.Name = "btn9";
            btn9.Size = new Size(56, 55);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(97, 139);
            btn8.Name = "btn8";
            btn8.Size = new Size(56, 55);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(23, 354);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(56, 55);
            btnVirgula.TabIndex = 5;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(23, 282);
            btn1.Name = "btn1";
            btn1.Size = new Size(56, 55);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(23, 212);
            btn4.Name = "btn4";
            btn4.Size = new Size(56, 55);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(97, 282);
            btn2.Name = "btn2";
            btn2.Size = new Size(56, 55);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(97, 212);
            btn5.Name = "btn5";
            btn5.Size = new Size(56, 55);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(171, 212);
            btn6.Name = "btn6";
            btn6.Size = new Size(56, 55);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(243, 212);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(56, 55);
            btnMulti.TabIndex = 11;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(171, 282);
            btn3.Name = "btn3";
            btn3.Size = new Size(56, 55);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(97, 354);
            btn0.Name = "btn0";
            btn0.Size = new Size(56, 55);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(243, 282);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(56, 55);
            btnSubtracao.TabIndex = 14;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(243, 354);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(56, 55);
            btnAdicao.TabIndex = 16;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(23, 81);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(56, 38);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(171, 354);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(56, 55);
            btnIgual.TabIndex = 19;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(28, 25);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 433);
            Controls.Add(lblOperacao);
            Controls.Add(btnIgual);
            Controls.Add(btn1);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdicao);
            Controls.Add(btnSubtracao);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btnMulti);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btnVirgula);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnDiv);
            Controls.Add(btn7);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btn7;
        private Button btnDiv;
        private Button btn9;
        private Button btn8;
        private Button btnVirgula;
        private Button btn1;
        private Button btn4;
        private Button btn2;
        private Button btn5;
        private Button btn6;
        private Button btnMulti;
        private Button btn3;
        private Button btn0;
        private Button btnSubtracao;
        private Button btnAdicao;
        private Button btnLimpar;
        private Button btnIgual;
        private Label lblOperacao;
    }
}
