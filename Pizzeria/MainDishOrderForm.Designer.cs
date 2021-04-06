
namespace Pizzeria
{
    partial class MainDishOrderForm
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
            this.mainDishOrderLabel = new System.Windows.Forms.Label();
            this.mainDishAdditionsListView = new System.Windows.Forms.ListView();
            this.mainDishAdditionName = new System.Windows.Forms.ColumnHeader();
            this.mainDishAdditionPrice = new System.Windows.Forms.ColumnHeader();
            this.mainDishesListView = new System.Windows.Forms.ListView();
            this.mainDishName = new System.Windows.Forms.ColumnHeader();
            this.mainDishPrice = new System.Windows.Forms.ColumnHeader();
            this.orderMainDishButton = new System.Windows.Forms.Button();
            this.mainDishAdditionsLabel = new System.Windows.Forms.Label();
            this.mainDishesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainDishOrderLabel
            // 
            this.mainDishOrderLabel.AutoSize = true;
            this.mainDishOrderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainDishOrderLabel.Location = new System.Drawing.Point(123, 9);
            this.mainDishOrderLabel.Name = "mainDishOrderLabel";
            this.mainDishOrderLabel.Size = new System.Drawing.Size(226, 37);
            this.mainDishOrderLabel.TabIndex = 9;
            this.mainDishOrderLabel.Text = "Order Main Dish";
            // 
            // mainDishAdditionsListView
            // 
            this.mainDishAdditionsListView.CheckBoxes = true;
            this.mainDishAdditionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mainDishAdditionName,
            this.mainDishAdditionPrice});
            this.mainDishAdditionsListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainDishAdditionsListView.FullRowSelect = true;
            this.mainDishAdditionsListView.GridLines = true;
            this.mainDishAdditionsListView.HideSelection = false;
            this.mainDishAdditionsListView.Location = new System.Drawing.Point(277, 131);
            this.mainDishAdditionsListView.MultiSelect = false;
            this.mainDishAdditionsListView.Name = "mainDishAdditionsListView";
            this.mainDishAdditionsListView.Size = new System.Drawing.Size(215, 244);
            this.mainDishAdditionsListView.TabIndex = 15;
            this.mainDishAdditionsListView.UseCompatibleStateImageBehavior = false;
            this.mainDishAdditionsListView.View = System.Windows.Forms.View.Details;
            // 
            // mainDishAdditionName
            // 
            this.mainDishAdditionName.Text = "Name";
            this.mainDishAdditionName.Width = 150;
            // 
            // mainDishAdditionPrice
            // 
            this.mainDishAdditionPrice.Text = "Price";
            // 
            // mainDishesListView
            // 
            this.mainDishesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mainDishName,
            this.mainDishPrice});
            this.mainDishesListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainDishesListView.FullRowSelect = true;
            this.mainDishesListView.GridLines = true;
            this.mainDishesListView.HideSelection = false;
            this.mainDishesListView.Location = new System.Drawing.Point(12, 131);
            this.mainDishesListView.MultiSelect = false;
            this.mainDishesListView.Name = "mainDishesListView";
            this.mainDishesListView.Size = new System.Drawing.Size(215, 244);
            this.mainDishesListView.TabIndex = 14;
            this.mainDishesListView.UseCompatibleStateImageBehavior = false;
            this.mainDishesListView.View = System.Windows.Forms.View.Details;
            // 
            // mainDishName
            // 
            this.mainDishName.Text = "Name";
            this.mainDishName.Width = 150;
            // 
            // mainDishPrice
            // 
            this.mainDishPrice.Text = "Price";
            // 
            // orderMainDishButton
            // 
            this.orderMainDishButton.Location = new System.Drawing.Point(152, 381);
            this.orderMainDishButton.Name = "orderMainDishButton";
            this.orderMainDishButton.Size = new System.Drawing.Size(214, 64);
            this.orderMainDishButton.TabIndex = 13;
            this.orderMainDishButton.Text = "Order Main Dish";
            this.orderMainDishButton.UseVisualStyleBackColor = true;
            this.orderMainDishButton.Click += new System.EventHandler(this.orderMainDishButton_Click);
            // 
            // mainDishAdditionsLabel
            // 
            this.mainDishAdditionsLabel.AutoSize = true;
            this.mainDishAdditionsLabel.Location = new System.Drawing.Point(277, 92);
            this.mainDishAdditionsLabel.Name = "mainDishAdditionsLabel";
            this.mainDishAdditionsLabel.Size = new System.Drawing.Size(201, 30);
            this.mainDishAdditionsLabel.TabIndex = 12;
            this.mainDishAdditionsLabel.Text = "Main Dish Additions";
            // 
            // mainDishesLabel
            // 
            this.mainDishesLabel.AutoSize = true;
            this.mainDishesLabel.Location = new System.Drawing.Point(12, 92);
            this.mainDishesLabel.Name = "mainDishesLabel";
            this.mainDishesLabel.Size = new System.Drawing.Size(127, 30);
            this.mainDishesLabel.TabIndex = 11;
            this.mainDishesLabel.Text = "Main Dishes";
            // 
            // MainDishOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.mainDishAdditionsListView);
            this.Controls.Add(this.mainDishesListView);
            this.Controls.Add(this.orderMainDishButton);
            this.Controls.Add(this.mainDishAdditionsLabel);
            this.Controls.Add(this.mainDishesLabel);
            this.Controls.Add(this.mainDishOrderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainDishOrderForm";
            this.Text = "Main Dish Order";
            this.Load += new System.EventHandler(this.MainDishOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainDishOrderLabel;
        private System.Windows.Forms.ListView mainDishAdditionsListView;
        private System.Windows.Forms.ColumnHeader mainDishAdditionName;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView mainDishesListView;
        private System.Windows.Forms.ColumnHeader mainDishName;
        private System.Windows.Forms.ColumnHeader pizzaPrice;
        private System.Windows.Forms.Button orderMainDishButton;
        private System.Windows.Forms.Label mainDishAdditionsLabel;
        private System.Windows.Forms.Label mainDishesLabel;
        private System.Windows.Forms.ColumnHeader mainDishPrice;
        private System.Windows.Forms.ColumnHeader mainDishAdditionPrice;
    }
}