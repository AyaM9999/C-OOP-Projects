namespace WinFormsCalApp
{
    public partial class Form1 : Form
    {
        public int num1, num2;
        public char op;
        public bool OperationSelectedornot = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                num1 = int.Parse(IOTextBox.Text);
                op = char.Parse(btn.Text);
                OperationSelectedornot = true;


            }

        }
        private void btn_Numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (OperationSelectedornot == true)
            {
                IOTextBox.Clear();
                OperationSelectedornot = false;
            }
            IOTextBox.Text += btn.Text;
        }


        private void btn_equal_Click(object sender, EventArgs e)
        {
            int num2 = int.Parse(IOTextBox.Text);
            IOTextBox.Clear();
            switch (op)
            {
                case '+':
                    IOTextBox.Text += (num1 + num2).ToString();
                    break;

                case '-':
                    IOTextBox.Text += (num1 - num2).ToString();
                    break;
                case '*':
                    IOTextBox.Text += (num1 * num2).ToString();
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        IOTextBox.Text += (num1 / num2).ToString();
                    }

                    break;
                case '%':
                    IOTextBox.Text += (num1 % num2).ToString();
                    break;
                default:
                    IOTextBox.Clear();
                    break;
            }
        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            IOTextBox.Clear();
            num1 = num2 = 0;
            op = ' ';


        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!IOTextBox.Text.Contains('.'))
            {
                IOTextBox.Text += ".";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
