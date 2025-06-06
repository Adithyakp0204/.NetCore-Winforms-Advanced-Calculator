namespace Advanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel3 = new Panel();
            textBox1_display = new TextBox();
            panel2 = new Panel();
            btnAdd = new Button();
            btn_Equals = new Button();
            btn_mr = new Button();
            btn_dot = new Button();
            btn_Zero = new Button();
            btn_Three = new Button();
            btn_two = new Button();
            btn_One = new Button();
            btn_six = new Button();
            btn_fivw = new Button();
            btn_four = new Button();
            btn_nine = new Button();
            btn_eight = new Button();
            btn_seven = new Button();
            btn_division = new Button();
            btn_modulus = new Button();
            btn_Clear = new Button();
            btn_Multiply = new Button();
            btn_log = new Button();
            btn_tan = new Button();
            btn_Cos = new Button();
            btn_Sin = new Button();
            btn_MMinus = new Button();
            btn_MPlus = new Button();
            btn_MC = new Button();
            btn_Plus = new Button();
            tableLayoutPanel1_Main = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1_Main.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1_Main);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 402);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox1_display);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 54);
            panel3.TabIndex = 28;
            // 
            // textBox1_display
            // 
            textBox1_display.BackColor = SystemColors.InactiveBorder;
            textBox1_display.Dock = DockStyle.Fill;
            textBox1_display.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1_display.Location = new Point(0, 0);
            textBox1_display.Name = "textBox1_display";
            textBox1_display.ReadOnly = true;
            textBox1_display.Size = new Size(323, 54);
            textBox1_display.TabIndex = 0;
            textBox1_display.TextAlign = HorizontalAlignment.Right;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btn_Equals);
            panel2.Controls.Add(btn_mr);
            panel2.Controls.Add(btn_dot);
            panel2.Controls.Add(btn_Zero);
            panel2.Controls.Add(btn_Three);
            panel2.Controls.Add(btn_two);
            panel2.Controls.Add(btn_One);
            panel2.Controls.Add(btn_six);
            panel2.Controls.Add(btn_fivw);
            panel2.Controls.Add(btn_four);
            panel2.Controls.Add(btn_nine);
            panel2.Controls.Add(btn_eight);
            panel2.Controls.Add(btn_seven);
            panel2.Controls.Add(btn_division);
            panel2.Controls.Add(btn_modulus);
            panel2.Controls.Add(btn_Clear);
            panel2.Controls.Add(btn_Multiply);
            panel2.Controls.Add(btn_log);
            panel2.Controls.Add(btn_tan);
            panel2.Controls.Add(btn_Cos);
            panel2.Controls.Add(btn_Sin);
            panel2.Controls.Add(btn_MMinus);
            panel2.Controls.Add(btn_MPlus);
            panel2.Controls.Add(btn_MC);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 334);
            panel2.TabIndex = 27;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(244, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 133);
            btnAdd.TabIndex = 52;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btn_Equals
            // 
            btn_Equals.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Equals.Location = new Point(244, 279);
            btn_Equals.Name = "btn_Equals";
            btn_Equals.Size = new Size(69, 39);
            btn_Equals.TabIndex = 51;
            btn_Equals.Text = "=";
            btn_Equals.UseVisualStyleBackColor = true;
            btn_Equals.Click += btn_Equals_Click;
            // 
            // btn_mr
            // 
            btn_mr.Location = new Point(84, 3);
            btn_mr.Name = "btn_mr";
            btn_mr.Size = new Size(69, 39);
            btn_mr.TabIndex = 50;
            btn_mr.Text = "MR";
            btn_mr.UseVisualStyleBackColor = true;
            btn_mr.Click += btn_mr_Click;
            // 
            // btn_dot
            // 
            btn_dot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dot.Location = new Point(165, 278);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(69, 39);
            btn_dot.TabIndex = 49;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = true;
            btn_dot.Click += btn_dot_Click;
            // 
            // btn_Zero
            // 
            btn_Zero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Zero.Location = new Point(2, 279);
            btn_Zero.Name = "btn_Zero";
            btn_Zero.Size = new Size(150, 39);
            btn_Zero.TabIndex = 48;
            btn_Zero.Text = "0";
            btn_Zero.UseVisualStyleBackColor = true;
            btn_Zero.Click += btn_Zero_Click;
            // 
            // btn_Three
            // 
            btn_Three.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Three.Location = new Point(165, 233);
            btn_Three.Name = "btn_Three";
            btn_Three.Size = new Size(69, 39);
            btn_Three.TabIndex = 47;
            btn_Three.Text = "3";
            btn_Three.UseVisualStyleBackColor = true;
            btn_Three.Click += btn_Three_Click;
            // 
            // btn_two
            // 
            btn_two.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_two.Location = new Point(84, 232);
            btn_two.Name = "btn_two";
            btn_two.Size = new Size(69, 39);
            btn_two.TabIndex = 46;
            btn_two.Text = "2";
            btn_two.UseVisualStyleBackColor = true;
            btn_two.Click += btn_two_Click;
            // 
            // btn_One
            // 
            btn_One.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_One.Location = new Point(2, 232);
            btn_One.Name = "btn_One";
            btn_One.Size = new Size(69, 39);
            btn_One.TabIndex = 45;
            btn_One.Text = "1";
            btn_One.UseVisualStyleBackColor = true;
            btn_One.Click += btn_One_Click;
            // 
            // btn_six
            // 
            btn_six.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_six.Location = new Point(165, 185);
            btn_six.Name = "btn_six";
            btn_six.Size = new Size(69, 39);
            btn_six.TabIndex = 44;
            btn_six.Text = "6";
            btn_six.UseVisualStyleBackColor = true;
            btn_six.Click += btn_six_Click;
            // 
            // btn_fivw
            // 
            btn_fivw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_fivw.Location = new Point(84, 187);
            btn_fivw.Name = "btn_fivw";
            btn_fivw.Size = new Size(69, 39);
            btn_fivw.TabIndex = 43;
            btn_fivw.Text = "5";
            btn_fivw.UseVisualStyleBackColor = true;
            btn_fivw.Click += btn_fivw_Click;
            // 
            // btn_four
            // 
            btn_four.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_four.Location = new Point(3, 187);
            btn_four.Name = "btn_four";
            btn_four.Size = new Size(69, 39);
            btn_four.TabIndex = 42;
            btn_four.Text = "4";
            btn_four.UseVisualStyleBackColor = true;
            btn_four.Click += btn_four_Click;
            // 
            // btn_nine
            // 
            btn_nine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_nine.Location = new Point(165, 140);
            btn_nine.Name = "btn_nine";
            btn_nine.Size = new Size(69, 39);
            btn_nine.TabIndex = 41;
            btn_nine.Text = "9";
            btn_nine.UseVisualStyleBackColor = true;
            btn_nine.Click += btn_nine_Click;
            // 
            // btn_eight
            // 
            btn_eight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_eight.Location = new Point(84, 139);
            btn_eight.Name = "btn_eight";
            btn_eight.Size = new Size(69, 39);
            btn_eight.TabIndex = 40;
            btn_eight.Text = "8";
            btn_eight.UseVisualStyleBackColor = true;
            btn_eight.Click += btn_eight_Click;
            // 
            // btn_seven
            // 
            btn_seven.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_seven.Location = new Point(3, 139);
            btn_seven.Name = "btn_seven";
            btn_seven.Size = new Size(69, 39);
            btn_seven.TabIndex = 39;
            btn_seven.Text = "7";
            btn_seven.UseVisualStyleBackColor = true;
            btn_seven.Click += btn_seven_Click;
            // 
            // btn_division
            // 
            btn_division.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_division.Location = new Point(244, 92);
            btn_division.Name = "btn_division";
            btn_division.Size = new Size(69, 39);
            btn_division.TabIndex = 37;
            btn_division.Text = "/";
            btn_division.UseVisualStyleBackColor = true;
            btn_division.Click += btn_division_Click_1;
            // 
            // btn_modulus
            // 
            btn_modulus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_modulus.Location = new Point(165, 94);
            btn_modulus.Name = "btn_modulus";
            btn_modulus.Size = new Size(69, 39);
            btn_modulus.TabIndex = 36;
            btn_modulus.Text = "%";
            btn_modulus.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Clear.Location = new Point(244, 5);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(69, 39);
            btn_Clear.TabIndex = 35;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Multiply
            // 
            btn_Multiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Multiply.Location = new Point(84, 95);
            btn_Multiply.Name = "btn_Multiply";
            btn_Multiply.Size = new Size(69, 39);
            btn_Multiply.TabIndex = 34;
            btn_Multiply.Text = "*";
            btn_Multiply.UseVisualStyleBackColor = true;
            btn_Multiply.Click += btn_Multiply_Click;
            // 
            // btn_log
            // 
            btn_log.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_log.Location = new Point(244, 50);
            btn_log.Name = "btn_log";
            btn_log.Size = new Size(69, 39);
            btn_log.TabIndex = 33;
            btn_log.Text = "log";
            btn_log.UseVisualStyleBackColor = true;
            btn_log.Click += btn_log_Click;
            // 
            // btn_tan
            // 
            btn_tan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_tan.Location = new Point(165, 51);
            btn_tan.Name = "btn_tan";
            btn_tan.Size = new Size(69, 39);
            btn_tan.TabIndex = 32;
            btn_tan.Text = "tan";
            btn_tan.UseVisualStyleBackColor = true;
            btn_tan.Click += btn_tan_Click;
            // 
            // btn_Cos
            // 
            btn_Cos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cos.Location = new Point(84, 50);
            btn_Cos.Name = "btn_Cos";
            btn_Cos.Size = new Size(69, 39);
            btn_Cos.TabIndex = 31;
            btn_Cos.Text = "COS";
            btn_Cos.UseVisualStyleBackColor = true;
            btn_Cos.Click += btn_Cos_Click;
            // 
            // btn_Sin
            // 
            btn_Sin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Sin.Location = new Point(3, 49);
            btn_Sin.Name = "btn_Sin";
            btn_Sin.Size = new Size(69, 39);
            btn_Sin.TabIndex = 30;
            btn_Sin.Text = "Sin";
            btn_Sin.UseVisualStyleBackColor = true;
            btn_Sin.Click += btn_Sin_Click;
            // 
            // btn_MMinus
            // 
            btn_MMinus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_MMinus.Location = new Point(2, 96);
            btn_MMinus.Name = "btn_MMinus";
            btn_MMinus.Size = new Size(69, 39);
            btn_MMinus.TabIndex = 29;
            btn_MMinus.Text = "-";
            btn_MMinus.UseVisualStyleBackColor = true;
            btn_MMinus.Click += btn_MMinus_Click;
            // 
            // btn_MPlus
            // 
            btn_MPlus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_MPlus.Location = new Point(165, 4);
            btn_MPlus.Name = "btn_MPlus";
            btn_MPlus.Size = new Size(69, 39);
            btn_MPlus.TabIndex = 28;
            btn_MPlus.Text = "M+";
            btn_MPlus.UseVisualStyleBackColor = true;
            btn_MPlus.Click += btn_MPlus_Click;
            // 
            // btn_MC
            // 
            btn_MC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_MC.Location = new Point(2, 4);
            btn_MC.Name = "btn_MC";
            btn_MC.Size = new Size(69, 39);
            btn_MC.TabIndex = 27;
            btn_MC.Text = "MC";
            btn_MC.UseVisualStyleBackColor = true;
            btn_MC.Click += btn_MC_Click;
            // 
            // btn_Plus
            // 
            btn_Plus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Plus.Location = new Point(244, 137);
            btn_Plus.Name = "btn_Plus";
            btn_Plus.Size = new Size(69, 132);
            btn_Plus.TabIndex = 38;
            btn_Plus.Text = "+";
            btn_Plus.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1_Main
            // 
            tableLayoutPanel1_Main.ColumnCount = 1;
            tableLayoutPanel1_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1_Main.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1_Main.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1_Main.Dock = DockStyle.Fill;
            tableLayoutPanel1_Main.Location = new Point(0, 0);
            tableLayoutPanel1_Main.Name = "tableLayoutPanel1_Main";
            tableLayoutPanel1_Main.RowCount = 2;
            tableLayoutPanel1_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1_Main.Size = new Size(331, 400);
            tableLayoutPanel1_Main.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(333, 402);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1_Main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1_display;
        private Button button2;
        private Panel panel2;
        private Button btn_Equals;
        private Button btn_mr;
        private Button btn_dot;
        private Button btn_Zero;
        private Button btn_Three;
        private Button btn_two;
        private Button btn_One;
        private Button btn_six;
        private Button btn_fivw;
        private Button btn_four;
        private Button btn_nine;
        private Button btn_eight;
        private Button btn_seven;
        private Button btn_Plus;
        private Button btn_division;
        private Button btn_modulus;
        private Button btn_Clear;
        private Button btn_Multiply;
        private Button btn_log;
        private Button btn_tan;
        private Button btn_Cos;
        private Button btn_Sin;
        private Button btn_MMinus;
        private Button btn_MPlus;
        private Button btn_MC;
        private Panel panel3;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel1_Main;
        // private Button btn_Add;
    }
}
