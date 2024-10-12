namespace Calculator_Winform
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
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEquals = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            txtOutputScreen = new TextBox();
            btnClear = new Button();
            btnDecimal = new Button();
            btnPosNeg = new Button();
            lblEquation = new Label();
            lblResultUpd = new Label();
            btnBackspace = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 128, 128);
            btnAdd.Location = new Point(57, 342);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(47, 22);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(255, 128, 128);
            btnSubtract.Location = new Point(110, 341);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(47, 22);
            btnSubtract.TabIndex = 1;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 128);
            btnMultiply.Location = new Point(163, 341);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(47, 22);
            btnMultiply.TabIndex = 2;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 128);
            btnDivide.Location = new Point(216, 341);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(47, 22);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(255, 128, 128);
            btnEquals.Location = new Point(214, 313);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(47, 22);
            btnEquals.TabIndex = 4;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DarkOrange;
            btn1.Location = new Point(57, 189);
            btn1.Name = "btn1";
            btn1.Size = new Size(49, 49);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DarkOrange;
            btn2.Location = new Point(107, 189);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 49);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DarkOrange;
            btn3.Location = new Point(157, 189);
            btn3.Name = "btn3";
            btn3.Size = new Size(49, 49);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNum_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DarkOrange;
            btn4.Location = new Point(57, 238);
            btn4.Name = "btn4";
            btn4.Size = new Size(49, 49);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DarkOrange;
            btn5.Location = new Point(107, 238);
            btn5.Name = "btn5";
            btn5.Size = new Size(49, 49);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DarkOrange;
            btn6.Location = new Point(157, 238);
            btn6.Name = "btn6";
            btn6.Size = new Size(49, 49);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNum_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Yellow;
            btn7.Location = new Point(57, 287);
            btn7.Name = "btn7";
            btn7.Size = new Size(49, 49);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DarkOrange;
            btn8.Location = new Point(107, 287);
            btn8.Name = "btn8";
            btn8.Size = new Size(49, 49);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DarkOrange;
            btn9.Location = new Point(157, 286);
            btn9.Name = "btn9";
            btn9.Size = new Size(49, 49);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNum_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DarkOrange;
            btn0.Location = new Point(57, 140);
            btn0.Name = "btn0";
            btn0.Size = new Size(49, 49);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNum_Click;
            // 
            // txtOutputScreen
            // 
            txtOutputScreen.BackColor = Color.Black;
            txtOutputScreen.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOutputScreen.ForeColor = Color.Lime;
            txtOutputScreen.Location = new Point(57, 91);
            txtOutputScreen.Name = "txtOutputScreen";
            txtOutputScreen.ReadOnly = true;
            txtOutputScreen.Size = new Size(212, 44);
            txtOutputScreen.TabIndex = 16;
            txtOutputScreen.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Location = new Point(107, 140);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(49, 49);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.Yellow;
            btnDecimal.Location = new Point(157, 140);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(49, 49);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnPosNeg
            // 
            btnPosNeg.BackColor = Color.Yellow;
            btnPosNeg.Location = new Point(216, 264);
            btnPosNeg.Name = "btnPosNeg";
            btnPosNeg.Size = new Size(47, 22);
            btnPosNeg.TabIndex = 19;
            btnPosNeg.Text = "+/-";
            btnPosNeg.UseVisualStyleBackColor = false;
            btnPosNeg.Click += btnPosNeg_Click;
            // 
            // lblEquation
            // 
            lblEquation.AutoSize = true;
            lblEquation.Location = new Point(57, 52);
            lblEquation.Name = "lblEquation";
            lblEquation.Size = new Size(13, 15);
            lblEquation.TabIndex = 20;
            lblEquation.Text = "0";
            // 
            // lblResultUpd
            // 
            lblResultUpd.AutoSize = true;
            lblResultUpd.Location = new Point(57, 386);
            lblResultUpd.Name = "lblResultUpd";
            lblResultUpd.Size = new Size(44, 15);
            lblResultUpd.TabIndex = 21;
            lblResultUpd.Text = "Results";
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = Color.Yellow;
            btnBackspace.Location = new Point(212, 140);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(49, 49);
            btnBackspace.TabIndex = 22;
            btnBackspace.Text = "<<";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(340, 450);
            Controls.Add(btnBackspace);
            Controls.Add(lblResultUpd);
            Controls.Add(lblEquation);
            Controls.Add(btnPosNeg);
            Controls.Add(btnDecimal);
            Controls.Add(btnClear);
            Controls.Add(txtOutputScreen);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEquals);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "MyCalc :)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEquals;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private TextBox txtOutputScreen;
        private Button btnClear;
        private Button btnDecimal;
        private Button btnPosNeg;
        private Label lblEquation;
        private Label lblResultUpd;
        private Button btnBackspace;
    }
}
