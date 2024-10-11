namespace PharmacyManagementProject
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            test1 = new RJcontrol.test();
            panel2 = new Panel();
            label2 = new Label();
            logOutButton = new Button();
            profileButton = new Button();
            allUserButton = new Button();
            addUserButton = new Button();
            DashboardButton = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            uC_Dashboard1 = new AdminUC.UC_Dashboard();
            uC_AddUser1 = new AdminUC.UC_AddUser();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)test1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(98, 86, 202);
            panel1.Controls.Add(test1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(logOutButton);
            panel1.Controls.Add(profileButton);
            panel1.Controls.Add(allUserButton);
            panel1.Controls.Add(addUserButton);
            panel1.Controls.Add(DashboardButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 1145);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // test1
            // 
            test1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            test1.BorderColor = Color.MidnightBlue;
            test1.BorderColor2 = Color.HotPink;
            test1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            test1.BorderSize = 10;
            test1.GradientAngle = 50F;
            test1.Image = (Image)resources.GetObject("test1.Image");
            test1.Location = new Point(62, 30);
            test1.Name = "test1";
            test1.Size = new Size(282, 282);
            test1.SizeMode = PictureBoxSizeMode.StretchImage;
            test1.TabIndex = 2;
            test1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(134, 210, 147);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 1079);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 60);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 9);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 0;
            label2.Text = "Nhóm 9";
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.FromArgb(98, 86, 202);
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Bookman Old Style", 14F, FontStyle.Bold);
            logOutButton.Image = (Image)resources.GetObject("logOutButton.Image");
            logOutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logOutButton.Location = new Point(129, 870);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(280, 62);
            logOutButton.TabIndex = 6;
            logOutButton.Text = "Logout";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            logOutButton.MouseEnter += logOutButton_MouseEnter;
            logOutButton.MouseLeave += logOutButton_MouseLeave;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.FromArgb(98, 86, 202);
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Font = new Font("Bookman Old Style", 14F, FontStyle.Bold);
            profileButton.Image = (Image)resources.GetObject("profileButton.Image");
            profileButton.ImageAlign = ContentAlignment.MiddleLeft;
            profileButton.Location = new Point(128, 756);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(280, 62);
            profileButton.TabIndex = 5;
            profileButton.Text = "Hồ Sơ";
            profileButton.UseVisualStyleBackColor = false;
            profileButton.MouseEnter += profileButton_MouseEnter;
            profileButton.MouseLeave += profileButton_MouseLeave;
            // 
            // allUserButton
            // 
            allUserButton.BackColor = Color.FromArgb(98, 86, 202);
            allUserButton.FlatAppearance.BorderSize = 0;
            allUserButton.FlatStyle = FlatStyle.Flat;
            allUserButton.Font = new Font("Bookman Old Style", 14F, FontStyle.Bold);
            allUserButton.Image = (Image)resources.GetObject("allUserButton.Image");
            allUserButton.ImageAlign = ContentAlignment.MiddleLeft;
            allUserButton.Location = new Point(128, 645);
            allUserButton.Name = "allUserButton";
            allUserButton.Size = new Size(281, 62);
            allUserButton.TabIndex = 4;
            allUserButton.Text = "Xem User";
            allUserButton.UseVisualStyleBackColor = false;
            allUserButton.MouseEnter += allUserButton_MouseEnter;
            allUserButton.MouseLeave += allUserButton_MouseLeave;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.FromArgb(98, 86, 202);
            addUserButton.FlatAppearance.BorderSize = 0;
            addUserButton.FlatStyle = FlatStyle.Flat;
            addUserButton.Font = new Font("Bookman Old Style", 14F, FontStyle.Bold);
            addUserButton.Image = (Image)resources.GetObject("addUserButton.Image");
            addUserButton.ImageAlign = ContentAlignment.MiddleLeft;
            addUserButton.Location = new Point(128, 537);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(281, 62);
            addUserButton.TabIndex = 3;
            addUserButton.Text = "Thêm User";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            addUserButton.MouseEnter += addUserButton_MouseEnter;
            addUserButton.MouseLeave += addUserButton_MouseLeave;
            // 
            // DashboardButton
            // 
            DashboardButton.BackColor = Color.FromArgb(98, 86, 202);
            DashboardButton.FlatAppearance.BorderSize = 0;
            DashboardButton.FlatStyle = FlatStyle.Flat;
            DashboardButton.Font = new Font("Bookman Old Style", 14F, FontStyle.Bold);
            DashboardButton.Image = (Image)resources.GetObject("DashboardButton.Image");
            DashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardButton.Location = new Point(128, 426);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Size = new Size(280, 62);
            DashboardButton.TabIndex = 2;
            DashboardButton.Text = "Dashboard";
            DashboardButton.UseVisualStyleBackColor = false;
            DashboardButton.Click += DashboardButton_Click;
            DashboardButton.MouseEnter += DashboardButton_MouseEnter;
            DashboardButton.MouseLeave += DashboardButton_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 25.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(253, 250, 217);
            label1.Location = new Point(36, 315);
            label1.Name = "label1";
            label1.Size = new Size(332, 75);
            label1.TabIndex = 1;
            label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(788, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(657, 539);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // uC_Dashboard1
            // 
            uC_Dashboard1.BackColor = Color.FromArgb(253, 250, 217);
            uC_Dashboard1.Location = new Point(403, -3);
            uC_Dashboard1.Name = "uC_Dashboard1";
            uC_Dashboard1.Size = new Size(1439, 1139);
            uC_Dashboard1.TabIndex = 3;
            // 
            // uC_AddUser1
            // 
            uC_AddUser1.BackColor = Color.FromArgb(253, 250, 217);
            uC_AddUser1.Location = new Point(403, -3);
            uC_AddUser1.Name = "uC_AddUser1";
            uC_AddUser1.Size = new Size(1439, 1139);
            uC_AddUser1.TabIndex = 4;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 250, 217);
            ClientSize = new Size(1842, 1135);
            Controls.Add(uC_AddUser1);
            Controls.Add(uC_Dashboard1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)test1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button allUserButton;
        private Button addUserButton;
        private Button DashboardButton;
        private Button logOutButton;
        private Button profileButton;
        private Panel panel2;
        private Label label2;
        private ToolTip toolTip1;
        private RJcontrol.test test1;
        private PictureBox pictureBox1;
        private AdminUC.UC_Dashboard uC_Dashboard1;
        private AdminUC.UC_AddUser uC_AddUser1;
    }
}