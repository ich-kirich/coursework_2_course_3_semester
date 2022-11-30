
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
            this.listOfPokypok = new System.Windows.Forms.ComboBox();
            this.picturePokypka = new System.Windows.Forms.PictureBox();
            this.deletePokypky = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.toMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePokypka)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfPokypok
            // 
            this.listOfPokypok.BackColor = System.Drawing.SystemColors.Window;
            this.listOfPokypok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOfPokypok.FormattingEnabled = true;
            this.listOfPokypok.Location = new System.Drawing.Point(134, 111);
            this.listOfPokypok.Name = "listOfPokypok";
            this.listOfPokypok.Size = new System.Drawing.Size(202, 21);
            this.listOfPokypok.TabIndex = 1;
            this.listOfPokypok.SelectedIndexChanged += new System.EventHandler(this.listOfPokypok_SelectedIndexChanged_1);
            // 
            // picturePokypka
            // 
            this.picturePokypka.Location = new System.Drawing.Point(134, 187);
            this.picturePokypka.Name = "picturePokypka";
            this.picturePokypka.Size = new System.Drawing.Size(213, 154);
            this.picturePokypka.TabIndex = 5;
            this.picturePokypka.TabStop = false;
            this.picturePokypka.Click += new System.EventHandler(this.picturePokypka_Click);
            // 
            // deletePokypky
            // 
            this.deletePokypky.Location = new System.Drawing.Point(386, 300);
            this.deletePokypky.Name = "deletePokypky";
            this.deletePokypky.Size = new System.Drawing.Size(115, 41);
            this.deletePokypky.TabIndex = 6;
            this.deletePokypky.Text = "Удалить из корзины";
            this.deletePokypky.UseVisualStyleBackColor = true;
            this.deletePokypky.Click += new System.EventHandler(this.deletePokypky_Click);
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
            this.toMain.Location = new System.Drawing.Point(28, 23);
            this.toMain.Name = "toMain";
            this.toMain.Size = new System.Drawing.Size(141, 23);
            this.toMain.TabIndex = 8;
            this.toMain.Text = "Вернутся к покупкам";
            this.toMain.UseVisualStyleBackColor = true;
            this.toMain.Click += new System.EventHandler(this.toMain_Click);
            // 
            // ordersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toMain);
            this.Controls.Add(this.order);
            this.Controls.Add(this.deletePokypky);
            this.Controls.Add(this.picturePokypka);
            this.Controls.Add(this.listOfPokypok);
            this.Name = "ordersForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePokypka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox listOfPokypok;
        private System.Windows.Forms.PictureBox picturePokypka;
        private System.Windows.Forms.Button deletePokypky;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button toMain;
    }
}