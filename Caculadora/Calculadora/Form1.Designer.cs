namespace Calculadora
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
            tbDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPunto = new Button();
            btn0 = new Button();
            btnIgual = new Button();
            btnResta = new Button();
            btnLinpiar = new Button();
            btnSuma = new Button();
            btnMulti = new Button();
            btnDivision = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(12, 24);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(261, 50);
            tbDisplay.TabIndex = 1;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.Highlight;
            btn7.Location = new Point(12, 169);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 44);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.MenuHighlight;
            btn8.Location = new Point(104, 169);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 44);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.MenuHighlight;
            btn9.Location = new Point(198, 169);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 44);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 229);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 43);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.MenuHighlight;
            btn5.Location = new Point(104, 229);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 43);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.MenuHighlight;
            btn6.Location = new Point(198, 229);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 43);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 291);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 40);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(104, 291);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 40);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(198, 291);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 40);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btnPunto
            // 
            btnPunto.Location = new Point(12, 347);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(75, 41);
            btnPunto.TabIndex = 13;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(104, 347);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 41);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(198, 347);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 41);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(83, 98);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(43, 50);
            btnResta.TabIndex = 18;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnLinpiar
            // 
            btnLinpiar.Location = new Point(98, 394);
            btnLinpiar.Name = "btnLinpiar";
            btnLinpiar.Size = new Size(106, 50);
            btnLinpiar.TabIndex = 19;
            btnLinpiar.Text = "C";
            btnLinpiar.UseVisualStyleBackColor = true;
            btnLinpiar.Click += btnLinpiar_Click;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(12, 98);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(43, 50);
            btnSuma.TabIndex = 20;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += button1_Click_1;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(152, 98);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(52, 50);
            btnMulti.TabIndex = 21;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(225, 98);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(48, 50);
            btnDivision.TabIndex = 22;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 450);
            Controls.Add(btnDivision);
            Controls.Add(btnMulti);
            Controls.Add(btnSuma);
            Controls.Add(btnLinpiar);
            Controls.Add(btnResta);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btnPunto);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(tbDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPunto;
        private Button btn0;
        private Button btnIgual;
        private Button btnResta;
        private Button btnLinpiar;
        private Button btnSuma;
        private Button btnMulti;
        private Button btnDivision;
    }
}