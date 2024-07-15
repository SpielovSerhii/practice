namespace Lab15._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;

            string lineToReverse = firstName + ' ' + lastName;

            string reversedLine = ReverseString(lineToReverse);

            label4.Text = reversedLine;

            int length = label4.Text.Length;
            label6.Text = $"{length}";
        }
        private string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.Handled = true;
            }
        }

        private void buttonToSaveFile_Click(object sender, EventArgs e)
        {
            string fileName = textBoxFileName.Text;

            string textToSave = label4.Text;

            File.WriteAllText(fileName + ".txt", textToSave);

            MessageBox.Show("Рядок успішно збережено у файл.");
        }

        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            string fileName = textBox3.Text + ".txt";

            try
            {
                string textToRead = File.ReadAllText(fileName);
                label9.Text = textToRead;
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}
