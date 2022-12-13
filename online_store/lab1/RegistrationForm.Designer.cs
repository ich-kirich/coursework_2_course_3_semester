
namespace lab1
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toLogin = new System.Windows.Forms.Button();
            this.passField_reg = new System.Windows.Forms.TextBox();
            this.re = new System.Windows.Forms.Label();
            this.loginField_reg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.toLog);
            this.panel1.Controls.Add(this.toLogin);
            this.panel1.Controls.Add(this.passField_reg);
            this.panel1.Controls.Add(this.re);
            this.panel1.Controls.Add(this.loginField_reg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // toLogin
            // 
            this.toLogin.BackColor = System.Drawing.Color.Azure;
            this.toLogin.Location = new System.Drawing.Point(330, 371);
            this.toLogin.Name = "toLogin";
            this.toLogin.Size = new System.Drawing.Size(142, 46);
            this.toLogin.TabIndex = 9;
            this.toLogin.Text = "Зарегистрироваться";
            this.toLogin.UseVisualStyleBackColor = false;
            this.toLogin.Click += new System.EventHandler(this.toLogin_Click);
            // 
            // passField_reg
            // 
            this.passField_reg.Location = new System.Drawing.Point(140, 277);
            this.passField_reg.Name = "passField_reg";
            this.passField_reg.PasswordChar = '*';
            this.passField_reg.Size = new System.Drawing.Size(524, 20);
            this.passField_reg.TabIndex = 8;
            // 
            // re
            // 
            this.re.AutoSize = true;
            this.re.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.re.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.re.Location = new System.Drawing.Point(136, 250);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(76, 24);
            this.re.TabIndex = 7;
            this.re.Text = "Пароль";
            // 
            // loginField_reg
            // 
            this.loginField_reg.Location = new System.Drawing.Point(140, 181);
            this.loginField_reg.Name = "loginField_reg";
            this.loginField_reg.Size = new System.Drawing.Size(524, 20);
            this.loginField_reg.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(136, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация Аккаунта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toLog
            // 
            this.toLog.Location = new System.Drawing.Point(644, 378);
            this.toLog.Name = "toLog";
            this.toLog.Size = new System.Drawing.Size(131, 38);
            this.toLog.TabIndex = 10;
            this.toLog.Text = "К авторизации";
            this.toLog.UseVisualStyleBackColor = true;
            this.toLog.Click += new System.EventHandler(this.toLog_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passField_reg;
        private System.Windows.Forms.Label re;
        private System.Windows.Forms.TextBox loginField_reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toLogin;
        private System.Windows.Forms.Button toLog;
    }
}