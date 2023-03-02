namespace TestDataAndSQLPlus
{
    partial class log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Clear = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel_to_avtorosation = new System.Windows.Forms.LinkLabel();
            this.pictureBox_OpenPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox_ClousedPassword = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OpenPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClousedPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(141, 92);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(242, 31);
            this.textBox_login.TabIndex = 5;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(141, 138);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(242, 31);
            this.textBox_password.TabIndex = 6;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.Location = new System.Drawing.Point(141, 178);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(242, 37);
            this.button_enter.TabIndex = 7;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox_Clear);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 60);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox_Clear
            // 
            this.pictureBox_Clear.Image = global::TestDataAndSQLPlus.Properties.Resources.Lastik;
            this.pictureBox_Clear.Location = new System.Drawing.Point(406, 12);
            this.pictureBox_Clear.Name = "pictureBox_Clear";
            this.pictureBox_Clear.Size = new System.Drawing.Size(75, 43);
            this.pictureBox_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Clear.TabIndex = 3;
            this.pictureBox_Clear.TabStop = false;
            this.pictureBox_Clear.Click += new System.EventHandler(this.pictureBox_Clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::TestDataAndSQLPlus.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel_to_avtorosation
            // 
            this.linkLabel_to_avtorosation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_to_avtorosation.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel_to_avtorosation.Location = new System.Drawing.Point(141, 218);
            this.linkLabel_to_avtorosation.Name = "linkLabel_to_avtorosation";
            this.linkLabel_to_avtorosation.Size = new System.Drawing.Size(242, 31);
            this.linkLabel_to_avtorosation.TabIndex = 11;
            this.linkLabel_to_avtorosation.TabStop = true;
            this.linkLabel_to_avtorosation.Text = "Ещё нет аккаунта?";
            this.linkLabel_to_avtorosation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_to_avtorosation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_to_avtorosation_LinkClicked);
            // 
            // pictureBox_OpenPassword
            // 
            this.pictureBox_OpenPassword.Image = global::TestDataAndSQLPlus.Properties.Resources.hidden;
            this.pictureBox_OpenPassword.Location = new System.Drawing.Point(389, 138);
            this.pictureBox_OpenPassword.Name = "pictureBox_OpenPassword";
            this.pictureBox_OpenPassword.Size = new System.Drawing.Size(38, 31);
            this.pictureBox_OpenPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_OpenPassword.TabIndex = 10;
            this.pictureBox_OpenPassword.TabStop = false;
            this.pictureBox_OpenPassword.Click += new System.EventHandler(this.pictureBox_OpenPassword_Click);
            // 
            // pictureBox_ClousedPassword
            // 
            this.pictureBox_ClousedPassword.Image = global::TestDataAndSQLPlus.Properties.Resources.view;
            this.pictureBox_ClousedPassword.Location = new System.Drawing.Point(389, 138);
            this.pictureBox_ClousedPassword.Name = "pictureBox_ClousedPassword";
            this.pictureBox_ClousedPassword.Size = new System.Drawing.Size(38, 31);
            this.pictureBox_ClousedPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ClousedPassword.TabIndex = 9;
            this.pictureBox_ClousedPassword.TabStop = false;
            this.pictureBox_ClousedPassword.Click += new System.EventHandler(this.pictureBox_ClousedPassword_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.linkLabel_to_avtorosation);
            this.Controls.Add(this.pictureBox_OpenPassword);
            this.Controls.Add(this.pictureBox_ClousedPassword);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "log_in";
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OpenPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClousedPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_ClousedPassword;
        private System.Windows.Forms.PictureBox pictureBox_OpenPassword;
        private System.Windows.Forms.PictureBox pictureBox_Clear;
        private System.Windows.Forms.LinkLabel linkLabel_to_avtorosation;
    }
}

