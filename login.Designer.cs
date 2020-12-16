namespace Pharmacy
{
    partial class login
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
            this.loginWindowPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.btnSingIn = new System.Windows.Forms.Button();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginWindowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginWindowPanel
            // 
            this.loginWindowPanel.BackColor = System.Drawing.Color.Tomato;
            this.loginWindowPanel.Controls.Add(this.errorLabel);
            this.loginWindowPanel.Controls.Add(this.exitPictureBox);
            this.loginWindowPanel.Controls.Add(this.inputLogin);
            this.loginWindowPanel.Controls.Add(this.loginLabel);
            this.loginWindowPanel.Controls.Add(this.btnSingIn);
            this.loginWindowPanel.Controls.Add(this.inputPassword);
            this.loginWindowPanel.Controls.Add(this.passwordLabel);
            this.loginWindowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginWindowPanel.Location = new System.Drawing.Point(0, 0);
            this.loginWindowPanel.Name = "loginWindowPanel";
            this.loginWindowPanel.Size = new System.Drawing.Size(482, 453);
            this.loginWindowPanel.TabIndex = 24;
            this.loginWindowPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginWindowPanel_MouseMove);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Wheat;
            this.errorLabel.Location = new System.Drawing.Point(12, 368);
            this.errorLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 18);
            this.errorLabel.TabIndex = 27;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPictureBox.Image = global::Pharmacy.Resource1.exit;
            this.exitPictureBox.Location = new System.Drawing.Point(423, 12);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(51, 30);
            this.exitPictureBox.TabIndex = 26;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // inputLogin
            // 
            this.inputLogin.BackColor = System.Drawing.Color.SandyBrown;
            this.inputLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLogin.ForeColor = System.Drawing.Color.Maroon;
            this.inputLogin.Location = new System.Drawing.Point(148, 176);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(166, 21);
            this.inputLogin.TabIndex = 25;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(198, 138);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(64, 20);
            this.loginLabel.TabIndex = 24;
            this.loginLabel.Text = "Логин";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSingIn
            // 
            this.btnSingIn.BackColor = System.Drawing.Color.Maroon;
            this.btnSingIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSingIn.FlatAppearance.BorderSize = 0;
            this.btnSingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSingIn.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnSingIn.Location = new System.Drawing.Point(184, 320);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(89, 35);
            this.btnSingIn.TabIndex = 23;
            this.btnSingIn.Text = "Войти";
            this.btnSingIn.UseVisualStyleBackColor = false;
            this.btnSingIn.Click += new System.EventHandler(this.btnSingIn_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.Color.SandyBrown;
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPassword.ForeColor = System.Drawing.Color.Maroon;
            this.inputPassword.Location = new System.Drawing.Point(148, 266);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(166, 21);
            this.inputPassword.TabIndex = 22;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(190, 230);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 21;
            this.passwordLabel.Text = "Пароль";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.loginWindowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.loginWindowPanel.ResumeLayout(false);
            this.loginWindowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginWindowPanel;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button btnSingIn;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Label errorLabel;
    }
}