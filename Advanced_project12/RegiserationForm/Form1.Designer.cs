namespace RegiserationForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelForm = new Label();
            Id_txt = new TextBox();
            phone_txt = new TextBox();
            Age_txt = new TextBox();
            Name_txt = new TextBox();
            Save_btn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 74);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 103);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 134);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 164);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // labelForm
            // 
            labelForm.AutoSize = true;
            labelForm.Dock = DockStyle.Fill;
            labelForm.Location = new Point(0, 0);
            labelForm.Name = "labelForm";
            labelForm.Size = new Size(107, 15);
            labelForm.TabIndex = 4;
            labelForm.Text = "Registeration Form";
            // 
            // Id_txt
            // 
            Id_txt.Location = new Point(165, 66);
            Id_txt.Name = "Id_txt";
            Id_txt.Size = new Size(100, 23);
            Id_txt.TabIndex = 5;
            Id_txt.KeyPress += Id_txt_KeyPress;
            // 
            // phone_txt
            // 
            phone_txt.Location = new Point(165, 156);
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(100, 23);
            phone_txt.TabIndex = 6;
            // 
            // Age_txt
            // 
            Age_txt.Location = new Point(165, 126);
            Age_txt.Name = "Age_txt";
            Age_txt.Size = new Size(100, 23);
            Age_txt.TabIndex = 7;
            // 
            // Name_txt
            // 
            Name_txt.Location = new Point(165, 95);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(100, 23);
            Name_txt.TabIndex = 8;
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(108, 208);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(75, 23);
            Save_btn.TabIndex = 9;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(Save_btn);
            Controls.Add(Name_txt);
            Controls.Add(Age_txt);
            Controls.Add(phone_txt);
            Controls.Add(Id_txt);
            Controls.Add(labelForm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelForm;
        private TextBox Id_txt;
        private TextBox phone_txt;
        private TextBox Age_txt;
        private TextBox Name_txt;
        private Button Save_btn;
        private ContextMenuStrip contextMenuStrip1;
    }
}
