namespace RegiserationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Save_btn_Click(object sender, EventArgs e)
        {

            if (sender != null)
            {
                String data = $"Id:{Id_txt.Text}\n,Name:{Name_txt.Text}\n,Age:{Age_txt.Text}\n,Phone Number:{phone_txt.Text}\n";
                TextBox textBoxNew = new TextBox();
                textBoxNew.Text = data;
                textBoxNew.Location = new Point(300, 200);
                textBoxNew.Size = new Size(500, 500);

                Controls.Add(textBoxNew);

            }

            Id_txt.Clear();
            Name_txt.Clear();
            Age_txt.Clear();
            phone_txt.Clear();


        }

        private void Id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            // accept numbers digits only.
            //check if clicked key ob id tect box is digit or not.
            if (char.IsDigit(e.KeyChar))
            {
                Id_txt.Text += e.KeyChar;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
