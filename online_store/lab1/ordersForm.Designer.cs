
namespace lab1
{
    partial class ordersForm
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
            this.order = new System.Windows.Forms.Button();
            this.toMain = new System.Windows.Forms.Button();
            this.inputCountGood = new System.Windows.Forms.TextBox();
            this.upgateCountGood = new System.Windows.Forms.Button();
            this.basketList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(683, 397);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(110, 41);
            this.order.TabIndex = 7;
            this.order.Text = "Сделать заказ";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // toMain
            // 
            this.toMain.Location = new System.Drawing.Point(497, 415);
            this.toMain.Name = "toMain";
            this.toMain.Size = new System.Drawing.Size(141, 23);
            this.toMain.TabIndex = 8;
            this.toMain.Text = "Вернутся к покупкам";
            this.toMain.UseVisualStyleBackColor = true;
            this.toMain.Click += new System.EventHandler(this.toMain_Click);
            // 
            // inputCountGood
            // 
            this.inputCountGood.Dock = System.Windows.Forms.DockStyle.Right;
            this.inputCountGood.Location = new System.Drawing.Point(561, 0);
            this.inputCountGood.Name = "inputCountGood";
            this.inputCountGood.Size = new System.Drawing.Size(239, 20);
            this.inputCountGood.TabIndex = 10;
            // 
            // upgateCountGood
            // 
            this.upgateCountGood.Location = new System.Drawing.Point(622, 46);
            this.upgateCountGood.Name = "upgateCountGood";
            this.upgateCountGood.Size = new System.Drawing.Size(171, 41);
            this.upgateCountGood.TabIndex = 11;
            this.upgateCountGood.Text = "Изменить кол-во товара";
            this.upgateCountGood.UseVisualStyleBackColor = true;
            this.upgateCountGood.Click += new System.EventHandler(this.upgateCountGood_Click);
            // 
            // basketList
            // 
            this.basketList.CheckBoxes = true;
            this.basketList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.basketList.Dock = System.Windows.Forms.DockStyle.Left;
            this.basketList.FullRowSelect = true;
            this.basketList.HideSelection = false;
            this.basketList.Location = new System.Drawing.Point(0, 0);
            this.basketList.MultiSelect = false;
            this.basketList.Name = "basketList";
            this.basketList.Size = new System.Drawing.Size(428, 450);
            this.basketList.TabIndex = 12;
            this.basketList.UseCompatibleStateImageBehavior = false;
            this.basketList.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Text = "Кол-во товара";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // resultPrice
            // 
            this.resultPrice.AutoSize = true;
            this.resultPrice.Location = new System.Drawing.Point(434, 124);
            this.resultPrice.Name = "resultPrice";
            this.resultPrice.Size = new System.Drawing.Size(85, 13);
            this.resultPrice.TabIndex = 13;
            this.resultPrice.Text = "Итоговая цена:";
            // 
            // ordersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultPrice);
            this.Controls.Add(this.basketList);
            this.Controls.Add(this.upgateCountGood);
            this.Controls.Add(this.inputCountGood);
            this.Controls.Add(this.toMain);
            this.Controls.Add(this.order);
            this.Name = "ordersForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ordersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button toMain;
        private System.Windows.Forms.TextBox inputCountGood;
        private System.Windows.Forms.Button upgateCountGood;
        private System.Windows.Forms.ListView basketList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label resultPrice;
    }
}