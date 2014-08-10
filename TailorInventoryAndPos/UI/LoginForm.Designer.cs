namespace TailorInventoryAndPos
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(150, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 217);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.userIdTextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Id :";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Location = new System.Drawing.Point(195, 103);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(105, 103);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(105, 49);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(165, 20);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(105, 18);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(165, 20);
            this.userIdTextBox.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

