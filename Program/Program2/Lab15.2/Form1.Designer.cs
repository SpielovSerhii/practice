namespace Lab15._2
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxFileName = new TextBox();
            label7 = new Label();
            buttonToSaveFile = new Button();
            label8 = new Label();
            label9 = new Label();
            buttonReadFromFile = new Button();
            textBox3 = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 24);
            label1.TabIndex = 0;
            label1.Text = "Прізвище:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 24);
            label2.TabIndex = 1;
            label2.Text = "Ім'я:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(135, 19);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "наприклад, Спєлов";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(79, 50);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "наприклад, Сергій";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 3;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(199, 94);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(242, 22);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(216, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(214, 18);
            label3.TabIndex = 5;
            label3.Text = "Результат виконаня програми:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(256, 157);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 18);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(251, 188);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 18);
            label5.TabIndex = 7;
            label5.Text = "Кількість символів:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(309, 212);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 18);
            label6.TabIndex = 8;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFileName.Location = new Point(300, 266);
            textBoxFileName.Margin = new Padding(2, 1, 2, 1);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.PlaceholderText = "наприклад, text";
            textBoxFileName.Size = new Size(255, 23);
            textBoxFileName.TabIndex = 10;
            textBoxFileName.Text = "savingString";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 266);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(272, 24);
            label7.TabIndex = 9;
            label7.Text = "Ім'я файлу для збереження:";
            // 
            // buttonToSaveFile
            // 
            buttonToSaveFile.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonToSaveFile.Location = new Point(199, 304);
            buttonToSaveFile.Margin = new Padding(2, 1, 2, 1);
            buttonToSaveFile.Name = "buttonToSaveFile";
            buttonToSaveFile.Size = new Size(242, 22);
            buttonToSaveFile.TabIndex = 11;
            buttonToSaveFile.Text = "Зберегти файл";
            buttonToSaveFile.UseVisualStyleBackColor = true;
            buttonToSaveFile.Click += buttonToSaveFile_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(216, 450);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(196, 18);
            label8.TabIndex = 12;
            label8.Text = "Результат відкриття файлу:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(256, 485);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 18);
            label9.TabIndex = 13;
            // 
            // buttonReadFromFile
            // 
            buttonReadFromFile.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReadFromFile.Location = new Point(199, 407);
            buttonReadFromFile.Margin = new Padding(2, 1, 2, 1);
            buttonReadFromFile.Name = "buttonReadFromFile";
            buttonReadFromFile.Size = new Size(242, 22);
            buttonReadFromFile.TabIndex = 14;
            buttonReadFromFile.Text = "Відкрити файл";
            buttonReadFromFile.UseVisualStyleBackColor = true;
            buttonReadFromFile.Click += buttonReadFromFile_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(276, 359);
            textBox3.Margin = new Padding(2, 1, 2, 1);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "наприклад, text";
            textBox3.Size = new Size(255, 23);
            textBox3.TabIndex = 16;
            textBox3.Text = "savingString";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(11, 356);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(249, 24);
            label10.TabIndex = 15;
            label10.Text = "Ім'я файлу для відкриття:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(646, 562);
            Controls.Add(textBox3);
            Controls.Add(label10);
            Controls.Add(buttonReadFromFile);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(buttonToSaveFile);
            Controls.Add(textBoxFileName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text reversing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxFileName;
        private Label label7;
        private Button buttonToSaveFile;
        private Label label8;
        private Label label9;
        private Button buttonReadFromFile;
        private TextBox textBox3;
        private Label label10;
    }
}
