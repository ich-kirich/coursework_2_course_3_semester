
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
            this.basketList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(598, 300);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(110, 41);
            this.order.TabIndex = 7;
            this.order.Text = "Сделать заказ";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // toMain
            // 
            this.toMain.Location = new System.Drawing.Point(647, 24);
            this.toMain.Name = "toMain";
            this.toMain.Size = new System.Drawing.Size(141, 23);
            this.toMain.TabIndex = 8;
            this.toMain.Text = "Вернутся к покупкам";
            this.toMain.UseVisualStyleBackColor = true;
            this.toMain.Click += new System.EventHandler(this.toMain_Click);
            // 
            // basketList
            // 
            this.basketList.ColumnWidth = 210;
            this.basketList.Dock = System.Windows.Forms.DockStyle.Left;
            this.basketList.FormattingEnabled = true;
            this.basketList.Location = new System.Drawing.Point(0, 0);
            this.basketList.MultiColumn = true;
            this.basketList.Name = "basketList";
            this.basketList.Size = new System.Drawing.Size(215, 450);
            this.basketList.TabIndex = 9;
            // 
            // ordersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.basketList);
            this.Controls.Add(this.toMain);
            this.Controls.Add(this.order);
            this.Name = "ordersForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ordersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button toMain;
        private System.Windows.Forms.CheckedListBox basketList;
    }
}