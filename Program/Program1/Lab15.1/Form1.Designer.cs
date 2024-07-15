namespace Lab15._1
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 100);
            label1.Name = "label1";
            label1.Size = new Size(440, 46);
            label1.TabIndex = 0;
            label1.Text = "Введіть довжину стіни:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(150, 200);
            button1.Name = "button1";
            button1.Size = new Size(200, 100);
            button1.TabIndex = 2;
            button1.Text = "Обрахувати площу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(450, 200);
            button2.Name = "button2";
            button2.Size = new Size(200, 100);
            button2.TabIndex = 3;
            button2.Text = "Обрахувати периметр";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 400);
            label2.Name = "label2";
            label2.Size = new Size(152, 46);
            label2.TabIndex = 4;
            label2.Text = "Площа:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 500);
            label3.Name = "label3";
            label3.Size = new Size(212, 46);
            label3.TabIndex = 5;
            label3.Text = "Периметр:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(174, 400);
            label4.Name = "label4";
            label4.Size = new Size(42, 46);
            label4.TabIndex = 6;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(232, 500);
            label5.Name = "label5";
            label5.Size = new Size(42, 46);
            label5.TabIndex = 7;
            label5.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 800);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Площа та периметр будівлі";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
