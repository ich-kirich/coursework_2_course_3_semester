
namespace lab1
{
    partial class adminPanel
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
            this.assignOrder = new System.Windows.Forms.Button();
            this.tableOfOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // assignOrder
            // 
            this.assignOrder.Location = new System.Drawing.Point(597, 365);
            this.assignOrder.Name = "assignOrder";
            this.assignOrder.Size = new System.Drawing.Size(171, 41);
            this.assignOrder.TabIndex = 5;
            this.assignOrder.Text = "Начать выполнение заказа";
            this.assignOrder.UseVisualStyleBackColor = true;
            this.assignOrder.Click += new System.EventHandler(this.assignOrder_Click);
            // 
            // tableOfOrders
            // 
            this.tableOfOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.tableOfOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableOfOrders.HideSelection = false;
            this.tableOfOrders.Location = new System.Drawing.Point(0, 0);
            this.tableOfOrders.Name = "tableOfOrders";
            this.tableOfOrders.Size = new System.Drawing.Size(274, 450);
            this.tableOfOrders.TabIndex = 6;
            this.tableOfOrders.UseCompatibleStateImageBehavior = false;
            this.tableOfOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Логин пользователя";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Сумма заказа";
            this.columnHeader2.Width = 105;
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableOfOrders);
            this.Controls.Add(this.assignOrder);
            this.Name = "adminPanel";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button assignOrder;
        private System.Windows.Forms.ListView tableOfOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}