namespace calculadora
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
            btnZero = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnquatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnPonto = new Button();
            btnRetroceder = new Button();
            btnCE = new Button();
            btnLimpar = new Button();
            btnIgual = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnAdicao = new Button();
            btnDivisao = new Button();
            txtResultado = new TextBox();
            lblOperacao = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnZero
            // 
            btnZero.Location = new Point(4, 151);
            btnZero.Margin = new Padding(1);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(51, 35);
            btnZero.TabIndex = 0;
            btnZero.Text = "0";
            btnZero.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(4, 114);
            btnUm.Margin = new Padding(1);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(51, 35);
            btnUm.TabIndex = 1;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(60, 114);
            btnDois.Margin = new Padding(1);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(51, 35);
            btnDois.TabIndex = 2;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(115, 114);
            btnTres.Margin = new Padding(1);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(51, 35);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnquatro
            // 
            btnquatro.Location = new Point(4, 78);
            btnquatro.Margin = new Padding(1);
            btnquatro.Name = "btnquatro";
            btnquatro.Size = new Size(51, 35);
            btnquatro.TabIndex = 4;
            btnquatro.Text = "4";
            btnquatro.UseVisualStyleBackColor = true;
            btnquatro.Click += btnquatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(60, 78);
            btnCinco.Margin = new Padding(1);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(51, 35);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(115, 78);
            btnSeis.Margin = new Padding(1);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(51, 35);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(4, 41);
            btnSete.Margin = new Padding(1);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(51, 35);
            btnSete.TabIndex = 7;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(60, 41);
            btnOito.Margin = new Padding(1);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(51, 35);
            btnOito.TabIndex = 8;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(115, 41);
            btnNove.Margin = new Padding(1);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(51, 35);
            btnNove.TabIndex = 9;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnPonto
            // 
            btnPonto.Location = new Point(60, 151);
            btnPonto.Margin = new Padding(1);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(51, 35);
            btnPonto.TabIndex = 10;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnRetroceder
            // 
            btnRetroceder.Location = new Point(115, 151);
            btnRetroceder.Margin = new Padding(1);
            btnRetroceder.Name = "btnRetroceder";
            btnRetroceder.Size = new Size(51, 35);
            btnRetroceder.TabIndex = 11;
            btnRetroceder.Text = "<";
            btnRetroceder.UseVisualStyleBackColor = true;
            btnRetroceder.Click += btnRetroceder_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(223, 41);
            btnCE.Margin = new Padding(1);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(51, 35);
            btnCE.TabIndex = 12;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(223, 78);
            btnLimpar.Margin = new Padding(1);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(51, 35);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(224, 115);
            btnIgual.Margin = new Padding(1);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(51, 71);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(170, 114);
            btnMultiplicacao.Margin = new Padding(1);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(51, 35);
            btnMultiplicacao.TabIndex = 3;
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(170, 78);
            btnSubtracao.Margin = new Padding(1);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(51, 35);
            btnSubtracao.TabIndex = 6;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(170, 41);
            btnAdicao.Margin = new Padding(1);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(51, 35);
            btnAdicao.TabIndex = 9;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(171, 151);
            btnDivisao.Margin = new Padding(1);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(51, 35);
            btnDivisao.TabIndex = 11;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(4, 10);
            txtResultado.Margin = new Padding(1);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(271, 23);
            txtResultado.TabIndex = 15;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(6, 13);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 98);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 17;
            label1.Text = "Dev. Leonardo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 190);
            Controls.Add(label1);
            Controls.Add(lblOperacao);
            Controls.Add(txtResultado);
            Controls.Add(btnIgual);
            Controls.Add(btnLimpar);
            Controls.Add(btnCE);
            Controls.Add(btnDivisao);
            Controls.Add(btnRetroceder);
            Controls.Add(btnPonto);
            Controls.Add(btnAdicao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnCinco);
            Controls.Add(btnquatro);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnZero);
            Margin = new Padding(1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnZero;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnquatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnPonto;
        private Button btnRetroceder;
        private Button btnCE;
        private Button btnLimpar;
        private Button btnIgual;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnAdicao;
        private Button btnDivisao;
        private TextBox txtResultado;
        private Label lblOperacao;
        private Label label1;
    }
}
