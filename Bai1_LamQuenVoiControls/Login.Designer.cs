namespace Bai1_LamQuenVoiControls
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbt_Username = new System.Windows.Forms.TextBox();
            this.tbt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.cb_Robot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ShowPass = new System.Windows.Forms.CheckBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbt_Username
            // 
            this.tbt_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Username.Location = new System.Drawing.Point(213, 23);
            this.tbt_Username.Name = "tbt_Username";
            this.tbt_Username.PlaceholderText = "Enter username";
            this.tbt_Username.Size = new System.Drawing.Size(667, 34);
            this.tbt_Username.TabIndex = 0;
            this.tbt_Username.TextChanged += new System.EventHandler(this.NhapUsername_Event);
            this.tbt_Username.MouseLeave += new System.EventHandler(this.tbt_Username_MouseLeave);
            this.tbt_Username.MouseHover += new System.EventHandler(this.tbt_Username_MouseHover);
            // 
            // tbt_Password
            // 
            this.tbt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Password.Location = new System.Drawing.Point(213, 92);
            this.tbt_Password.Name = "tbt_Password";
            this.tbt_Password.PasswordChar = '*';
            this.tbt_Password.PlaceholderText = "**********";
            this.tbt_Password.Size = new System.Drawing.Size(667, 34);
            this.tbt_Password.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(213, 220);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(213, 48);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // cb_Robot
            // 
            this.cb_Robot.AutoSize = true;
            this.cb_Robot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_Robot.Location = new System.Drawing.Point(213, 164);
            this.cb_Robot.Name = "cb_Robot";
            this.cb_Robot.Size = new System.Drawing.Size(193, 32);
            this.cb_Robot.TabIndex = 3;
            this.cb_Robot.Text = "Tôi là người máy";
            this.cb_Robot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // cb_ShowPass
            // 
            this.cb_ShowPass.AutoSize = true;
            this.cb_ShowPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_ShowPass.Location = new System.Drawing.Point(516, 164);
            this.cb_ShowPass.Name = "cb_ShowPass";
            this.cb_ShowPass.Size = new System.Drawing.Size(173, 32);
            this.cb_ShowPass.TabIndex = 3;
            this.cb_ShowPass.Text = "Hiện mật khẩu";
            this.cb_ShowPass.UseVisualStyleBackColor = true;
            this.cb_ShowPass.CheckedChanged += new System.EventHandler(this.cb_ShowPass_CheckedChanged);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SignUp.Location = new System.Drawing.Point(516, 220);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(213, 48);
            this.btn_SignUp.TabIndex = 2;
            this.btn_SignUp.Text = "Đăng Ký";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(904, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_ShowPass);
            this.Controls.Add(this.cb_Robot);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tbt_Password);
            this.Controls.Add(this.tbt_Username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbt_Username;
        private TextBox tbt_Password;
        private Button btn_Login;
        private CheckBox cb_Robot;
        private Label label1;
        private Label label2;
        private CheckBox cb_ShowPass;
        private Button btn_SignUp;
    }
}