
namespace Pizzeria
{
    partial class PizzeriaOrderForm
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
            this.pizzeriaLabel = new System.Windows.Forms.Label();
            this.pizzaGroupBox = new System.Windows.Forms.GroupBox();
            this.pizzaOrderFormButton = new System.Windows.Forms.Button();
            this.drinksGroupBox = new System.Windows.Forms.GroupBox();
            this.drinksListView = new System.Windows.Forms.ListView();
            this.drinkName = new System.Windows.Forms.ColumnHeader();
            this.drinkPrice = new System.Windows.Forms.ColumnHeader();
            this.addSelectedDrinkButton = new System.Windows.Forms.Button();
            this.mainDishGroupBox = new System.Windows.Forms.GroupBox();
            this.mainDishOrderFormButton = new System.Windows.Forms.Button();
            this.soupGroupBox = new System.Windows.Forms.GroupBox();
            this.soupsListView = new System.Windows.Forms.ListView();
            this.soupName = new System.Windows.Forms.ColumnHeader();
            this.soupPrice = new System.Windows.Forms.ColumnHeader();
            this.addSelectedSoupButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            this.deleteSelectedOrderElementButton = new System.Windows.Forms.Button();
            this.prizeTitleLabel = new System.Windows.Forms.Label();
            this.totalPrizeLabel = new System.Windows.Forms.Label();
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.noteGroupBox = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.orderHistoryButton = new System.Windows.Forms.Button();
            this.orderListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.pizzaGroupBox.SuspendLayout();
            this.drinksGroupBox.SuspendLayout();
            this.mainDishGroupBox.SuspendLayout();
            this.soupGroupBox.SuspendLayout();
            this.noteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzeriaLabel
            // 
            this.pizzeriaLabel.AutoSize = true;
            this.pizzeriaLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pizzeriaLabel.Location = new System.Drawing.Point(452, 9);
            this.pizzeriaLabel.Name = "pizzeriaLabel";
            this.pizzeriaLabel.Size = new System.Drawing.Size(117, 37);
            this.pizzeriaLabel.TabIndex = 0;
            this.pizzeriaLabel.Text = "Pizzeria";
            // 
            // pizzaGroupBox
            // 
            this.pizzaGroupBox.Controls.Add(this.pizzaOrderFormButton);
            this.pizzaGroupBox.Location = new System.Drawing.Point(29, 104);
            this.pizzaGroupBox.Name = "pizzaGroupBox";
            this.pizzaGroupBox.Size = new System.Drawing.Size(232, 146);
            this.pizzaGroupBox.TabIndex = 1;
            this.pizzaGroupBox.TabStop = false;
            this.pizzaGroupBox.Text = "Pizzas";
            // 
            // pizzaOrderFormButton
            // 
            this.pizzaOrderFormButton.Location = new System.Drawing.Point(16, 35);
            this.pizzaOrderFormButton.Name = "pizzaOrderFormButton";
            this.pizzaOrderFormButton.Size = new System.Drawing.Size(203, 90);
            this.pizzaOrderFormButton.TabIndex = 1;
            this.pizzaOrderFormButton.Text = "Select Pizza";
            this.pizzaOrderFormButton.UseVisualStyleBackColor = true;
            this.pizzaOrderFormButton.Click += new System.EventHandler(this.pizzaOrderFormButton_Click);
            // 
            // drinksGroupBox
            // 
            this.drinksGroupBox.Controls.Add(this.drinksListView);
            this.drinksGroupBox.Controls.Add(this.addSelectedDrinkButton);
            this.drinksGroupBox.Location = new System.Drawing.Point(282, 51);
            this.drinksGroupBox.Name = "drinksGroupBox";
            this.drinksGroupBox.Size = new System.Drawing.Size(322, 281);
            this.drinksGroupBox.TabIndex = 3;
            this.drinksGroupBox.TabStop = false;
            this.drinksGroupBox.Text = "Drinks";
            // 
            // drinksListView
            // 
            this.drinksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.drinkName,
            this.drinkPrice});
            this.drinksListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drinksListView.FullRowSelect = true;
            this.drinksListView.GridLines = true;
            this.drinksListView.HideSelection = false;
            this.drinksListView.Location = new System.Drawing.Point(7, 35);
            this.drinksListView.MultiSelect = false;
            this.drinksListView.Name = "drinksListView";
            this.drinksListView.Size = new System.Drawing.Size(309, 184);
            this.drinksListView.TabIndex = 2;
            this.drinksListView.UseCompatibleStateImageBehavior = false;
            this.drinksListView.View = System.Windows.Forms.View.Details;
            // 
            // drinkName
            // 
            this.drinkName.Text = "Name";
            this.drinkName.Width = 150;
            // 
            // drinkPrice
            // 
            this.drinkPrice.Text = "Price";
            // 
            // addSelectedDrinkButton
            // 
            this.addSelectedDrinkButton.Location = new System.Drawing.Point(57, 225);
            this.addSelectedDrinkButton.Name = "addSelectedDrinkButton";
            this.addSelectedDrinkButton.Size = new System.Drawing.Size(203, 50);
            this.addSelectedDrinkButton.TabIndex = 1;
            this.addSelectedDrinkButton.Text = "Add Selected";
            this.addSelectedDrinkButton.UseVisualStyleBackColor = true;
            this.addSelectedDrinkButton.Click += new System.EventHandler(this.addSelectedDrinkButton_Click);
            // 
            // mainDishGroupBox
            // 
            this.mainDishGroupBox.Controls.Add(this.mainDishOrderFormButton);
            this.mainDishGroupBox.Location = new System.Drawing.Point(29, 399);
            this.mainDishGroupBox.Name = "mainDishGroupBox";
            this.mainDishGroupBox.Size = new System.Drawing.Size(232, 143);
            this.mainDishGroupBox.TabIndex = 4;
            this.mainDishGroupBox.TabStop = false;
            this.mainDishGroupBox.Text = "Main Dishes";
            // 
            // mainDishOrderFormButton
            // 
            this.mainDishOrderFormButton.Location = new System.Drawing.Point(16, 35);
            this.mainDishOrderFormButton.Name = "mainDishOrderFormButton";
            this.mainDishOrderFormButton.Size = new System.Drawing.Size(203, 90);
            this.mainDishOrderFormButton.TabIndex = 1;
            this.mainDishOrderFormButton.Text = "Select Main Dish";
            this.mainDishOrderFormButton.UseVisualStyleBackColor = true;
            this.mainDishOrderFormButton.Click += new System.EventHandler(this.mainDishOrderFormButton_Click);
            // 
            // soupGroupBox
            // 
            this.soupGroupBox.Controls.Add(this.soupsListView);
            this.soupGroupBox.Controls.Add(this.addSelectedSoupButton);
            this.soupGroupBox.Location = new System.Drawing.Point(282, 338);
            this.soupGroupBox.Name = "soupGroupBox";
            this.soupGroupBox.Size = new System.Drawing.Size(322, 281);
            this.soupGroupBox.TabIndex = 6;
            this.soupGroupBox.TabStop = false;
            this.soupGroupBox.Text = "Soups";
            // 
            // soupsListView
            // 
            this.soupsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.soupName,
            this.soupPrice});
            this.soupsListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soupsListView.FullRowSelect = true;
            this.soupsListView.GridLines = true;
            this.soupsListView.HideSelection = false;
            this.soupsListView.Location = new System.Drawing.Point(7, 35);
            this.soupsListView.MultiSelect = false;
            this.soupsListView.Name = "soupsListView";
            this.soupsListView.Size = new System.Drawing.Size(309, 184);
            this.soupsListView.TabIndex = 3;
            this.soupsListView.UseCompatibleStateImageBehavior = false;
            this.soupsListView.View = System.Windows.Forms.View.Details;
            // 
            // soupName
            // 
            this.soupName.Text = "Name";
            this.soupName.Width = 150;
            // 
            // soupPrice
            // 
            this.soupPrice.Text = "Price";
            // 
            // addSelectedSoupButton
            // 
            this.addSelectedSoupButton.Location = new System.Drawing.Point(57, 225);
            this.addSelectedSoupButton.Name = "addSelectedSoupButton";
            this.addSelectedSoupButton.Size = new System.Drawing.Size(203, 50);
            this.addSelectedSoupButton.TabIndex = 1;
            this.addSelectedSoupButton.Text = "Add Selected";
            this.addSelectedSoupButton.UseVisualStyleBackColor = true;
            this.addSelectedSoupButton.Click += new System.EventHandler(this.addSelectedSoupButton_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(623, 51);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(66, 30);
            this.orderLabel.TabIndex = 8;
            this.orderLabel.Text = "Order";
            // 
            // deleteSelectedOrderElementButton
            // 
            this.deleteSelectedOrderElementButton.Location = new System.Drawing.Point(886, 287);
            this.deleteSelectedOrderElementButton.Name = "deleteSelectedOrderElementButton";
            this.deleteSelectedOrderElementButton.Size = new System.Drawing.Size(141, 91);
            this.deleteSelectedOrderElementButton.TabIndex = 2;
            this.deleteSelectedOrderElementButton.Text = "Delete Selected";
            this.deleteSelectedOrderElementButton.UseVisualStyleBackColor = true;
            this.deleteSelectedOrderElementButton.Click += new System.EventHandler(this.deleteSelectedOrderElementButton_Click);
            // 
            // prizeTitleLabel
            // 
            this.prizeTitleLabel.AutoSize = true;
            this.prizeTitleLabel.Location = new System.Drawing.Point(683, 573);
            this.prizeTitleLabel.Name = "prizeTitleLabel";
            this.prizeTitleLabel.Size = new System.Drawing.Size(113, 30);
            this.prizeTitleLabel.TabIndex = 9;
            this.prizeTitleLabel.Text = "Total Prize:";
            // 
            // totalPrizeLabel
            // 
            this.totalPrizeLabel.AutoSize = true;
            this.totalPrizeLabel.Location = new System.Drawing.Point(802, 573);
            this.totalPrizeLabel.Name = "totalPrizeLabel";
            this.totalPrizeLabel.Size = new System.Drawing.Size(40, 30);
            this.totalPrizeLabel.TabIndex = 10;
            this.totalPrizeLabel.Text = "0zł";
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.Location = new System.Drawing.Point(7, 35);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(463, 124);
            this.noteRichTextBox.TabIndex = 0;
            this.noteRichTextBox.Text = "";
            // 
            // noteGroupBox
            // 
            this.noteGroupBox.Controls.Add(this.noteRichTextBox);
            this.noteGroupBox.Location = new System.Drawing.Point(13, 625);
            this.noteGroupBox.Name = "noteGroupBox";
            this.noteGroupBox.Size = new System.Drawing.Size(487, 175);
            this.noteGroupBox.TabIndex = 11;
            this.noteGroupBox.TabStop = false;
            this.noteGroupBox.Text = "Note";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(506, 634);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 30);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(511, 668);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(433, 35);
            this.emailTextBox.TabIndex = 13;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(511, 734);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(203, 50);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // orderHistoryButton
            // 
            this.orderHistoryButton.Location = new System.Drawing.Point(741, 734);
            this.orderHistoryButton.Name = "orderHistoryButton";
            this.orderHistoryButton.Size = new System.Drawing.Size(203, 50);
            this.orderHistoryButton.TabIndex = 14;
            this.orderHistoryButton.Text = "Order History";
            this.orderHistoryButton.UseVisualStyleBackColor = true;
            this.orderHistoryButton.Click += new System.EventHandler(this.orderHistoryButton_Click);
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.orderListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderListView.FullRowSelect = true;
            this.orderListView.GridLines = true;
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(623, 86);
            this.orderListView.MultiSelect = false;
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(257, 471);
            this.orderListView.TabIndex = 15;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            // 
            // PizzeriaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 812);
            this.Controls.Add(this.orderListView);
            this.Controls.Add(this.orderHistoryButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.noteGroupBox);
            this.Controls.Add(this.totalPrizeLabel);
            this.Controls.Add(this.prizeTitleLabel);
            this.Controls.Add(this.deleteSelectedOrderElementButton);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.soupGroupBox);
            this.Controls.Add(this.mainDishGroupBox);
            this.Controls.Add(this.drinksGroupBox);
            this.Controls.Add(this.pizzaGroupBox);
            this.Controls.Add(this.pizzeriaLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PizzeriaOrderForm";
            this.Text = "Pizzeria Order";
            this.Load += new System.EventHandler(this.PizzeriaOrderForm_Load);
            this.pizzaGroupBox.ResumeLayout(false);
            this.drinksGroupBox.ResumeLayout(false);
            this.mainDishGroupBox.ResumeLayout(false);
            this.soupGroupBox.ResumeLayout(false);
            this.noteGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzeriaLabel;
        private System.Windows.Forms.GroupBox pizzaGroupBox;
        private System.Windows.Forms.Button pizzaOrderFormButton;
        private System.Windows.Forms.GroupBox drinksGroupBox;
        private System.Windows.Forms.Button addSelectedDrinkButton;
        private System.Windows.Forms.GroupBox mainDishGroupBox;
        private System.Windows.Forms.Button mainDishOrderFormButton;
        private System.Windows.Forms.GroupBox soupGroupBox;
        private System.Windows.Forms.Button addSelectedSoupButton;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button deleteSelectedOrderElementButton;
        private System.Windows.Forms.Label prizeTitleLabel;
        private System.Windows.Forms.Label totalPrizeLabel;
        private System.Windows.Forms.RichTextBox noteRichTextBox;
        private System.Windows.Forms.GroupBox noteGroupBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button orderHistoryButton;
        private System.Windows.Forms.ListView drinksListView;
        private System.Windows.Forms.ColumnHeader drinkName;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader drinkPrice;
        private System.Windows.Forms.ListView soupsListView;
        private System.Windows.Forms.ColumnHeader soupName;
        private System.Windows.Forms.ColumnHeader soupPrice;
        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}