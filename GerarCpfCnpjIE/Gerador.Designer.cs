namespace GerarCpfCnpjIE
{
    partial class Gerador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerador));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCPF = new System.Windows.Forms.RadioButton();
            this.radioCNPJ = new System.Windows.Forms.RadioButton();
            this.radioPontos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioSemPontos = new System.Windows.Forms.RadioButton();
            this.edtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCPF);
            this.groupBox1.Controls.Add(this.radioCNPJ);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioCPF
            // 
            this.radioCPF.AutoSize = true;
            this.radioCPF.Location = new System.Drawing.Point(131, 19);
            this.radioCPF.Name = "radioCPF";
            this.radioCPF.Size = new System.Drawing.Size(45, 17);
            this.radioCPF.TabIndex = 4;
            this.radioCPF.TabStop = true;
            this.radioCPF.Text = "CPF";
            this.radioCPF.UseVisualStyleBackColor = true;
            // 
            // radioCNPJ
            // 
            this.radioCNPJ.AutoSize = true;
            this.radioCNPJ.Location = new System.Drawing.Point(28, 19);
            this.radioCNPJ.Name = "radioCNPJ";
            this.radioCNPJ.Size = new System.Drawing.Size(52, 17);
            this.radioCNPJ.TabIndex = 5;
            this.radioCNPJ.TabStop = true;
            this.radioCNPJ.Text = "CNPJ";
            this.radioCNPJ.UseVisualStyleBackColor = true;
            // 
            // radioPontos
            // 
            this.radioPontos.AutoSize = true;
            this.radioPontos.Location = new System.Drawing.Point(123, 19);
            this.radioPontos.Name = "radioPontos";
            this.radioPontos.Size = new System.Drawing.Size(82, 17);
            this.radioPontos.TabIndex = 6;
            this.radioPontos.TabStop = true;
            this.radioPontos.Text = "Com Pontos";
            this.radioPontos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSemPontos);
            this.groupBox2.Controls.Add(this.radioPontos);
            this.groupBox2.Location = new System.Drawing.Point(2, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 46);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // radioSemPontos
            // 
            this.radioSemPontos.AutoSize = true;
            this.radioSemPontos.Location = new System.Drawing.Point(10, 19);
            this.radioSemPontos.Name = "radioSemPontos";
            this.radioSemPontos.Size = new System.Drawing.Size(82, 17);
            this.radioSemPontos.TabIndex = 7;
            this.radioSemPontos.TabStop = true;
            this.radioSemPontos.Text = "Sem Pontos";
            this.radioSemPontos.UseVisualStyleBackColor = true;
            // 
            // edtResultado
            // 
            this.edtResultado.Location = new System.Drawing.Point(12, 104);
            this.edtResultado.Name = "edtResultado";
            this.edtResultado.ReadOnly = true;
            this.edtResultado.Size = new System.Drawing.Size(195, 20);
            this.edtResultado.TabIndex = 8;
            this.edtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 198);
            this.Controls.Add(this.edtResultado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCPF;
        private System.Windows.Forms.RadioButton radioCNPJ;
        private System.Windows.Forms.RadioButton radioPontos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSemPontos;
        private System.Windows.Forms.TextBox edtResultado;
    }
}

