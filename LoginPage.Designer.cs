namespace Творчество
{
    partial class LoginPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.BoxPicture = new System.Windows.Forms.PictureBox();
            this.CompanyNameLable = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ErrorLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxPicture
            // 
            this.BoxPicture.Image = ((System.Drawing.Image)(resources.GetObject("BoxPicture.Image")));
            this.BoxPicture.Location = new System.Drawing.Point(13, 13);
            this.BoxPicture.Name = "BoxPicture";
            this.BoxPicture.Size = new System.Drawing.Size(100, 100);
            this.BoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoxPicture.TabIndex = 0;
            this.BoxPicture.TabStop = false;
            // 
            // CompanyNameLable
            // 
            this.CompanyNameLable.AutoSize = true;
            this.CompanyNameLable.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameLable.Location = new System.Drawing.Point(119, 13);
            this.CompanyNameLable.Name = "CompanyNameLable";
            this.CompanyNameLable.Size = new System.Drawing.Size(69, 15);
            this.CompanyNameLable.TabIndex = 1;
            this.CompanyNameLable.Text = "Творчество";
            // 
            // LoginBox
            // 
            this.LoginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(405, 122);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 23);
            this.LoginBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(405, 151);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 23);
            this.PasswordBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(305, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registration
            // 
            this.Registration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registration.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(305, 261);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(200, 60);
            this.Registration.TabIndex = 5;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(302, 122);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(35, 15);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(302, 151);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(54, 15);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // ErrorLable
            // 
            this.ErrorLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorLable.AutoSize = true;
            this.ErrorLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.ErrorLable.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLable.Location = new System.Drawing.Point(302, 243);
            this.ErrorLable.Name = "ErrorLable";
            this.ErrorLable.Size = new System.Drawing.Size(62, 15);
            this.ErrorLable.TabIndex = 8;
            this.ErrorLable.Text = "ErrorLable";
            this.ErrorLable.Visible = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(794, 451);
            this.Controls.Add(this.ErrorLable);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.CompanyNameLable);
            this.Controls.Add(this.BoxPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(810, 490);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoxPicture;
        private System.Windows.Forms.Label CompanyNameLable;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ErrorLable;
    }
}

