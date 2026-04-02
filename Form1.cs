namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_1_Enter(object sender, EventArgs e)
        {
            if (TextBox_1.Text == "아이디")
            {
                TextBox_1.Text = "";
                TextBox_1.ForeColor = Color.Black;
            }
        }

        private void TextBox_1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_1.Text))
            {
                TextBox_1.Text = "아이디";
                TextBox_1.ForeColor = Color.Silver;
            }
        }

        private void TextBox_2_Enter(object sender, EventArgs e)
        {
            if (TextBox_2.Text == "패스워드")
            {
                TextBox_2.Text = "";
                TextBox_2.ForeColor = Color.Black;
                TextBox_2.UseSystemPasswordChar = true;
            }
        }

        private void TextBox_2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_2.Text))
            {
                TextBox_2.Text = "패스워드";
                TextBox_2.ForeColor = Color.Silver;
                TextBox_2.UseSystemPasswordChar = false;
            }
        }

        private void Titlee_Click(object sender, EventArgs e)
        {

        }

        string myID = "admin";
        string myPW = "superman";

        private void Button_Click(object sender, EventArgs e)
        {
            string inputID = TextBox_1.Text;
            string inputPW = TextBox_2.Text;
            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                MessageBox.Show("로그인 실패~");
            }
        }
    }
}
