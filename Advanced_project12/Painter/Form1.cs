using System.Drawing.Configuration;

namespace Painter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color c = Color.Blue;
        private void FormPaint_MouseMove(object sender, MouseEventArgs mouseEvent)
        {
            Graphics grx = CreateGraphics();
            // Drawing by Left mouse button
            if (mouseEvent.Button == MouseButtons.Left)
            {
                SolidBrush brush = new SolidBrush(c);
                grx.FillEllipse(brush, mouseEvent.X - 10, mouseEvent.Y - 10, 50, 50);
            }

            //Erase by right mouse button
            else if (mouseEvent.Button == MouseButtons.Right)
            {
                SolidBrush brushEraze = new SolidBrush(BackColor);
                grx.FillEllipse(brushEraze, mouseEvent.X - 10, mouseEvent.Y - 10, 50, 50);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
