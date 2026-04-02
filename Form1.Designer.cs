namespace LoginScreen
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
            TextBox_1 = new TextBox();
            TextBox_2 = new TextBox();
            Button = new Button();
            Titlee = new Label();
            SuspendLayout();
            // 
            // TextBox_1
            // 
            TextBox_1.Font = new Font("맑은 고딕", 21.75F);
            TextBox_1.ForeColor = SystemColors.ScrollBar;
            TextBox_1.Location = new Point(27, 164);
            TextBox_1.Name = "TextBox_1";
            TextBox_1.Size = new Size(392, 46);
            TextBox_1.TabIndex = 2;
            TextBox_1.Text = "아이디";
            TextBox_1.TextChanged += TextBox_1_TextChanged;
            TextBox_1.Enter += TextBox_1_Enter;
            TextBox_1.Leave += TextBox_1_Leave;
            // 
            // TextBox_2
            // 
            TextBox_2.Font = new Font("맑은 고딕", 21.75F);
            TextBox_2.ForeColor = SystemColors.ScrollBar;
            TextBox_2.Location = new Point(27, 225);
            TextBox_2.Name = "TextBox_2";
            TextBox_2.Size = new Size(392, 46);
            TextBox_2.TabIndex = 3;
            TextBox_2.Text = "패스워드";
            TextBox_2.TextChanged += TextBox_2_TextChanged;
            TextBox_2.Enter += TextBox_2_Enter;
            TextBox_2.Leave += TextBox_2_Leave;
            // 
            // Button
            // 
            Button.BackColor = Color.FromArgb(0, 192, 0);
            Button.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Button.ForeColor = Color.Black;
            Button.Location = new Point(129, 336);
            Button.Name = "Button";
            Button.Size = new Size(197, 73);
            Button.TabIndex = 1;
            Button.Text = "로그인";
            Button.UseVisualStyleBackColor = false;
            Button.Click += Button_Click;
            // 
            // Titlee
            // 
            Titlee.AutoSize = true;
            Titlee.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Titlee.Location = new Point(120, 31);
            Titlee.Name = "Titlee";
            Titlee.Size = new Size(207, 86);
            Titlee.TabIndex = 0;
            Titlee.Text = "Login";
            Titlee.Click += Titlee_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 461);
            Controls.Add(Titlee);
            Controls.Add(Button);
            Controls.Add(TextBox_2);
            Controls.Add(TextBox_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextBox_1;
        private TextBox TextBox_2;
        private Button Button;
        private Label Titlee;
    }
}
