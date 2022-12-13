
namespace lab1
{
    partial class userOrders
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
            this.userOrdersList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userOrdersList
            // 
            this.userOrdersList.CheckBoxes = true;
            this.userOrdersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.userOrdersList.Dock = System.Windows.Forms.DockStyle.Left;
            this.userOrdersList.FullRowSelect = true;
            this.userOrdersList.HideSelection = false;
            this.userOrdersList.Location = new System.Drawing.Point(0, 0);
            this.userOrdersList.MultiSelect = false;
            this.userOrdersList.Name = "userOrdersList";
            this.userOrdersList.Size = new System.Drawing.Size(594, 450);
            this.userOrdersList.TabIndex = 7;
            this.userOrdersList.UseCompatibleStateImageBehavior = false;
            this.userOrdersList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Логин пользователя";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Сумма заказа";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Работник";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Статус Заказа";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // toProfile
            // 
            this.toProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.toProfile.Location = new System.Drawing.Point(594, 0);
            this.toProfile.Name = "toProfile";
            this.toProfile.Size = new System.Drawing.Size(206, 31);
            this.toProfile.TabIndex = 8;
            this.toProfile.Text = "Вернуться в профиль";
            this.toProfile.UseVisualStyleBackColor = true;
            this.toProfile.Click += new System.EventHandler(this.toProfile_Click);
            // 
            // userOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toProfile);
            this.Controls.Add(this.userOrdersList);
            this.Name = "userOrders";
            this.Text = "userOrders";
            this.Load += new System.EventHandler(this.userOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView userOrdersList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button toProfile;
    }
}