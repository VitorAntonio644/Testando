namespace CalculadoraTesteGit
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.Adição = new System.Windows.Forms.RadioButton();
            this.Subtração = new System.Windows.Forms.RadioButton();
            this.Sinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resulatado = new System.Windows.Forms.Label();
            this.Multiplicação = new System.Windows.Forms.RadioButton();
            this.Divisão = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(80, 56);
            this.maskedTextBox1.Mask = "00000000000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(202, 56);
            this.maskedTextBox2.Mask = "00000000000000000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 1;
            // 
            // Adição
            // 
            this.Adição.AutoSize = true;
            this.Adição.Location = new System.Drawing.Point(39, 116);
            this.Adição.Name = "Adição";
            this.Adição.Size = new System.Drawing.Size(58, 17);
            this.Adição.TabIndex = 2;
            this.Adição.TabStop = true;
            this.Adição.Text = "Adição";
            this.Adição.UseVisualStyleBackColor = true;
            this.Adição.CheckedChanged += new System.EventHandler(this.Adição_CheckedChanged);
            // 
            // Subtração
            // 
            this.Subtração.AutoSize = true;
            this.Subtração.Location = new System.Drawing.Point(106, 116);
            this.Subtração.Name = "Subtração";
            this.Subtração.Size = new System.Drawing.Size(74, 17);
            this.Subtração.TabIndex = 3;
            this.Subtração.TabStop = true;
            this.Subtração.Text = "Subtração";
            this.Subtração.UseVisualStyleBackColor = true;
            this.Subtração.CheckedChanged += new System.EventHandler(this.Subtração_CheckedChanged);
            // 
            // Sinal
            // 
            this.Sinal.AutoSize = true;
            this.Sinal.Location = new System.Drawing.Point(186, 59);
            this.Sinal.Name = "Sinal";
            this.Sinal.Size = new System.Drawing.Size(13, 13);
            this.Sinal.TabIndex = 4;
            this.Sinal.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // Resulatado
            // 
            this.Resulatado.AutoSize = true;
            this.Resulatado.Location = new System.Drawing.Point(62, 167);
            this.Resulatado.Name = "Resulatado";
            this.Resulatado.Size = new System.Drawing.Size(13, 13);
            this.Resulatado.TabIndex = 6;
            this.Resulatado.Text = "0";
            // 
            // Multiplicação
            // 
            this.Multiplicação.AutoSize = true;
            this.Multiplicação.Location = new System.Drawing.Point(186, 116);
            this.Multiplicação.Name = "Multiplicação";
            this.Multiplicação.Size = new System.Drawing.Size(87, 17);
            this.Multiplicação.TabIndex = 7;
            this.Multiplicação.TabStop = true;
            this.Multiplicação.Text = "Multiplicação";
            this.Multiplicação.UseVisualStyleBackColor = true;
            this.Multiplicação.CheckedChanged += new System.EventHandler(this.Multiplicação_CheckedChanged);
            // 
            // Divisão
            // 
            this.Divisão.AutoSize = true;
            this.Divisão.Location = new System.Drawing.Point(279, 116);
            this.Divisão.Name = "Divisão";
            this.Divisão.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Divisão.Size = new System.Drawing.Size(60, 17);
            this.Divisão.TabIndex = 8;
            this.Divisão.TabStop = true;
            this.Divisão.Text = "Divisão";
            this.Divisão.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 189);
            this.Controls.Add(this.Divisão);
            this.Controls.Add(this.Multiplicação);
            this.Controls.Add(this.Resulatado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sinal);
            this.Controls.Add(this.Subtração);
            this.Controls.Add(this.Adição);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "Form1";
            this.Text = "Teste 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.RadioButton Adição;
        private System.Windows.Forms.RadioButton Subtração;
        private System.Windows.Forms.Label Sinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resulatado;
        private System.Windows.Forms.RadioButton Multiplicação;
        private System.Windows.Forms.RadioButton Divisão;
    }
}

