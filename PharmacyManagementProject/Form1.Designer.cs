namespace PharmacyManagementProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            userNameBox = new TextBox();
            passwordBox = new TextBox();
            SignInButton = new Button();
            ResetButton = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-79, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(820, 682);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(253, 250, 217);
            label1.Location = new Point(345, 9);
            label1.Name = "label1";
            label1.Size = new Size(782, 104);
            label1.TabIndex = 1;
            label1.Text = "Pharamacy Management ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(134, 210, 147);
            panel1.Location = new Point(685, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 554);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(951, 157);
            label2.Name = "label2";
            label2.Size = new Size(234, 66);
            label2.TabIndex = 3;
            label2.Text = "Sign In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(747, 281);
            label3.Name = "label3";
            label3.Size = new Size(219, 42);
            label3.TabIndex = 4;
            label3.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(747, 486);
            label4.Name = "label4";
            label4.Size = new Size(191, 42);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // userNameBox
            // 
            userNameBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameBox.Location = new Point(756, 336);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(396, 50);
            userNameBox.TabIndex = 8;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(756, 544);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '`';
            passwordBox.Size = new Size(396, 50);
            passwordBox.TabIndex = 9;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.FromArgb(255, 192, 192);
            SignInButton.Font = new Font("Sitka Banner", 18F, FontStyle.Bold);
            SignInButton.Image = (Image)resources.GetObject("SignInButton.Image");
            SignInButton.ImageAlign = ContentAlignment.MiddleLeft;
            SignInButton.Location = new Point(756, 661);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(248, 96);
            SignInButton.TabIndex = 11;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            SignInButton.MouseEnter += SignInButton_MouseEnter;
            SignInButton.MouseLeave += SignInButton_MouseLeave;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.FromArgb(255, 192, 192);
            ResetButton.Font = new Font("Sitka Banner", 18F, FontStyle.Bold);
            ResetButton.Image = (Image)resources.GetObject("ResetButton.Image");
            ResetButton.ImageAlign = ContentAlignment.MiddleLeft;
            ResetButton.Location = new Point(1068, 661);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(248, 96);
            ResetButton.TabIndex = 12;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            ResetButton.MouseEnter += ResetButton_MouseEnter;
            ResetButton.MouseLeave += ResetButton_MouseLeave;
            ResetButton.MouseHover += ResetButton_MouseHover;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1339, 12);
            button1.Name = "button1";
            button1.Size = new Size(54, 50);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(228, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 500);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 86, 202);
            ClientSize = new Size(1405, 785);
            Controls.Add(button1);
            Controls.Add(ResetButton);
            Controls.Add(SignInButton);
            Controls.Add(passwordBox);
            Controls.Add(userNameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox userNameBox;
        private TextBox passwordBox;
        private Button SignInButton;
        private Button ResetButton;
        private Button button1;
        private PictureBox pictureBox2;
    }
}
