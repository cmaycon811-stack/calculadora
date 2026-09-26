namespace colculadora_mcf
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
            lblResultado = new Label();
            btnRetroceder = new Button();
            btnC = new Button();
            btnCE = new Button();
            btnDivisao = new Button();
            btnCinco = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            bntMutiplicacao = new Button();
            btnQuatro = new Button();
            btnSeis = new Button();
            btnSubitracao = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnAdiao = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(1, 12);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(183, 23);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "btntxtResultado";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(3, 17);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "label1";
            // 
            // btnRetroceder
            // 
            btnRetroceder.Location = new Point(3, 41);
            btnRetroceder.Name = "btnRetroceder";
            btnRetroceder.Size = new Size(38, 23);
            btnRetroceder.TabIndex = 2;
            btnRetroceder.Text = "<";
            btnRetroceder.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(47, 41);
            btnC.Name = "btnC";
            btnC.Size = new Size(41, 23);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(94, 41);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(42, 23);
            btnCE.TabIndex = 4;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(142, 41);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(42, 23);
            btnDivisao.TabIndex = 5;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(47, 99);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(41, 23);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(3, 70);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(38, 23);
            btnSete.TabIndex = 7;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(47, 70);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(41, 23);
            btnOito.TabIndex = 8;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(94, 70);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(42, 23);
            btnNove.TabIndex = 9;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // bntMutiplicacao
            // 
            bntMutiplicacao.Location = new Point(142, 70);
            bntMutiplicacao.Name = "bntMutiplicacao";
            bntMutiplicacao.Size = new Size(42, 23);
            bntMutiplicacao.TabIndex = 10;
            bntMutiplicacao.Text = "x";
            bntMutiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(3, 99);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(41, 23);
            btnQuatro.TabIndex = 11;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(94, 99);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(42, 23);
            btnSeis.TabIndex = 12;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSubitracao
            // 
            btnSubitracao.Location = new Point(142, 99);
            btnSubitracao.Name = "btnSubitracao";
            btnSubitracao.Size = new Size(42, 23);
            btnSubitracao.TabIndex = 13;
            btnSubitracao.Text = "-";
            btnSubitracao.UseVisualStyleBackColor = true;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(3, 128);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(41, 23);
            btnUm.TabIndex = 14;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(50, 128);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(38, 23);
            btnDois.TabIndex = 15;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(94, 128);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(42, 23);
            btnTres.TabIndex = 16;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnAdiao
            // 
            btnAdiao.Location = new Point(142, 128);
            btnAdiao.Name = "btnAdiao";
            btnAdiao.Size = new Size(42, 52);
            btnAdiao.TabIndex = 17;
            btnAdiao.Text = "+";
            btnAdiao.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(3, 157);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(41, 23);
            btnZero.TabIndex = 18;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(50, 157);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(38, 23);
            btnVirgula.TabIndex = 19;
            btnVirgula.Text = ".";
            btnVirgula.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(94, 157);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(42, 23);
            btnIgual.TabIndex = 20;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(195, 194);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnAdiao);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSubitracao);
            Controls.Add(btnSeis);
            Controls.Add(btnQuatro);
            Controls.Add(bntMutiplicacao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnCinco);
            Controls.Add(btnDivisao);
            Controls.Add(btnCE);
            Controls.Add(btnC);
            Controls.Add(btnRetroceder);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += textBox1_TextChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Label lblResultado;
        private Button btnRetroceder;
        private Button btnC;
        private Button btnCE;
        private Button btnDivisao;
        private Button btnCinco;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button bntMutiplicacao;
        private Button btnQuatro;
        private Button btnSeis;
        private Button btnSubitracao;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnAdiao;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnIgual;
    }
}
