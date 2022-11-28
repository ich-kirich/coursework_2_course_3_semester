
using System;

namespace lab1
{
    partial class Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxAddBalance = new System.Windows.Forms.TextBox();
            this.buttonAddBalance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonToLogin = new System.Windows.Forms.Button();
            this.buttonWasted = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.buttonToBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пополнить баланс";
            // 
            // TextBoxAddBalance
            // 
            this.TextBoxAddBalance.Location = new System.Drawing.Point(140, 164);
            this.TextBoxAddBalance.Name = "TextBoxAddBalance";
            this.TextBoxAddBalance.Size = new System.Drawing.Size(100, 20);
            this.TextBoxAddBalance.TabIndex = 1;
            // 
            // buttonAddBalance
            // 
            this.buttonAddBalance.Location = new System.Drawing.Point(140, 207);
            this.buttonAddBalance.Name = "buttonAddBalance";
            this.buttonAddBalance.Size = new System.Drawing.Size(116, 32);
            this.buttonAddBalance.TabIndex = 2;
            this.buttonAddBalance.Text = "Пополнить баланс";
            this.buttonAddBalance.UseVisualStyleBackColor = true;
            this.buttonAddBalance.Click += new System.EventHandler(this.buttonAddBalance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Баланс:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "р.";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(84, 97);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(31, 13);
            this.labelBalance.TabIndex = 0;
            this.labelBalance.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "р.";
            // 
            // buttonToLogin
            // 
            this.buttonToLogin.Location = new System.Drawing.Point(15, 402);
            this.buttonToLogin.Name = "buttonToLogin";
            this.buttonToLogin.Size = new System.Drawing.Size(115, 36);
            this.buttonToLogin.TabIndex = 3;
            this.buttonToLogin.Text = "Выход:";
            this.buttonToLogin.UseVisualStyleBackColor = true;
            this.buttonToLogin.Click += new System.EventHandler(this.buttonToLogin_Click);
            // 
            // buttonWasted
            // 
            this.buttonWasted.Location = new System.Drawing.Point(286, 402);
            this.buttonWasted.Name = "buttonWasted";
            this.buttonWasted.Size = new System.Drawing.Size(150, 36);
            this.buttonWasted.TabIndex = 4;
            this.buttonWasted.Text = "Всего куплено";
            this.buttonWasted.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Логин:";
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.Location = new System.Drawing.Point(60, 18);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(67, 13);
            this.labelLoginUser.TabIndex = 5;
            this.labelLoginUser.Text = "defaultName";
            // 
            // buttonToBuy
            // 
            this.buttonToBuy.Location = new System.Drawing.Point(432, 205);
            this.buttonToBuy.Name = "buttonToBuy";
            this.buttonToBuy.Size = new System.Drawing.Size(150, 36);
            this.buttonToBuy.TabIndex = 4;
            this.buttonToBuy.Text = "За покупками";
            this.buttonToBuy.UseVisualStyleBackColor = true;
            this.buttonToBuy.Click += new System.EventHandler(this.buttonToBuy_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoginUser);
            this.Controls.Add(this.buttonToBuy);
            this.Controls.Add(this.buttonWasted);
            this.Controls.Add(this.buttonToLogin);
            this.Controls.Add(this.buttonAddBalance);
            this.Controls.Add(this.TextBoxAddBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.Text = "Мой профиль";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxAddBalance;
        private System.Windows.Forms.Button buttonAddBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonToLogin;
        private System.Windows.Forms.Button buttonWasted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Button buttonToBuy;
    }
}