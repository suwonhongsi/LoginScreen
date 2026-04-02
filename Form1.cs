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
                MessageBox.Show("로그인에 성공하셨습니다!", "login", MessageBoxButtons.OK);
                errormsg.Visible = false;
            }
            else
            {
                // MessageBox.Show("아이디 또는 비밀번호를 잘못 입력하셨습니다.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errormsg.Visible = true;
            }
        }

        private void TextBox_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본 비프음 방지
                TextBox_2.Focus(); // 패스워드 입력창이 포커스를 갖게끔
            }
        }

        private void TextBox_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본 비프음 방지
                Button.PerformClick(); // 버튼이 눌린 것처럼 만들기
            }
        }
    }
}
