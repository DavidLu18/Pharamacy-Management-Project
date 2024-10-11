namespace PharmacyManagementProject.AdminUC
{
    partial class UC_AddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddUser));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TextBoxUserName = new RJcontrol.RJTextBox();
            TextBoxSDT = new RJcontrol.RJTextBox();
            label6 = new Label();
            TextBoxEmail = new RJcontrol.RJTextBox();
            label7 = new Label();
            TextBoxNhapUser = new RJcontrol.RJTextBox();
            label8 = new Label();
            TextBoxNhapPass = new RJcontrol.RJTextBox();
            panel1 = new Panel();
            ComboBoxRole = new RJcontrol.RJComboBox();
            specialButtrons1 = new RJcontrol.SpecialButtrons();
            specialButtrons2 = new RJcontrol.SpecialButtrons();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(328, 81);
            label1.TabIndex = 0;
            label1.Text = "THÊM USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label2.Location = new Point(194, 296);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Vai Trò";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label3.Location = new Point(194, 447);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label4.Location = new Point(194, 614);
            label4.Name = "label4";
            label4.Size = new Size(295, 28);
            label4.TabIndex = 3;
            label4.Text = "Ngày/Tháng/Năm sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label5.Location = new Point(194, 772);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 4;
            label5.Text = "Số Điện Thoại";
            // 
            // TextBoxUserName
            // 
            TextBoxUserName.BackColor = SystemColors.Window;
            TextBoxUserName.BorderColor = Color.FromArgb(98, 86, 202);
            TextBoxUserName.BorderFocusColor = Color.HotPink;
            TextBoxUserName.BorderRadius = 10;
            TextBoxUserName.BorderSize = 2;
            TextBoxUserName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxUserName.ForeColor = Color.FromArgb(64, 64, 64);
            TextBoxUserName.Location = new Point(194, 501);
            TextBoxUserName.Margin = new Padding(4);
            TextBoxUserName.Multiline = false;
            TextBoxUserName.Name = "TextBoxUserName";
            TextBoxUserName.Padding = new Padding(10, 7, 10, 7);
            TextBoxUserName.PasswordChar = false;
            TextBoxUserName.PlaceholderColor = Color.DarkGray;
            TextBoxUserName.PlaceholderText = "Nhập tên";
            TextBoxUserName.Size = new Size(295, 39);
            TextBoxUserName.TabIndex = 5;
            TextBoxUserName.Texts = "";
            TextBoxUserName.UnderlinedStyle = false;
            TextBoxUserName._TextChanged += rjTextBox1__TextChanged;
            // 
            // TextBoxSDT
            // 
            TextBoxSDT.BackColor = SystemColors.Window;
            TextBoxSDT.BorderColor = Color.FromArgb(98, 86, 202);
            TextBoxSDT.BorderFocusColor = Color.HotPink;
            TextBoxSDT.BorderRadius = 10;
            TextBoxSDT.BorderSize = 2;
            TextBoxSDT.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSDT.ForeColor = Color.FromArgb(64, 64, 64);
            TextBoxSDT.Location = new Point(194, 828);
            TextBoxSDT.Margin = new Padding(4);
            TextBoxSDT.Multiline = false;
            TextBoxSDT.Name = "TextBoxSDT";
            TextBoxSDT.Padding = new Padding(10, 7, 10, 7);
            TextBoxSDT.PasswordChar = false;
            TextBoxSDT.PlaceholderColor = Color.DarkGray;
            TextBoxSDT.PlaceholderText = "Nhập SĐT";
            TextBoxSDT.Size = new Size(295, 39);
            TextBoxSDT.TabIndex = 7;
            TextBoxSDT.Texts = "";
            TextBoxSDT.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label6.Location = new Point(865, 296);
            label6.Name = "label6";
            label6.Size = new Size(177, 28);
            label6.TabIndex = 8;
            label6.Text = "Địa Chỉ Email";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BackColor = SystemColors.Window;
            TextBoxEmail.BorderColor = Color.FromArgb(98, 86, 202);
            TextBoxEmail.BorderFocusColor = Color.HotPink;
            TextBoxEmail.BorderRadius = 10;
            TextBoxEmail.BorderSize = 2;
            TextBoxEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxEmail.ForeColor = Color.FromArgb(64, 64, 64);
            TextBoxEmail.Location = new Point(865, 342);
            TextBoxEmail.Margin = new Padding(4);
            TextBoxEmail.Multiline = false;
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Padding = new Padding(10, 7, 10, 7);
            TextBoxEmail.PasswordChar = false;
            TextBoxEmail.PlaceholderColor = Color.DarkGray;
            TextBoxEmail.PlaceholderText = "Email";
            TextBoxEmail.Size = new Size(295, 39);
            TextBoxEmail.TabIndex = 9;
            TextBoxEmail.Texts = "";
            TextBoxEmail.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label7.Location = new Point(865, 447);
            label7.Name = "label7";
            label7.Size = new Size(145, 28);
            label7.TabIndex = 10;
            label7.Text = "User Name";
            // 
            // TextBoxNhapUser
            // 
            TextBoxNhapUser.BackColor = SystemColors.Window;
            TextBoxNhapUser.BorderColor = Color.FromArgb(98, 86, 202);
            TextBoxNhapUser.BorderFocusColor = Color.HotPink;
            TextBoxNhapUser.BorderRadius = 10;
            TextBoxNhapUser.BorderSize = 2;
            TextBoxNhapUser.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxNhapUser.ForeColor = Color.FromArgb(64, 64, 64);
            TextBoxNhapUser.Location = new Point(865, 501);
            TextBoxNhapUser.Margin = new Padding(4);
            TextBoxNhapUser.Multiline = false;
            TextBoxNhapUser.Name = "TextBoxNhapUser";
            TextBoxNhapUser.Padding = new Padding(10, 7, 10, 7);
            TextBoxNhapUser.PasswordChar = false;
            TextBoxNhapUser.PlaceholderColor = Color.DarkGray;
            TextBoxNhapUser.PlaceholderText = "Nhập User";
            TextBoxNhapUser.Size = new Size(295, 39);
            TextBoxNhapUser.TabIndex = 11;
            TextBoxNhapUser.Texts = "";
            TextBoxNhapUser.UnderlinedStyle = false;
            TextBoxNhapUser._TextChanged += TextBoxNhapUser__TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            label8.Location = new Point(865, 614);
            label8.Name = "label8";
            label8.Size = new Size(126, 28);
            label8.TabIndex = 12;
            label8.Text = "Password";
            // 
            // TextBoxNhapPass
            // 
            TextBoxNhapPass.BackColor = SystemColors.Window;
            TextBoxNhapPass.BorderColor = Color.FromArgb(98, 86, 202);
            TextBoxNhapPass.BorderFocusColor = Color.HotPink;
            TextBoxNhapPass.BorderRadius = 10;
            TextBoxNhapPass.BorderSize = 2;
            TextBoxNhapPass.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxNhapPass.ForeColor = Color.FromArgb(64, 64, 64);
            TextBoxNhapPass.Location = new Point(865, 678);
            TextBoxNhapPass.Margin = new Padding(4);
            TextBoxNhapPass.Multiline = false;
            TextBoxNhapPass.Name = "TextBoxNhapPass";
            TextBoxNhapPass.Padding = new Padding(10, 7, 10, 7);
            TextBoxNhapPass.PasswordChar = true;
            TextBoxNhapPass.PlaceholderColor = Color.DarkGray;
            TextBoxNhapPass.PlaceholderText = "Nhập Password";
            TextBoxNhapPass.Size = new Size(295, 39);
            TextBoxNhapPass.TabIndex = 13;
            TextBoxNhapPass.Texts = "";
            TextBoxNhapPass.UnderlinedStyle = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(134, 210, 147);
            panel1.Location = new Point(686, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 580);
            panel1.TabIndex = 14;
            // 
            // ComboBoxRole
            // 
            ComboBoxRole.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxRole.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxRole.BackColor = Color.WhiteSmoke;
            ComboBoxRole.BorderColor = Color.FromArgb(98, 86, 202);
            ComboBoxRole.BorderSize = 2;
            ComboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxRole.Font = new Font("Segoe UI", 10F);
            ComboBoxRole.ForeColor = Color.DimGray;
            ComboBoxRole.IconColor = Color.MediumSpringGreen;
            ComboBoxRole.Items.AddRange(new object[] { "Quản Trị Viên", "Dược Sĩ" });
            ComboBoxRole.ListBackColor = Color.FromArgb(134, 210, 147);
            ComboBoxRole.ListTextColor = Color.DimGray;
            ComboBoxRole.Location = new Point(194, 342);
            ComboBoxRole.MinimumSize = new Size(200, 30);
            ComboBoxRole.Name = "ComboBoxRole";
            ComboBoxRole.Padding = new Padding(2);
            ComboBoxRole.Size = new Size(300, 45);
            ComboBoxRole.TabIndex = 16;
            ComboBoxRole.Texts = "";
            // 
            // specialButtrons1
            // 
            specialButtrons1.BackColor = Color.MediumSlateBlue;
            specialButtrons1.BackgroundColor = Color.MediumSlateBlue;
            specialButtrons1.BorderColor = Color.PaleVioletRed;
            specialButtrons1.BorderRadius = 12;
            specialButtrons1.BorderSize = 0;
            specialButtrons1.FlatAppearance.BorderSize = 0;
            specialButtrons1.FlatStyle = FlatStyle.Flat;
            specialButtrons1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialButtrons1.ForeColor = Color.FromArgb(134, 210, 147);
            specialButtrons1.Image = (Image)resources.GetObject("specialButtrons1.Image");
            specialButtrons1.ImageAlign = ContentAlignment.MiddleLeft;
            specialButtrons1.Location = new Point(734, 902);
            specialButtrons1.Name = "specialButtrons1";
            specialButtrons1.Size = new Size(276, 91);
            specialButtrons1.TabIndex = 17;
            specialButtrons1.Text = "Đăng Ký";
            specialButtrons1.TextColor = Color.FromArgb(134, 210, 147);
            specialButtrons1.UseVisualStyleBackColor = false;
            specialButtrons1.Click += specialButtrons1_Click;
            specialButtrons1.MouseEnter += specialButtrons1_MouseEnter;
            specialButtrons1.MouseLeave += specialButtrons1_MouseLeave;
            // 
            // specialButtrons2
            // 
            specialButtrons2.BackColor = Color.MediumSlateBlue;
            specialButtrons2.BackgroundColor = Color.MediumSlateBlue;
            specialButtrons2.BorderColor = Color.PaleVioletRed;
            specialButtrons2.BorderRadius = 12;
            specialButtrons2.BorderSize = 0;
            specialButtrons2.FlatAppearance.BorderSize = 0;
            specialButtrons2.FlatStyle = FlatStyle.Flat;
            specialButtrons2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialButtrons2.ForeColor = Color.FromArgb(134, 210, 147);
            specialButtrons2.Image = (Image)resources.GetObject("specialButtrons2.Image");
            specialButtrons2.ImageAlign = ContentAlignment.MiddleLeft;
            specialButtrons2.Location = new Point(1096, 902);
            specialButtrons2.Name = "specialButtrons2";
            specialButtrons2.Size = new Size(276, 91);
            specialButtrons2.TabIndex = 18;
            specialButtrons2.Text = "Reset";
            specialButtrons2.TextColor = Color.FromArgb(134, 210, 147);
            specialButtrons2.UseVisualStyleBackColor = false;
            specialButtrons2.Click += specialButtrons2_Click;
            specialButtrons2.MouseEnter += specialButtrons2_MouseEnter;
            specialButtrons2.MouseLeave += specialButtrons2_MouseLeave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(194, 678);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1182, 501);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // UC_AddUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 250, 217);
            Controls.Add(pictureBox1);
            Controls.Add(specialButtrons2);
            Controls.Add(specialButtrons1);
            Controls.Add(ComboBoxRole);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(TextBoxNhapPass);
            Controls.Add(label8);
            Controls.Add(TextBoxNhapUser);
            Controls.Add(label7);
            Controls.Add(TextBoxEmail);
            Controls.Add(label6);
            Controls.Add(TextBoxSDT);
            Controls.Add(TextBoxUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddUser";
            Size = new Size(1439, 1139);
            Load += UC_AddUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RJcontrol.RJTextBox TextBoxUserName;
        private RJcontrol.RJTextBox TextBoxSDT;
        private Label label6;
        private RJcontrol.RJTextBox TextBoxEmail;
        private Label label7;
        private RJcontrol.RJTextBox TextBoxNhapUser;
        private Label label8;
        private RJcontrol.RJTextBox TextBoxNhapPass;
        private Panel panel1;
        private RJcontrol.RJComboBox ComboBoxRole;
        private RJcontrol.SpecialButtrons specialButtrons1;
        private RJcontrol.SpecialButtrons specialButtrons2;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
    }
}
