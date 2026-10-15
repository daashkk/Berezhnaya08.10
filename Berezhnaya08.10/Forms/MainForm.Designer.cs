namespace Berezhnaya08._10.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.Пароль = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.panelCaptch = new System.Windows.Forms.Panel();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonReady = new System.Windows.Forms.Button();
            this.pictureBoxCaptch4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaptch3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaptch2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaptch1 = new System.Windows.Forms.PictureBox();
            this.panelCaptch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(200, 79);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLogin.TabIndex = 1;
            // 
            // Пароль
            // 
            this.Пароль.AutoSize = true;
            this.Пароль.Location = new System.Drawing.Point(124, 142);
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(56, 16);
            this.Пароль.TabIndex = 2;
            this.Пароль.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(200, 142);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(159, 223);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // panelCaptch
            // 
            this.panelCaptch.Controls.Add(this.buttonRight);
            this.panelCaptch.Controls.Add(this.buttonReady);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch4);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch3);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch2);
            this.panelCaptch.Controls.Add(this.pictureBoxCaptch1);
            this.panelCaptch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaptch.Location = new System.Drawing.Point(0, 0);
            this.panelCaptch.Name = "panelCaptch";
            this.panelCaptch.Size = new System.Drawing.Size(800, 450);
            this.panelCaptch.TabIndex = 5;
            this.panelCaptch.Visible = false;
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(331, 321);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = "->";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonReady
            // 
            this.buttonReady.Location = new System.Drawing.Point(200, 321);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(75, 23);
            this.buttonReady.TabIndex = 4;
            this.buttonReady.Text = "Готово";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // pictureBoxCaptch4
            // 
            this.pictureBoxCaptch4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCaptch4.Image")));
            this.pictureBoxCaptch4.Location = new System.Drawing.Point(306, 164);
            this.pictureBoxCaptch4.Name = "pictureBoxCaptch4";
            this.pictureBoxCaptch4.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCaptch4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptch4.TabIndex = 3;
            this.pictureBoxCaptch4.TabStop = false;
            // 
            // pictureBoxCaptch3
            // 
            this.pictureBoxCaptch3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCaptch3.Image")));
            this.pictureBoxCaptch3.Location = new System.Drawing.Point(200, 164);
            this.pictureBoxCaptch3.Name = "pictureBoxCaptch3";
            this.pictureBoxCaptch3.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCaptch3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptch3.TabIndex = 2;
            this.pictureBoxCaptch3.TabStop = false;
            // 
            // pictureBoxCaptch2
            // 
            this.pictureBoxCaptch2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCaptch2.Image")));
            this.pictureBoxCaptch2.Location = new System.Drawing.Point(306, 58);
            this.pictureBoxCaptch2.Name = "pictureBoxCaptch2";
            this.pictureBoxCaptch2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCaptch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptch2.TabIndex = 1;
            this.pictureBoxCaptch2.TabStop = false;
            // 
            // pictureBoxCaptch1
            // 
            this.pictureBoxCaptch1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCaptch1.Image")));
            this.pictureBoxCaptch1.Location = new System.Drawing.Point(200, 58);
            this.pictureBoxCaptch1.Name = "pictureBoxCaptch1";
            this.pictureBoxCaptch1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCaptch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptch1.TabIndex = 0;
            this.pictureBoxCaptch1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCaptch);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Авторизация";
            this.panelCaptch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptch1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label Пароль;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Panel panelCaptch;
        private System.Windows.Forms.PictureBox pictureBoxCaptch1;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.PictureBox pictureBoxCaptch4;
        private System.Windows.Forms.PictureBox pictureBoxCaptch3;
        private System.Windows.Forms.PictureBox pictureBoxCaptch2;
    }
}