
namespace lab1
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basket = new System.Windows.Forms.Button();
            this.addBusket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listOfGoods = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.priceGood = new System.Windows.Forms.Label();
            this.pictureGood = new System.Windows.Forms.PictureBox();
            this.listGoods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.профильToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.личныйКабинетToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.профильToolStripMenuItem.Text = "Профиль";
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            this.личныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.личныйКабинетToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // basket
            // 
            this.basket.Location = new System.Drawing.Point(469, 23);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(128, 41);
            this.basket.TabIndex = 7;
            this.basket.Text = "Перейти в корзину";
            this.basket.UseVisualStyleBackColor = true;
            this.basket.Click += new System.EventHandler(this.basket_Click);
            // 
            // addBusket
            // 
            this.addBusket.Location = new System.Drawing.Point(24, 82);
            this.addBusket.Name = "addBusket";
            this.addBusket.Size = new System.Drawing.Size(128, 41);
            this.addBusket.TabIndex = 7;
            this.addBusket.Text = "Добавить в корзину";
            this.addBusket.UseVisualStyleBackColor = true;
            this.addBusket.Click += new System.EventHandler(this.addBusket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип товара";
            // 
            // listOfGoods
            // 
            this.listOfGoods.BackColor = System.Drawing.SystemColors.Window;
            this.listOfGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOfGoods.FormattingEnabled = true;
            this.listOfGoods.Location = new System.Drawing.Point(101, 10);
            this.listOfGoods.Name = "listOfGoods";
            this.listOfGoods.Size = new System.Drawing.Size(202, 21);
            this.listOfGoods.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Цена:";
            // 
            // priceGood
            // 
            this.priceGood.AutoSize = true;
            this.priceGood.Location = new System.Drawing.Point(69, 52);
            this.priceGood.Name = "priceGood";
            this.priceGood.Size = new System.Drawing.Size(13, 13);
            this.priceGood.TabIndex = 13;
            this.priceGood.Text = "0";
            // 
            // pictureGood
            // 
            this.pictureGood.ErrorImage = null;
            this.pictureGood.Image = ((System.Drawing.Image)(resources.GetObject("pictureGood.Image")));
            this.pictureGood.ImageLocation = "";
            this.pictureGood.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureGood.InitialImage")));
            this.pictureGood.Location = new System.Drawing.Point(24, 140);
            this.pictureGood.Name = "pictureGood";
            this.pictureGood.Size = new System.Drawing.Size(213, 154);
            this.pictureGood.TabIndex = 16;
            this.pictureGood.TabStop = false;
            // 
            // listGoods
            // 
            this.listGoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGoods.HideSelection = false;
            this.listGoods.Location = new System.Drawing.Point(0, 0);
            this.listGoods.Name = "listGoods";
            this.listGoods.Size = new System.Drawing.Size(191, 535);
            this.listGoods.TabIndex = 0;
            this.listGoods.UseCompatibleStateImageBehavior = false;
            this.listGoods.View = System.Windows.Forms.View.Details;
            this.listGoods.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Категории товаров";
            this.columnHeader1.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureGood);
            this.panel1.Controls.Add(this.priceGood);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.listOfGoods);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addBusket);
            this.panel1.Controls.Add(this.basket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(190, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 535);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.listGoods);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 535);
            this.panel2.TabIndex = 17;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(881, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Internet Store";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button basket;
        private System.Windows.Forms.Button addBusket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listOfGoods;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label priceGood;
        private System.Windows.Forms.PictureBox pictureGood;
        private System.Windows.Forms.ListView listGoods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

