namespace LAB2
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
            groupBox1 = new GroupBox();
            label14 = new Label();
            tbInputId = new TextBox();
            tbInputScore = new TextBox();
            tbInputName = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            allsum = new TextBox();
            tbscoremin = new TextBox();
            tbscoremax = new TextBox();
            tbnamemax = new TextBox();
            tbnamemin = new TextBox();
            tbidmin = new TextBox();
            tbidmax = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(tbInputId);
            groupBox1.Controls.Add(tbInputScore);
            groupBox1.Controls.Add(tbInputName);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(94, 86);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 7;
            // 
            // tbInputId
            // 
            tbInputId.Location = new Point(86, 44);
            tbInputId.Name = "tbInputId";
            tbInputId.Size = new Size(100, 23);
            tbInputId.TabIndex = 6;
            tbInputId.TextChanged += textBox3_TextChanged;
            // 
            // tbInputScore
            // 
            tbInputScore.Location = new Point(86, 117);
            tbInputScore.Name = "tbInputScore";
            tbInputScore.Size = new Size(100, 23);
            tbInputScore.TabIndex = 5;
            tbInputScore.TextChanged += tbInputScore_TextChanged;
            // 
            // tbInputName
            // 
            tbInputName.Location = new Point(86, 80);
            tbInputName.Name = "tbInputName";
            tbInputName.Size = new Size(100, 23);
            tbInputName.TabIndex = 4;
            tbInputName.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(95, 158);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 120);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "คะแนน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 83);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 47);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "รหัสนักศึกษา";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(allsum);
            groupBox2.Controls.Add(tbscoremin);
            groupBox2.Controls.Add(tbscoremax);
            groupBox2.Controls.Add(tbnamemax);
            groupBox2.Controls.Add(tbnamemin);
            groupBox2.Controls.Add(tbidmin);
            groupBox2.Controls.Add(tbidmax);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(259, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(513, 187);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(275, 140);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 15;
            label9.Text = "คะแนนเฉลี่ย";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(404, 31);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "คะแนน";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 31);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 7;
            label7.Text = "ชื่อ-นามสกุล";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 31);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 7;
            label6.Text = "รหัสนักศึกษา";
            // 
            // allsum
            // 
            allsum.Location = new Point(373, 137);
            allsum.Name = "allsum";
            allsum.Size = new Size(100, 23);
            allsum.TabIndex = 14;
            allsum.TextChanged += allsum_TextChanged;
            // 
            // tbscoremin
            // 
            tbscoremin.Location = new Point(373, 96);
            tbscoremin.Name = "tbscoremin";
            tbscoremin.Size = new Size(100, 23);
            tbscoremin.TabIndex = 13;
            // 
            // tbscoremax
            // 
            tbscoremax.Location = new Point(373, 60);
            tbscoremax.Name = "tbscoremax";
            tbscoremax.Size = new Size(100, 23);
            tbscoremax.TabIndex = 12;
            // 
            // tbnamemax
            // 
            tbnamemax.Location = new Point(255, 60);
            tbnamemax.Name = "tbnamemax";
            tbnamemax.Size = new Size(100, 23);
            tbnamemax.TabIndex = 11;
            // 
            // tbnamemin
            // 
            tbnamemin.Location = new Point(255, 96);
            tbnamemin.Name = "tbnamemin";
            tbnamemin.Size = new Size(100, 23);
            tbnamemin.TabIndex = 10;
            // 
            // tbidmin
            // 
            tbidmin.Location = new Point(138, 96);
            tbidmin.Name = "tbidmin";
            tbidmin.Size = new Size(100, 23);
            tbidmin.TabIndex = 9;
            tbidmin.TextChanged += tbidmin_TextChanged;
            // 
            // tbidmax
            // 
            tbidmax.Location = new Point(138, 60);
            tbidmax.Name = "tbidmax";
            tbidmax.Size = new Size(100, 23);
            tbidmax.TabIndex = 7;
            tbidmax.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 99);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "คะแนนต่ำสุด";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 63);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "คะแนนสูงสุด";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(249, 244);
            label10.Name = "label10";
            label10.Size = new Size(107, 15);
            label10.TabIndex = 7;
            label10.Text = "นายกิตติพงศ์ อยู่สุภาพ";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(249, 272);
            label11.Name = "label11";
            label11.Size = new Size(106, 15);
            label11.TabIndex = 8;
            label11.Text = "นายจิรกิตติ์ โลหะวาทิน";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(249, 301);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 9;
            label12.Text = "นายธนบดี ภาคภูมิ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(249, 331);
            label13.Name = "label13";
            label13.Size = new Size(97, 15);
            label13.TabIndex = 10;
            label13.Text = "นายรณกฤต สาแก้ว ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(415, 244);
            label15.Name = "label15";
            label15.Size = new Size(72, 15);
            label15.TabIndex = 8;
            label15.Text = "663450171-7";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(415, 272);
            label16.Name = "label16";
            label16.Size = new Size(72, 15);
            label16.TabIndex = 11;
            label16.Text = "663450173-3";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(415, 301);
            label17.Name = "label17";
            label17.Size = new Size(72, 15);
            label17.TabIndex = 12;
            label17.Text = "663450175-9";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(415, 331);
            label18.Name = "label18";
            label18.Size = new Size(72, 15);
            label18.TabIndex = 13;
            label18.Text = "663450351-5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbInputId;
        private TextBox tbInputScore;
        private TextBox tbInputName;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox allsum;
        private TextBox tbscoremin;
        private TextBox tbscoremax;
        private TextBox tbnamemax;
        private TextBox tbnamemin;
        private TextBox tbidmin;
        private TextBox tbidmax;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
    }
}
