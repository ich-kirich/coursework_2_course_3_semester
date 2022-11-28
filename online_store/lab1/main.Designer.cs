
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
            this.listOfGoods = new System.Windows.Forms.ComboBox();
            this.categoryGoodsName = new System.Windows.Forms.Label();
            this.goodsChoose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureGood = new System.Windows.Forms.PictureBox();
            this.toBusket = new System.Windows.Forms.Button();
            this.basket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.basketList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfGoods
            // 
            this.listOfGoods.AutoCompleteCustomSource.AddRange(new string[] {
            "Страйкбольное оружие",
            "Аксессуары для страйкбола",
            "Пневматическое оружие",
            "Прочее"});
            this.listOfGoods.BackColor = System.Drawing.SystemColors.Window;
            this.listOfGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOfGoods.FormattingEnabled = true;
            this.listOfGoods.Items.AddRange(new object[] {
            "Страйкбольное оружие",
            "Аксессуары для страйкбола",
            "Пневматическое оружие",
            "Прочее"});
            this.listOfGoods.Location = new System.Drawing.Point(117, 125);
            this.listOfGoods.Name = "listOfGoods";
            this.listOfGoods.Size = new System.Drawing.Size(202, 21);
            this.listOfGoods.TabIndex = 0;
            this.listOfGoods.SelectedIndexChanged += new System.EventHandler(this.ListOfGoods_SelectedIndexChanged);
            // 
            // categoryGoodsName
            // 
            this.categoryGoodsName.AutoSize = true;
            this.categoryGoodsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryGoodsName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryGoodsName.Location = new System.Drawing.Point(113, 102);
            this.categoryGoodsName.Name = "categoryGoodsName";
            this.categoryGoodsName.Size = new System.Drawing.Size(196, 16);
            this.categoryGoodsName.TabIndex = 1;
            this.categoryGoodsName.Text = "Выберите категорию товара";
            this.categoryGoodsName.Click += new System.EventHandler(this.label1_Click);
            // 
            // goodsChoose
            // 
            this.goodsChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsChoose.FormattingEnabled = true;
            this.goodsChoose.Location = new System.Drawing.Point(118, 207);
            this.goodsChoose.Name = "goodsChoose";
            this.goodsChoose.Size = new System.Drawing.Size(201, 21);
            this.goodsChoose.TabIndex = 2;
            this.goodsChoose.SelectedIndexChanged += new System.EventHandler(this.goodsChoose_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип товаров";
            // 
            // pictureGood
            // 
            this.pictureGood.Location = new System.Drawing.Point(117, 252);
            this.pictureGood.Name = "pictureGood";
            this.pictureGood.Size = new System.Drawing.Size(213, 154);
            this.pictureGood.TabIndex = 4;
            this.pictureGood.TabStop = false;
            // 
            // toBusket
            // 
            this.toBusket.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toBusket.Location = new System.Drawing.Point(355, 369);
            this.toBusket.Name = "toBusket";
            this.toBusket.Size = new System.Drawing.Size(93, 37);
            this.toBusket.TabIndex = 6;
            this.toBusket.Text = "В корзину";
            this.toBusket.UseVisualStyleBackColor = true;
            this.toBusket.Visible = false;
            this.toBusket.Click += new System.EventHandler(this.toBusket_Click);
            // 
            // basket
            // 
            this.basket.Location = new System.Drawing.Point(660, 12);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(128, 41);
            this.basket.TabIndex = 7;
            this.basket.Text = "Перейти в корзину";
            this.basket.UseVisualStyleBackColor = true;
            this.basket.Visible = false;
            this.basket.Click += new System.EventHandler(this.basket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Корзина";
            // 
            // basketList
            // 
            this.basketList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basketList.FormattingEnabled = true;
            this.basketList.Location = new System.Drawing.Point(528, 163);
            this.basketList.Name = "basketList";
            this.basketList.Size = new System.Drawing.Size(201, 21);
            this.basketList.TabIndex = 8;
            this.basketList.SelectedIndexChanged += new System.EventHandler(this.basketList_SelectedIndexChanged);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.basketList);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.toBusket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureGood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goodsChoose);
            this.Controls.Add(this.categoryGoodsName);
            this.Controls.Add(this.listOfGoods);
            this.Name = "MainPage";
            this.Text = "Internet Store";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listOfGoods;
        private System.Windows.Forms.Label categoryGoodsName;
        private System.Windows.Forms.ComboBox goodsChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureGood;
        private System.Windows.Forms.Button toBusket;
        private System.Windows.Forms.Button basket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox basketList;
    }
}

