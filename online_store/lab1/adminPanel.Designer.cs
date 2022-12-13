
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
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chooseWorker = new System.Windows.Forms.Button();
            this.chooseStatus = new System.Windows.Forms.Button();
            this.workersList = new System.Windows.Forms.ComboBox();
            this.statusOrder = new System.Windows.Forms.ComboBox();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assignOrder
            // 
            this.assignOrder.Location = new System.Drawing.Point(597, 351);
            this.assignOrder.Name = "assignOrder";
            this.assignOrder.Size = new System.Drawing.Size(171, 41);
            this.assignOrder.TabIndex = 5;
            this.assignOrder.Text = "Записать заказ";
            this.assignOrder.UseVisualStyleBackColor = true;
            this.assignOrder.Click += new System.EventHandler(this.assignOrder_Click);
            // 
            // tableOfOrders
            // 
            this.tableOfOrders.CheckBoxes = true;
            this.tableOfOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.tableOfOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableOfOrders.FullRowSelect = true;
            this.tableOfOrders.HideSelection = false;
            this.tableOfOrders.Location = new System.Drawing.Point(0, 0);
            this.tableOfOrders.MultiSelect = false;
            this.tableOfOrders.Name = "tableOfOrders";
            this.tableOfOrders.Size = new System.Drawing.Size(591, 450);
            this.tableOfOrders.TabIndex = 6;
            this.tableOfOrders.UseCompatibleStateImageBehavior = false;
            this.tableOfOrders.View = System.Windows.Forms.View.Details;
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
            this.columnHeader4.Width = 150;
            // 
            // chooseWorker
            // 
            this.chooseWorker.Location = new System.Drawing.Point(597, 226);
            this.chooseWorker.Name = "chooseWorker";
            this.chooseWorker.Size = new System.Drawing.Size(171, 41);
            this.chooseWorker.TabIndex = 9;
            this.chooseWorker.Text = "Назначить работника";
            this.chooseWorker.UseVisualStyleBackColor = true;
            this.chooseWorker.Click += new System.EventHandler(this.chooseWorker_Click);
            // 
            // chooseStatus
            // 
            this.chooseStatus.Location = new System.Drawing.Point(597, 290);
            this.chooseStatus.Name = "chooseStatus";
            this.chooseStatus.Size = new System.Drawing.Size(171, 41);
            this.chooseStatus.TabIndex = 10;
            this.chooseStatus.Text = "Изменить статус заказа";
            this.chooseStatus.UseVisualStyleBackColor = true;
            this.chooseStatus.Click += new System.EventHandler(this.chooseStatus_Click);
            // 
            // workersList
            // 
            this.workersList.BackColor = System.Drawing.SystemColors.Window;
            this.workersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.workersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workersList.FormattingEnabled = true;
            this.workersList.Location = new System.Drawing.Point(591, 0);
            this.workersList.Name = "workersList";
            this.workersList.Size = new System.Drawing.Size(209, 21);
            this.workersList.TabIndex = 11;
            // 
            // statusOrder
            // 
            this.statusOrder.BackColor = System.Drawing.SystemColors.Window;
            this.statusOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusOrder.FormattingEnabled = true;
            this.statusOrder.Location = new System.Drawing.Point(591, 21);
            this.statusOrder.Name = "statusOrder";
            this.statusOrder.Size = new System.Drawing.Size(209, 21);
            this.statusOrder.TabIndex = 12;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(597, 412);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(171, 26);
            this.exit.TabIndex = 13;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.statusOrder);
            this.Controls.Add(this.workersList);
            this.Controls.Add(this.chooseStatus);
            this.Controls.Add(this.chooseWorker);
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
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button chooseWorker;
        private System.Windows.Forms.Button chooseStatus;
        private System.Windows.Forms.ComboBox workersList;
        private System.Windows.Forms.ComboBox statusOrder;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button exit;
    }
}