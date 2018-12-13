namespace Lab_3_client
{
    partial class Client
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
            this.purchaseName = new System.Windows.Forms.TextBox();
            this.radioView = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.icecreamRichTextBox = new System.Windows.Forms.RichTextBox();
            this.radioChange = new System.Windows.Forms.RadioButton();
            this.oldPurchaseName = new System.Windows.Forms.TextBox();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.radioSort = new System.Windows.Forms.RadioButton();
            this.radioFind = new System.Windows.Forms.RadioButton();
            this.executeButton = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortOrder = new System.Windows.Forms.CheckBox();
            this.radioPrice = new System.Windows.Forms.RadioButton();
            this.radioQuantity = new System.Windows.Forms.RadioButton();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.purchaseGroupBox = new System.Windows.Forms.GroupBox();
            this.purchaseId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.sortGroupBox.SuspendLayout();
            this.purchaseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // purchaseName
            // 
            this.purchaseName.Location = new System.Drawing.Point(237, 91);
            this.purchaseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseName.Name = "purchaseName";
            this.purchaseName.Size = new System.Drawing.Size(213, 31);
            this.purchaseName.TabIndex = 0;
            // 
            // radioView
            // 
            this.radioView.AutoSize = true;
            this.radioView.Location = new System.Drawing.Point(447, 30);
            this.radioView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioView.Name = "radioView";
            this.radioView.Size = new System.Drawing.Size(200, 29);
            this.radioView.TabIndex = 2;
            this.radioView.TabStop = true;
            this.radioView.Text = "Read purchases";
            this.radioView.UseVisualStyleBackColor = true;
            this.radioView.CheckedChanged += new System.EventHandler(this.radioView_CheckedChanged);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(447, 75);
            this.radioAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(176, 29);
            this.radioAdd.TabIndex = 3;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add purchase";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // icecreamRichTextBox
            // 
            this.icecreamRichTextBox.Location = new System.Drawing.Point(17, 16);
            this.icecreamRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icecreamRichTextBox.Name = "icecreamRichTextBox";
            this.icecreamRichTextBox.Size = new System.Drawing.Size(420, 326);
            this.icecreamRichTextBox.TabIndex = 4;
            this.icecreamRichTextBox.Text = "";
            // 
            // radioChange
            // 
            this.radioChange.AutoSize = true;
            this.radioChange.Location = new System.Drawing.Point(447, 120);
            this.radioChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioChange.Name = "radioChange";
            this.radioChange.Size = new System.Drawing.Size(175, 29);
            this.radioChange.TabIndex = 5;
            this.radioChange.TabStop = true;
            this.radioChange.Text = "Edit purchase";
            this.radioChange.UseVisualStyleBackColor = true;
            this.radioChange.CheckedChanged += new System.EventHandler(this.radioChange_CheckedChanged);
            // 
            // oldPurchaseName
            // 
            this.oldPurchaseName.Location = new System.Drawing.Point(237, 141);
            this.oldPurchaseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oldPurchaseName.Name = "oldPurchaseName";
            this.oldPurchaseName.Size = new System.Drawing.Size(213, 31);
            this.oldPurchaseName.TabIndex = 6;
            this.oldPurchaseName.Visible = false;
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.Location = new System.Drawing.Point(447, 165);
            this.radioDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.Size = new System.Drawing.Size(200, 29);
            this.radioDelete.TabIndex = 7;
            this.radioDelete.TabStop = true;
            this.radioDelete.Text = "Delete purchase";
            this.radioDelete.UseVisualStyleBackColor = true;
            this.radioDelete.CheckedChanged += new System.EventHandler(this.radioDelete_CheckedChanged);
            // 
            // radioSort
            // 
            this.radioSort.AutoSize = true;
            this.radioSort.Location = new System.Drawing.Point(447, 210);
            this.radioSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSort.Name = "radioSort";
            this.radioSort.Size = new System.Drawing.Size(245, 29);
            this.radioSort.TabIndex = 8;
            this.radioSort.TabStop = true;
            this.radioSort.Text = "Sort list of purchases";
            this.radioSort.UseVisualStyleBackColor = true;
            this.radioSort.CheckedChanged += new System.EventHandler(this.radioSort_CheckedChanged);
            // 
            // radioFind
            // 
            this.radioFind.AutoSize = true;
            this.radioFind.Location = new System.Drawing.Point(447, 255);
            this.radioFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioFind.Name = "radioFind";
            this.radioFind.Size = new System.Drawing.Size(111, 29);
            this.radioFind.TabIndex = 9;
            this.radioFind.TabStop = true;
            this.radioFind.Text = "Search";
            this.radioFind.UseVisualStyleBackColor = true;
            this.radioFind.CheckedChanged += new System.EventHandler(this.radioFind_CheckedChanged);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(447, 295);
            this.executeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(145, 49);
            this.executeButton.TabIndex = 10;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.sortOrder);
            this.sortGroupBox.Controls.Add(this.radioPrice);
            this.sortGroupBox.Controls.Add(this.radioQuantity);
            this.sortGroupBox.Controls.Add(this.radioName);
            this.sortGroupBox.Controls.Add(this.radioId);
            this.sortGroupBox.Location = new System.Drawing.Point(17, 351);
            this.sortGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortGroupBox.Size = new System.Drawing.Size(421, 196);
            this.sortGroupBox.TabIndex = 11;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort settings";
            // 
            // sortOrder
            // 
            this.sortOrder.AutoSize = true;
            this.sortOrder.Location = new System.Drawing.Point(257, 32);
            this.sortOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortOrder.Name = "sortOrder";
            this.sortOrder.Size = new System.Drawing.Size(102, 29);
            this.sortOrder.TabIndex = 16;
            this.sortOrder.Text = "DESC";
            this.sortOrder.UseVisualStyleBackColor = true;
            // 
            // radioPrice
            // 
            this.radioPrice.AutoSize = true;
            this.radioPrice.Location = new System.Drawing.Point(8, 145);
            this.radioPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPrice.Name = "radioPrice";
            this.radioPrice.Size = new System.Drawing.Size(119, 29);
            this.radioPrice.TabIndex = 15;
            this.radioPrice.TabStop = true;
            this.radioPrice.Text = "by price";
            this.radioPrice.UseVisualStyleBackColor = true;
            this.radioPrice.CheckedChanged += new System.EventHandler(this.radioPrice_CheckedChanged);
            // 
            // radioQuantity
            // 
            this.radioQuantity.AutoSize = true;
            this.radioQuantity.Location = new System.Drawing.Point(8, 109);
            this.radioQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioQuantity.Name = "radioQuantity";
            this.radioQuantity.Size = new System.Drawing.Size(148, 29);
            this.radioQuantity.TabIndex = 14;
            this.radioQuantity.TabStop = true;
            this.radioQuantity.Text = "by quantity";
            this.radioQuantity.UseVisualStyleBackColor = true;
            this.radioQuantity.CheckedChanged += new System.EventHandler(this.radioQuantity_CheckedChanged);
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Location = new System.Drawing.Point(8, 70);
            this.radioName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(225, 29);
            this.radioName.TabIndex = 13;
            this.radioName.TabStop = true;
            this.radioName.Text = "by ice-cream name";
            this.radioName.UseVisualStyleBackColor = true;
            this.radioName.CheckedChanged += new System.EventHandler(this.radioName_CheckedChanged);
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Location = new System.Drawing.Point(8, 31);
            this.radioId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(89, 29);
            this.radioId.TabIndex = 12;
            this.radioId.TabStop = true;
            this.radioId.Text = "by id";
            this.radioId.UseVisualStyleBackColor = true;
            this.radioId.CheckedChanged += new System.EventHandler(this.radioId_CheckedChanged);
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 25;
            this.logListBox.Location = new System.Drawing.Point(715, 318);
            this.logListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(481, 229);
            this.logListBox.TabIndex = 12;
            // 
            // purchaseGroupBox
            // 
            this.purchaseGroupBox.Controls.Add(this.purchaseId);
            this.purchaseGroupBox.Controls.Add(this.label5);
            this.purchaseGroupBox.Controls.Add(this.label4);
            this.purchaseGroupBox.Controls.Add(this.label3);
            this.purchaseGroupBox.Controls.Add(this.label2);
            this.purchaseGroupBox.Controls.Add(this.label1);
            this.purchaseGroupBox.Controls.Add(this.price);
            this.purchaseGroupBox.Controls.Add(this.quantity);
            this.purchaseGroupBox.Controls.Add(this.purchaseName);
            this.purchaseGroupBox.Controls.Add(this.oldPurchaseName);
            this.purchaseGroupBox.Location = new System.Drawing.Point(715, 16);
            this.purchaseGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseGroupBox.Name = "purchaseGroupBox";
            this.purchaseGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseGroupBox.Size = new System.Drawing.Size(483, 294);
            this.purchaseGroupBox.TabIndex = 13;
            this.purchaseGroupBox.TabStop = false;
            this.purchaseGroupBox.Text = "Purchase info";
            // 
            // purchaseId
            // 
            this.purchaseId.Location = new System.Drawing.Point(237, 46);
            this.purchaseId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseId.Name = "purchaseId";
            this.purchaseId.Size = new System.Drawing.Size(213, 31);
            this.purchaseId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Purchase  Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ice-cream price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Previous name:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ice-cream name:";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(237, 241);
            this.price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(213, 31);
            this.price.TabIndex = 8;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(237, 191);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(213, 31);
            this.quantity.TabIndex = 7;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 562);
            this.Controls.Add(this.purchaseGroupBox);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.radioFind);
            this.Controls.Add(this.radioSort);
            this.Controls.Add(this.radioDelete);
            this.Controls.Add(this.radioChange);
            this.Controls.Add(this.icecreamRichTextBox);
            this.Controls.Add(this.radioAdd);
            this.Controls.Add(this.radioView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Client";
            this.Text = "LW_3_client__ice-cream_purchases";
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.purchaseGroupBox.ResumeLayout(false);
            this.purchaseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox purchaseName;
        private System.Windows.Forms.RadioButton radioView;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RichTextBox icecreamRichTextBox;
        private System.Windows.Forms.RadioButton radioChange;
        private System.Windows.Forms.TextBox oldPurchaseName;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.RadioButton radioSort;
        private System.Windows.Forms.RadioButton radioFind;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.CheckBox sortOrder;
        private System.Windows.Forms.RadioButton radioPrice;
        private System.Windows.Forms.RadioButton radioQuantity;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioId;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.GroupBox purchaseGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox purchaseId;
        private System.Windows.Forms.Label label5;
    }
}

