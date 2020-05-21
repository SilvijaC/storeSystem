namespace storeSystem
{
    partial class StoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.label1 = new System.Windows.Forms.Label();
            this.OrderTab_CategorySelectionBox = new System.Windows.Forms.ComboBox();
            this.OrderTab_OrderPanel = new System.Windows.Forms.Panel();
            this.AddToBasketButton = new System.Windows.Forms.Button();
            this.OrderTab_InventoryCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderTab_BasketPanel = new System.Windows.Forms.Panel();
            this.OrderTab_BasketBox = new System.Windows.Forms.ListBox();
            this.OrderTab_SelectedBasketItemCountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ContinueOrderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderTab_OrderConfirmationPanel = new System.Windows.Forms.Panel();
            this.OrderTab_DeclineOrderButton = new System.Windows.Forms.Button();
            this.OrderTab_CompleteOrder = new System.Windows.Forms.Button();
            this.OrderTab_SumTotalBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderTab_SumLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConfirmOrderPanel = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.AddNewItemTab_Price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddNewTab_SaveNewItemButton = new System.Windows.Forms.Button();
            this.AddNewItemTab_Count = new System.Windows.Forms.TextBox();
            this.AddNewItemTab_InventoryName = new System.Windows.Forms.TextBox();
            this.AddNewItemTab_CategorySelectionBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ShowUserBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.OrderTab_OrderPanel.SuspendLayout();
            this.OrderTab_BasketPanel.SuspendLayout();
            this.OrderTab_OrderConfirmationPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ConfirmOrderPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prisijungęs vartotojas:";
            // 
            // OrderTab_CategorySelectionBox
            // 
            this.OrderTab_CategorySelectionBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderTab_CategorySelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderTab_CategorySelectionBox.FormattingEnabled = true;
            this.OrderTab_CategorySelectionBox.Location = new System.Drawing.Point(17, 65);
            this.OrderTab_CategorySelectionBox.Name = "OrderTab_CategorySelectionBox";
            this.OrderTab_CategorySelectionBox.Size = new System.Drawing.Size(171, 21);
            this.OrderTab_CategorySelectionBox.TabIndex = 1;
            // 
            // OrderTab_OrderPanel
            // 
            this.OrderTab_OrderPanel.Controls.Add(this.AddToBasketButton);
            this.OrderTab_OrderPanel.Controls.Add(this.OrderTab_InventoryCheckBox);
            this.OrderTab_OrderPanel.Controls.Add(this.label4);
            this.OrderTab_OrderPanel.Controls.Add(this.label3);
            this.OrderTab_OrderPanel.Controls.Add(this.label2);
            this.OrderTab_OrderPanel.Controls.Add(this.OrderTab_CategorySelectionBox);
            this.OrderTab_OrderPanel.Location = new System.Drawing.Point(14, 14);
            this.OrderTab_OrderPanel.Name = "OrderTab_OrderPanel";
            this.OrderTab_OrderPanel.Size = new System.Drawing.Size(369, 272);
            this.OrderTab_OrderPanel.TabIndex = 2;
            // 
            // AddToBasketButton
            // 
            this.AddToBasketButton.BackColor = System.Drawing.Color.White;
            this.AddToBasketButton.Location = new System.Drawing.Point(122, 235);
            this.AddToBasketButton.Name = "AddToBasketButton";
            this.AddToBasketButton.Size = new System.Drawing.Size(117, 23);
            this.AddToBasketButton.TabIndex = 6;
            this.AddToBasketButton.Text = "Pridėti į krepšelį";
            this.AddToBasketButton.UseVisualStyleBackColor = false;
            this.AddToBasketButton.Click += new System.EventHandler(this.AddToBasketButton_Click);
            // 
            // OrderTab_InventoryCheckBox
            // 
            this.OrderTab_InventoryCheckBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderTab_InventoryCheckBox.CheckOnClick = true;
            this.OrderTab_InventoryCheckBox.FormattingEnabled = true;
            this.OrderTab_InventoryCheckBox.Location = new System.Drawing.Point(17, 105);
            this.OrderTab_InventoryCheckBox.Name = "OrderTab_InventoryCheckBox";
            this.OrderTab_InventoryCheckBox.Size = new System.Drawing.Size(331, 109);
            this.OrderTab_InventoryCheckBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "2. Pažymėkite norimas prekes iš sąrašo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Užsakymas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1. Pasirinkite prekių kategoriją:";
            // 
            // OrderTab_BasketPanel
            // 
            this.OrderTab_BasketPanel.Controls.Add(this.OrderTab_BasketBox);
            this.OrderTab_BasketPanel.Controls.Add(this.OrderTab_SelectedBasketItemCountTextBox);
            this.OrderTab_BasketPanel.Controls.Add(this.label6);
            this.OrderTab_BasketPanel.Controls.Add(this.RemoveItemButton);
            this.OrderTab_BasketPanel.Controls.Add(this.ContinueOrderButton);
            this.OrderTab_BasketPanel.Controls.Add(this.label5);
            this.OrderTab_BasketPanel.Location = new System.Drawing.Point(389, 14);
            this.OrderTab_BasketPanel.Name = "OrderTab_BasketPanel";
            this.OrderTab_BasketPanel.Size = new System.Drawing.Size(393, 272);
            this.OrderTab_BasketPanel.TabIndex = 3;
            // 
            // OrderTab_BasketBox
            // 
            this.OrderTab_BasketBox.FormattingEnabled = true;
            this.OrderTab_BasketBox.Location = new System.Drawing.Point(19, 49);
            this.OrderTab_BasketBox.Name = "OrderTab_BasketBox";
            this.OrderTab_BasketBox.Size = new System.Drawing.Size(328, 160);
            this.OrderTab_BasketBox.TabIndex = 10;
            // 
            // OrderTab_SelectedBasketItemCountTextBox
            // 
            this.OrderTab_SelectedBasketItemCountTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderTab_SelectedBasketItemCountTextBox.Location = new System.Drawing.Point(260, 212);
            this.OrderTab_SelectedBasketItemCountTextBox.Name = "OrderTab_SelectedBasketItemCountTextBox";
            this.OrderTab_SelectedBasketItemCountTextBox.Size = new System.Drawing.Size(87, 20);
            this.OrderTab_SelectedBasketItemCountTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pasirinkite prekę jei norite pakeisti vienetų kiekį";
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.BackColor = System.Drawing.Color.White;
            this.RemoveItemButton.Location = new System.Drawing.Point(194, 235);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(153, 23);
            this.RemoveItemButton.TabIndex = 7;
            this.RemoveItemButton.Text = "Ištrinti pasirinktą prekę";
            this.RemoveItemButton.UseVisualStyleBackColor = false;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ContinueOrderButton
            // 
            this.ContinueOrderButton.BackColor = System.Drawing.Color.White;
            this.ContinueOrderButton.Location = new System.Drawing.Point(19, 235);
            this.ContinueOrderButton.Name = "ContinueOrderButton";
            this.ContinueOrderButton.Size = new System.Drawing.Size(168, 23);
            this.ContinueOrderButton.TabIndex = 6;
            this.ContinueOrderButton.Text = "Tęsti užsakymą";
            this.ContinueOrderButton.UseVisualStyleBackColor = false;
            this.ContinueOrderButton.Click += new System.EventHandler(this.ContinueOrderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prekių krepšelis";
            // 
            // OrderTab_OrderConfirmationPanel
            // 
            this.OrderTab_OrderConfirmationPanel.Controls.Add(this.OrderTab_DeclineOrderButton);
            this.OrderTab_OrderConfirmationPanel.Controls.Add(this.OrderTab_CompleteOrder);
            this.OrderTab_OrderConfirmationPanel.Controls.Add(this.OrderTab_SumTotalBox);
            this.OrderTab_OrderConfirmationPanel.Controls.Add(this.label8);
            this.OrderTab_OrderConfirmationPanel.Controls.Add(this.OrderTab_SumLabel);
            this.OrderTab_OrderConfirmationPanel.Location = new System.Drawing.Point(206, 307);
            this.OrderTab_OrderConfirmationPanel.Name = "OrderTab_OrderConfirmationPanel";
            this.OrderTab_OrderConfirmationPanel.Size = new System.Drawing.Size(396, 122);
            this.OrderTab_OrderConfirmationPanel.TabIndex = 4;
            this.OrderTab_OrderConfirmationPanel.Visible = false;
            // 
            // OrderTab_DeclineOrderButton
            // 
            this.OrderTab_DeclineOrderButton.BackColor = System.Drawing.Color.White;
            this.OrderTab_DeclineOrderButton.Location = new System.Drawing.Point(190, 89);
            this.OrderTab_DeclineOrderButton.Name = "OrderTab_DeclineOrderButton";
            this.OrderTab_DeclineOrderButton.Size = new System.Drawing.Size(156, 23);
            this.OrderTab_DeclineOrderButton.TabIndex = 8;
            this.OrderTab_DeclineOrderButton.Text = "Atšaukti užsakymą";
            this.OrderTab_DeclineOrderButton.UseVisualStyleBackColor = false;
            this.OrderTab_DeclineOrderButton.Click += new System.EventHandler(this.OrderTab_DeclineOrderButton_Click);
            // 
            // OrderTab_CompleteOrder
            // 
            this.OrderTab_CompleteOrder.BackColor = System.Drawing.Color.White;
            this.OrderTab_CompleteOrder.Location = new System.Drawing.Point(42, 89);
            this.OrderTab_CompleteOrder.Name = "OrderTab_CompleteOrder";
            this.OrderTab_CompleteOrder.Size = new System.Drawing.Size(142, 23);
            this.OrderTab_CompleteOrder.TabIndex = 7;
            this.OrderTab_CompleteOrder.Text = "Patvirtinti užsakymą";
            this.OrderTab_CompleteOrder.UseVisualStyleBackColor = false;
            this.OrderTab_CompleteOrder.Click += new System.EventHandler(this.OrderTab_CompleteOrder_Click);
            // 
            // OrderTab_SumTotalBox
            // 
            this.OrderTab_SumTotalBox.BackColor = System.Drawing.SystemColors.Control;
            this.OrderTab_SumTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderTab_SumTotalBox.Location = new System.Drawing.Point(148, 62);
            this.OrderTab_SumTotalBox.Name = "OrderTab_SumTotalBox";
            this.OrderTab_SumTotalBox.Size = new System.Drawing.Size(100, 13);
            this.OrderTab_SumTotalBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Užsakymo patvirtinimas";
            // 
            // OrderTab_SumLabel
            // 
            this.OrderTab_SumLabel.AutoSize = true;
            this.OrderTab_SumLabel.Location = new System.Drawing.Point(57, 65);
            this.OrderTab_SumLabel.Name = "OrderTab_SumLabel";
            this.OrderTab_SumLabel.Size = new System.Drawing.Size(85, 13);
            this.OrderTab_SumLabel.TabIndex = 0;
            this.OrderTab_SumLabel.Text = "Mokėtina suma: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConfirmOrderPanel);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 484);
            this.tabControl1.TabIndex = 5;
            // 
            // ConfirmOrderPanel
            // 
            this.ConfirmOrderPanel.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmOrderPanel.Controls.Add(this.OrderTab_OrderPanel);
            this.ConfirmOrderPanel.Controls.Add(this.OrderTab_OrderConfirmationPanel);
            this.ConfirmOrderPanel.Controls.Add(this.OrderTab_BasketPanel);
            this.ConfirmOrderPanel.Location = new System.Drawing.Point(4, 22);
            this.ConfirmOrderPanel.Name = "ConfirmOrderPanel";
            this.ConfirmOrderPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ConfirmOrderPanel.Size = new System.Drawing.Size(799, 458);
            this.ConfirmOrderPanel.TabIndex = 0;
            this.ConfirmOrderPanel.Text = "Prekių užsakymas";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.AddNewItemTab_Price);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.AddNewTab_SaveNewItemButton);
            this.tabPage2.Controls.Add(this.AddNewItemTab_Count);
            this.tabPage2.Controls.Add(this.AddNewItemTab_InventoryName);
            this.tabPage2.Controls.Add(this.AddNewItemTab_CategorySelectionBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pridėti naują prekę";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Įvesti vieneto kainą:";
            // 
            // AddNewItemTab_Price
            // 
            this.AddNewItemTab_Price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddNewItemTab_Price.Location = new System.Drawing.Point(58, 235);
            this.AddNewItemTab_Price.Name = "AddNewItemTab_Price";
            this.AddNewItemTab_Price.Size = new System.Drawing.Size(171, 20);
            this.AddNewItemTab_Price.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Įvesti kiekį:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Įvesti prekės pavadinimą: ";
            // 
            // AddNewTab_SaveNewItemButton
            // 
            this.AddNewTab_SaveNewItemButton.BackColor = System.Drawing.Color.White;
            this.AddNewTab_SaveNewItemButton.Location = new System.Drawing.Point(95, 287);
            this.AddNewTab_SaveNewItemButton.Name = "AddNewTab_SaveNewItemButton";
            this.AddNewTab_SaveNewItemButton.Size = new System.Drawing.Size(93, 23);
            this.AddNewTab_SaveNewItemButton.TabIndex = 9;
            this.AddNewTab_SaveNewItemButton.Text = "Išsaugoti";
            this.AddNewTab_SaveNewItemButton.UseVisualStyleBackColor = false;
            // 
            // AddNewItemTab_Count
            // 
            this.AddNewItemTab_Count.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddNewItemTab_Count.Location = new System.Drawing.Point(58, 182);
            this.AddNewItemTab_Count.Name = "AddNewItemTab_Count";
            this.AddNewItemTab_Count.Size = new System.Drawing.Size(171, 20);
            this.AddNewItemTab_Count.TabIndex = 8;
            // 
            // AddNewItemTab_InventoryName
            // 
            this.AddNewItemTab_InventoryName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddNewItemTab_InventoryName.Location = new System.Drawing.Point(58, 138);
            this.AddNewItemTab_InventoryName.Name = "AddNewItemTab_InventoryName";
            this.AddNewItemTab_InventoryName.Size = new System.Drawing.Size(171, 20);
            this.AddNewItemTab_InventoryName.TabIndex = 7;
            // 
            // AddNewItemTab_CategorySelectionBox
            // 
            this.AddNewItemTab_CategorySelectionBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddNewItemTab_CategorySelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddNewItemTab_CategorySelectionBox.FormattingEnabled = true;
            this.AddNewItemTab_CategorySelectionBox.Location = new System.Drawing.Point(58, 87);
            this.AddNewItemTab_CategorySelectionBox.Name = "AddNewItemTab_CategorySelectionBox";
            this.AddNewItemTab_CategorySelectionBox.Size = new System.Drawing.Size(171, 21);
            this.AddNewItemTab_CategorySelectionBox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Pasirinkti kategorija:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nauja prekė";
            // 
            // ShowUserBox
            // 
            this.ShowUserBox.BackColor = System.Drawing.SystemColors.Control;
            this.ShowUserBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowUserBox.Location = new System.Drawing.Point(128, 9);
            this.ShowUserBox.Name = "ShowUserBox";
            this.ShowUserBox.Size = new System.Drawing.Size(100, 13);
            this.ShowUserBox.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(695, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Atsijungti";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 514);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ShowUserBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagrindinis puslapis";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.OrderTab_OrderPanel.ResumeLayout(false);
            this.OrderTab_OrderPanel.PerformLayout();
            this.OrderTab_BasketPanel.ResumeLayout(false);
            this.OrderTab_BasketPanel.PerformLayout();
            this.OrderTab_OrderConfirmationPanel.ResumeLayout(false);
            this.OrderTab_OrderConfirmationPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ConfirmOrderPanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OrderTab_CategorySelectionBox;
        private System.Windows.Forms.Panel OrderTab_OrderPanel;
        private System.Windows.Forms.Button AddToBasketButton;
        private System.Windows.Forms.CheckedListBox OrderTab_InventoryCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel OrderTab_BasketPanel;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ContinueOrderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OrderTab_SelectedBasketItemCountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel OrderTab_OrderConfirmationPanel;
        private System.Windows.Forms.Button OrderTab_DeclineOrderButton;
        private System.Windows.Forms.Button OrderTab_CompleteOrder;
        private System.Windows.Forms.TextBox OrderTab_SumTotalBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label OrderTab_SumLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ConfirmOrderPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddNewTab_SaveNewItemButton;
        private System.Windows.Forms.TextBox AddNewItemTab_Count;
        private System.Windows.Forms.TextBox AddNewItemTab_InventoryName;
        private System.Windows.Forms.ComboBox AddNewItemTab_CategorySelectionBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ShowUserBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AddNewItemTab_Price;
        private System.Windows.Forms.ListBox OrderTab_BasketBox;
    }
}