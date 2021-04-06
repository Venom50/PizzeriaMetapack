
namespace Pizzeria
{
    partial class PizzaOrderForm
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
            this.pizzaOrderLabel = new System.Windows.Forms.Label();
            this.pizzasLabel = new System.Windows.Forms.Label();
            this.orderPizzaButton = new System.Windows.Forms.Button();
            this.pizzaAdditionsLabel = new System.Windows.Forms.Label();
            this.pizzasListView = new System.Windows.Forms.ListView();
            this.pizzaName = new System.Windows.Forms.ColumnHeader();
            this.pizzaPrice = new System.Windows.Forms.ColumnHeader();
            this.pizzaAdditionsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // pizzaOrderLabel
            // 
            this.pizzaOrderLabel.AutoSize = true;
            this.pizzaOrderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pizzaOrderLabel.Location = new System.Drawing.Point(175, 9);
            this.pizzaOrderLabel.Name = "pizzaOrderLabel";
            this.pizzaOrderLabel.Size = new System.Drawing.Size(164, 37);
            this.pizzaOrderLabel.TabIndex = 1;
            this.pizzaOrderLabel.Text = "Order Pizza";
            // 
            // pizzasLabel
            // 
            this.pizzasLabel.AutoSize = true;
            this.pizzasLabel.Location = new System.Drawing.Point(12, 89);
            this.pizzasLabel.Name = "pizzasLabel";
            this.pizzasLabel.Size = new System.Drawing.Size(70, 30);
            this.pizzasLabel.TabIndex = 3;
            this.pizzasLabel.Text = "Pizzas";
            // 
            // orderPizzaButton
            // 
            this.orderPizzaButton.Location = new System.Drawing.Point(152, 378);
            this.orderPizzaButton.Name = "orderPizzaButton";
            this.orderPizzaButton.Size = new System.Drawing.Size(214, 64);
            this.orderPizzaButton.TabIndex = 7;
            this.orderPizzaButton.Text = "Order Pizza";
            this.orderPizzaButton.UseVisualStyleBackColor = true;
            this.orderPizzaButton.Click += new System.EventHandler(this.orderPizzaButton_Click);
            // 
            // pizzaAdditionsLabel
            // 
            this.pizzaAdditionsLabel.AutoSize = true;
            this.pizzaAdditionsLabel.Location = new System.Drawing.Point(277, 89);
            this.pizzaAdditionsLabel.Name = "pizzaAdditionsLabel";
            this.pizzaAdditionsLabel.Size = new System.Drawing.Size(155, 30);
            this.pizzaAdditionsLabel.TabIndex = 6;
            this.pizzaAdditionsLabel.Text = "Pizza Additions";
            // 
            // pizzasListView
            // 
            this.pizzasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pizzaName,
            this.pizzaPrice});
            this.pizzasListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pizzasListView.FullRowSelect = true;
            this.pizzasListView.GridLines = true;
            this.pizzasListView.HideSelection = false;
            this.pizzasListView.Location = new System.Drawing.Point(12, 128);
            this.pizzasListView.MultiSelect = false;
            this.pizzasListView.Name = "pizzasListView";
            this.pizzasListView.Size = new System.Drawing.Size(215, 244);
            this.pizzasListView.TabIndex = 9;
            this.pizzasListView.UseCompatibleStateImageBehavior = false;
            this.pizzasListView.View = System.Windows.Forms.View.Details;
            // 
            // pizzaName
            // 
            this.pizzaName.Text = "Name";
            this.pizzaName.Width = 150;
            // 
            // pizzaPrice
            // 
            this.pizzaPrice.Text = "Price";
            // 
            // pizzaAdditionsListView
            // 
            this.pizzaAdditionsListView.CheckBoxes = true;
            this.pizzaAdditionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.pizzaAdditionsListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pizzaAdditionsListView.FullRowSelect = true;
            this.pizzaAdditionsListView.GridLines = true;
            this.pizzaAdditionsListView.HideSelection = false;
            this.pizzaAdditionsListView.Location = new System.Drawing.Point(277, 128);
            this.pizzaAdditionsListView.MultiSelect = false;
            this.pizzaAdditionsListView.Name = "pizzaAdditionsListView";
            this.pizzaAdditionsListView.Size = new System.Drawing.Size(215, 244);
            this.pizzaAdditionsListView.TabIndex = 10;
            this.pizzaAdditionsListView.UseCompatibleStateImageBehavior = false;
            this.pizzaAdditionsListView.View = System.Windows.Forms.View.Details;
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
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.pizzaAdditionsListView);
            this.Controls.Add(this.pizzasListView);
            this.Controls.Add(this.orderPizzaButton);
            this.Controls.Add(this.pizzaAdditionsLabel);
            this.Controls.Add(this.pizzasLabel);
            this.Controls.Add(this.pizzaOrderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "PizzaOrderForm";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.PizzaOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzaOrderLabel;
        private System.Windows.Forms.Label pizzasLabel;
        private System.Windows.Forms.Button orderPizzaButton;
        private System.Windows.Forms.Label pizzaAdditionsLabel;
        private System.Windows.Forms.ListView pizzasListView;
        private System.Windows.Forms.ColumnHeader pizzaName;
        private System.Windows.Forms.ColumnHeader pizzaPrice;
        private System.Windows.Forms.ListView pizzaAdditionsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}