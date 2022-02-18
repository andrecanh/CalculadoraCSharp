namespace CalculadoIphone
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.bntCE = new System.Windows.Forms.Button();
            this.bntDivisao = new System.Windows.Forms.Button();
            this.btn07 = new System.Windows.Forms.Button();
            this.btn08 = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.bntMultiplicacao = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.bntSubtracao = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.bntSoma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.bntPonto = new System.Windows.Forms.Button();
            this.bntResultado = new System.Windows.Forms.Button();
            this.bntC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(36, 13);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(293, 28);
            this.txtResultado.TabIndex = 0;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.Black;
            this.lblOperacao.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOperacao.Location = new System.Drawing.Point(11, 13);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 28);
            this.lblOperacao.TabIndex = 1;
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bntCE
            // 
            this.bntCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntCE.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCE.Location = new System.Drawing.Point(11, 53);
            this.bntCE.Name = "bntCE";
            this.bntCE.Size = new System.Drawing.Size(117, 55);
            this.bntCE.TabIndex = 2;
            this.bntCE.Text = "CE";
            this.bntCE.UseVisualStyleBackColor = false;
            this.bntCE.Click += new System.EventHandler(this.bntCE_Click);
            // 
            // bntDivisao
            // 
            this.bntDivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntDivisao.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDivisao.ForeColor = System.Drawing.Color.White;
            this.bntDivisao.Location = new System.Drawing.Point(254, 53);
            this.bntDivisao.Name = "bntDivisao";
            this.bntDivisao.Size = new System.Drawing.Size(75, 55);
            this.bntDivisao.TabIndex = 4;
            this.bntDivisao.Text = "÷";
            this.bntDivisao.UseVisualStyleBackColor = false;
            this.bntDivisao.Click += new System.EventHandler(this.bntDivisao_Click);
            // 
            // btn07
            // 
            this.btn07.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn07.Location = new System.Drawing.Point(11, 114);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(75, 55);
            this.btn07.TabIndex = 5;
            this.btn07.Text = "7";
            this.btn07.UseVisualStyleBackColor = true;
            this.btn07.Click += new System.EventHandler(this.btn07_Click);
            // 
            // btn08
            // 
            this.btn08.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn08.Location = new System.Drawing.Point(92, 114);
            this.btn08.Name = "btn08";
            this.btn08.Size = new System.Drawing.Size(75, 55);
            this.btn08.TabIndex = 6;
            this.btn08.Text = "8";
            this.btn08.UseVisualStyleBackColor = true;
            this.btn08.Click += new System.EventHandler(this.btn08_Click);
            // 
            // btn09
            // 
            this.btn09.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn09.Location = new System.Drawing.Point(173, 114);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(75, 55);
            this.btn09.TabIndex = 7;
            this.btn09.Text = "9";
            this.btn09.UseVisualStyleBackColor = true;
            this.btn09.Click += new System.EventHandler(this.btn09_Click);
            // 
            // bntMultiplicacao
            // 
            this.bntMultiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntMultiplicacao.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMultiplicacao.ForeColor = System.Drawing.Color.White;
            this.bntMultiplicacao.Location = new System.Drawing.Point(254, 114);
            this.bntMultiplicacao.Name = "bntMultiplicacao";
            this.bntMultiplicacao.Size = new System.Drawing.Size(75, 55);
            this.bntMultiplicacao.TabIndex = 8;
            this.bntMultiplicacao.Text = "X";
            this.bntMultiplicacao.UseVisualStyleBackColor = false;
            this.bntMultiplicacao.Click += new System.EventHandler(this.bntMultiplicacao_Click);
            // 
            // btn04
            // 
            this.btn04.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn04.Location = new System.Drawing.Point(11, 175);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(75, 55);
            this.btn04.TabIndex = 9;
            this.btn04.Text = "4";
            this.btn04.UseVisualStyleBackColor = true;
            this.btn04.Click += new System.EventHandler(this.btn04_Click);
            // 
            // btn05
            // 
            this.btn05.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn05.Location = new System.Drawing.Point(92, 175);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(75, 55);
            this.btn05.TabIndex = 10;
            this.btn05.Text = "5";
            this.btn05.UseVisualStyleBackColor = true;
            this.btn05.Click += new System.EventHandler(this.btn05_Click);
            // 
            // btn06
            // 
            this.btn06.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn06.Location = new System.Drawing.Point(173, 175);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(75, 55);
            this.btn06.TabIndex = 11;
            this.btn06.Text = "6";
            this.btn06.UseVisualStyleBackColor = true;
            this.btn06.Click += new System.EventHandler(this.btn06_Click);
            // 
            // bntSubtracao
            // 
            this.bntSubtracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntSubtracao.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSubtracao.ForeColor = System.Drawing.Color.White;
            this.bntSubtracao.Location = new System.Drawing.Point(254, 175);
            this.bntSubtracao.Name = "bntSubtracao";
            this.bntSubtracao.Size = new System.Drawing.Size(75, 55);
            this.bntSubtracao.TabIndex = 12;
            this.bntSubtracao.Text = "-";
            this.bntSubtracao.UseVisualStyleBackColor = false;
            this.bntSubtracao.Click += new System.EventHandler(this.bntSubtracao_Click);
            // 
            // btn01
            // 
            this.btn01.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(11, 236);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 55);
            this.btn01.TabIndex = 13;
            this.btn01.Text = "1";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn02
            // 
            this.btn02.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(92, 236);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(75, 52);
            this.btn02.TabIndex = 14;
            this.btn02.Text = "2";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // btn03
            // 
            this.btn03.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn03.Location = new System.Drawing.Point(173, 236);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(75, 52);
            this.btn03.TabIndex = 15;
            this.btn03.Text = "3";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.btn03_Click);
            // 
            // bntSoma
            // 
            this.bntSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntSoma.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSoma.ForeColor = System.Drawing.Color.White;
            this.bntSoma.Location = new System.Drawing.Point(254, 236);
            this.bntSoma.Name = "bntSoma";
            this.bntSoma.Size = new System.Drawing.Size(75, 52);
            this.bntSoma.TabIndex = 16;
            this.bntSoma.Text = "+";
            this.bntSoma.UseVisualStyleBackColor = false;
            this.bntSoma.Click += new System.EventHandler(this.bntSoma_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(11, 294);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(156, 55);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button16_Click);
            // 
            // bntPonto
            // 
            this.bntPonto.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPonto.Location = new System.Drawing.Point(173, 294);
            this.bntPonto.Name = "bntPonto";
            this.bntPonto.Size = new System.Drawing.Size(75, 55);
            this.bntPonto.TabIndex = 18;
            this.bntPonto.Text = ".";
            this.bntPonto.UseVisualStyleBackColor = true;
            this.bntPonto.Click += new System.EventHandler(this.bntPonto_Click);
            // 
            // bntResultado
            // 
            this.bntResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntResultado.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntResultado.ForeColor = System.Drawing.Color.White;
            this.bntResultado.Location = new System.Drawing.Point(256, 294);
            this.bntResultado.Name = "bntResultado";
            this.bntResultado.Size = new System.Drawing.Size(75, 55);
            this.bntResultado.TabIndex = 19;
            this.bntResultado.Text = "=";
            this.bntResultado.UseVisualStyleBackColor = false;
            this.bntResultado.Click += new System.EventHandler(this.bntResultado_Click);
            // 
            // bntC
            // 
            this.bntC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntC.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntC.Location = new System.Drawing.Point(134, 53);
            this.bntC.Name = "bntC";
            this.bntC.Size = new System.Drawing.Size(114, 55);
            this.bntC.TabIndex = 20;
            this.bntC.Text = "C";
            this.bntC.UseVisualStyleBackColor = false;
            this.bntC.Click += new System.EventHandler(this.bntC_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 360);
            this.Controls.Add(this.bntC);
            this.Controls.Add(this.bntResultado);
            this.Controls.Add(this.bntPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.bntSoma);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.bntSubtracao);
            this.Controls.Add(this.btn06);
            this.Controls.Add(this.btn05);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.bntMultiplicacao);
            this.Controls.Add(this.btn09);
            this.Controls.Add(this.btn08);
            this.Controls.Add(this.btn07);
            this.Controls.Add(this.bntDivisao);
            this.Controls.Add(this.bntCE);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button bntCE;
        private System.Windows.Forms.Button bntDivisao;
        private System.Windows.Forms.Button btn07;
        private System.Windows.Forms.Button btn08;
        private System.Windows.Forms.Button btn09;
        private System.Windows.Forms.Button bntMultiplicacao;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button bntSubtracao;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button bntSoma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button bntPonto;
        private System.Windows.Forms.Button bntResultado;
        private System.Windows.Forms.Button bntC;
    }
}

