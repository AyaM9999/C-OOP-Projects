namespace paint2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color c = Color.Red; //set default color to red


        private void button1_Click(object sender, EventArgs e)
        { // select color from colors palette
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                c = colorDialog1.Color;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g1 = CreateGraphics();
                SolidBrush brush = new SolidBrush(c);
                g1.FillEllipse(brush, e.X - 5, e.Y - 5, 70, 70);

            }
            else if (e.Button == MouseButtons.Right)
            {
                Graphics g2 = CreateGraphics();
                SolidBrush brush = new SolidBrush(BackColor);
                g2.FillEllipse(brush, e.X - 5, e.Y - 5, 70, 70);

            }

        }

  
    }
}
