
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
            this.listOrders = new System.Windows.Forms.ComboBox();
            this.listGoodsOrder = new System.Windows.Forms.ComboBox();
            this.listWorkers = new System.Windows.Forms.ComboBox();
            this.assignOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listOrders
            // 
            this.listOrders.BackColor = System.Drawing.SystemColors.Window;
            this.listOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOrders.FormattingEnabled = true;
            this.listOrders.Location = new System.Drawing.Point(126, 128);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(202, 21);
            this.listOrders.TabIndex = 2;
            this.listOrders.SelectedIndexChanged += new System.EventHandler(this.listOrders_SelectedIndexChanged);
            // 
            // listGoodsOrder
            // 
            this.listGoodsOrder.BackColor = System.Drawing.SystemColors.Window;
            this.listGoodsOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listGoodsOrder.FormattingEnabled = true;
            this.listGoodsOrder.Location = new System.Drawing.Point(126, 223);
            this.listGoodsOrder.Name = "listGoodsOrder";
            this.listGoodsOrder.Size = new System.Drawing.Size(202, 21);
            this.listGoodsOrder.TabIndex = 3;
            this.listGoodsOrder.SelectedIndexChanged += new System.EventHandler(this.listGoodsOrder_SelectedIndexChanged);
            // 
            // listWorkers
            // 
            this.listWorkers.BackColor = System.Drawing.SystemColors.Window;
            this.listWorkers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listWorkers.FormattingEnabled = true;
            this.listWorkers.Location = new System.Drawing.Point(445, 128);
            this.listWorkers.Name = "listWorkers";
            this.listWorkers.Size = new System.Drawing.Size(202, 21);
            this.listWorkers.TabIndex = 4;
            this.listWorkers.SelectedIndexChanged += new System.EventHandler(this.listWorkers_SelectedIndexChanged);
            // 
            // assignOrder
            // 
            this.assignOrder.Location = new System.Drawing.Point(499, 325);
            this.assignOrder.Name = "assignOrder";
            this.assignOrder.Size = new System.Drawing.Size(171, 41);
            this.assignOrder.TabIndex = 5;
            this.assignOrder.Text = "Начать выполнение заказа";
            this.assignOrder.UseVisualStyleBackColor = true;
            this.assignOrder.Click += new System.EventHandler(this.assignOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Заказы клиентов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Заказанные товары";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Работники";
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignOrder);
            this.Controls.Add(this.listWorkers);
            this.Controls.Add(this.listGoodsOrder);
            this.Controls.Add(this.listOrders);
            this.Name = "adminPanel";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listOrders;
        private System.Windows.Forms.ComboBox listGoodsOrder;
        private System.Windows.Forms.ComboBox listWorkers;
        private System.Windows.Forms.Button assignOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}