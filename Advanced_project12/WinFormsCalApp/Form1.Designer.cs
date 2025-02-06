namespace WinFormsCalApp
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
            IOTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btn_subtract = new Button();
            btn_Add = new Button();
            btn_clear = new Button();
            btn_multiply = new Button();
            btn_divide = new Button();
            btn_moduls = new Button();
            btn_equal = new Button();
            button0 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // IOTextBox
            // 
            IOTextBox.Dock = DockStyle.Fill;
            IOTextBox.Location = new Point(0, 0);
            IOTextBox.Name = "IOTextBox";
            IOTextBox.Size = new Size(800, 23);
            IOTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(56, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_Numbers_click;
            // 
            // button2
            // 
            button2.Location = new Point(151, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_Numbers_click;
            // 
            // button3
            // 
            button3.Location = new Point(250, 119);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_Numbers_click;
            // 
            // button4
            // 
            button4.Location = new Point(56, 160);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_Numbers_click;
            // 
            // button5
            // 
            button5.Location = new Point(151, 160);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_Numbers_click;
            // 
            // button6
            // 
            button6.Location = new Point(250, 160);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn_Numbers_click;
            // 
            // button7
            // 
            button7.Location = new Point(56, 200);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn_Numbers_click;
            // 
            // button8
            // 
            button8.Location = new Point(151, 200);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn_Numbers_click;
            // 
            // button9
            // 
            button9.Location = new Point(250, 200);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btn_Numbers_click;
            // 
            // btn_subtract
            // 
            btn_subtract.Location = new Point(445, 119);
            btn_subtract.Name = "btn_subtract";
            btn_subtract.Size = new Size(75, 23);
            btn_subtract.TabIndex = 10;
            btn_subtract.Text = "-";
            btn_subtract.UseVisualStyleBackColor = true;
            btn_subtract.Click += btn_Operation_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(364, 119);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 11;
            btn_Add.Text = "+";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Operation_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(445, 200);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 12;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.Location = new Point(364, 160);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(75, 23);
            btn_multiply.TabIndex = 13;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_Operation_Click;
            // 
            // btn_divide
            // 
            btn_divide.Location = new Point(445, 160);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(75, 23);
            btn_divide.TabIndex = 14;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_Operation_Click;
            // 
            // btn_moduls
            // 
            btn_moduls.Location = new Point(364, 200);
            btn_moduls.Name = "btn_moduls";
            btn_moduls.Size = new Size(75, 23);
            btn_moduls.TabIndex = 15;
            btn_moduls.Text = "%";
            btn_moduls.UseVisualStyleBackColor = true;
            btn_moduls.Click += btn_Operation_Click;
            // 
            // btn_equal
            // 
            btn_equal.Location = new Point(250, 241);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(75, 23);
            btn_equal.TabIndex = 16;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // button0
            // 
            button0.Location = new Point(151, 241);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 17;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(56, 241);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 19;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button11);
            Controls.Add(button0);
            Controls.Add(btn_equal);
            Controls.Add(btn_moduls);
            Controls.Add(btn_divide);
            Controls.Add(btn_multiply);
            Controls.Add(btn_clear);
            Controls.Add(btn_Add);
            Controls.Add(btn_subtract);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(IOTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox IOTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btn_subtract;
        private Button btn_Add;
        private Button btn_clear;
        private Button btn_multiply;
        private Button btn_divide;
        private Button btn_moduls;
        private Button btn_equal;
        private Button button0;
        private Button button11;
    }
}
