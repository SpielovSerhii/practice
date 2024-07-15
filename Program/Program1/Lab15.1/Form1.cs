namespace Lab15._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double wallLenth = Convert.ToDouble(textBox1.Text);
            double area = calulateHouseArea(wallLenth);
            label4.Text = area.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double wallLenth = Convert.ToDouble(textBox1.Text);
            double perimeter = calulateHousePerimeter(wallLenth);
            label5.Text = perimeter.ToString();
        }

        double calulateHouseArea(double lenth)
        {
            return lenth * lenth;
        }

        double calulateHousePerimeter(double lenth)
        {
            return lenth * 4;
        }
    }
}
