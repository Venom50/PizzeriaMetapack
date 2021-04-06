
namespace Pizzeria
{
    partial class OrderHistoryForm
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
            this.orderHistoryLabel = new System.Windows.Forms.Label();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.orderHistoryListView = new System.Windows.Forms.ListView();
            this.orderHistoryId = new System.Windows.Forms.ColumnHeader();
            this.orderDetailsListView = new System.Windows.Forms.ListView();
            this.currentOrderName = new System.Windows.Forms.ColumnHeader();
            this.currentOrderPrice = new System.Windows.Forms.ColumnHeader();
            this.totalPrizeLabel = new System.Windows.Forms.Label();
            this.prizeTitleLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderHistoryLabel
            // 
            this.orderHistoryLabel.AutoSize = true;
            this.orderHistoryLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderHistoryLabel.Location = new System.Drawing.Point(271, 9);
            this.orderHistoryLabel.Name = "orderHistoryLabel";
            this.orderHistoryLabel.Size = new System.Drawing.Size(194, 37);
            this.orderHistoryLabel.TabIndex = 0;
            this.orderHistoryLabel.Text = "Order History";
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(122, 220);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(141, 91);
            this.showDetailsButton.TabIndex = 3;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // orderHistoryListView
            // 
            this.orderHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderHistoryId});
            this.orderHistoryListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderHistoryListView.FullRowSelect = true;
            this.orderHistoryListView.GridLines = true;
            this.orderHistoryListView.HideSelection = false;
            this.orderHistoryListView.Location = new System.Drawing.Point(12, 86);
            this.orderHistoryListView.MultiSelect = false;
            this.orderHistoryListView.Name = "orderHistoryListView";
            this.orderHistoryListView.Size = new System.Drawing.Size(104, 402);
            this.orderHistoryListView.TabIndex = 4;
            this.orderHistoryListView.UseCompatibleStateImageBehavior = false;
            this.orderHistoryListView.View = System.Windows.Forms.View.Details;
            // 
            // orderHistoryId
            // 
            this.orderHistoryId.Text = "Id";
            this.orderHistoryId.Width = 100;
            // 
            // orderDetailsListView
            // 
            this.orderDetailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.currentOrderName,
            this.currentOrderPrice});
            this.orderDetailsListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderDetailsListView.FullRowSelect = true;
            this.orderDetailsListView.GridLines = true;
            this.orderDetailsListView.HideSelection = false;
            this.orderDetailsListView.Location = new System.Drawing.Point(271, 86);
            this.orderDetailsListView.MultiSelect = false;
            this.orderDetailsListView.Name = "orderDetailsListView";
            this.orderDetailsListView.Size = new System.Drawing.Size(448, 228);
            this.orderDetailsListView.TabIndex = 16;
            this.orderDetailsListView.UseCompatibleStateImageBehavior = false;
            this.orderDetailsListView.View = System.Windows.Forms.View.Details;
            // 
            // currentOrderName
            // 
            this.currentOrderName.Text = "Name";
            this.currentOrderName.Width = 385;
            // 
            // currentOrderPrice
            // 
            this.currentOrderPrice.Text = "Price";
            // 
            // totalPrizeLabel
            // 
            this.totalPrizeLabel.AutoSize = true;
            this.totalPrizeLabel.Location = new System.Drawing.Point(661, 447);
            this.totalPrizeLabel.Name = "totalPrizeLabel";
            this.totalPrizeLabel.Size = new System.Drawing.Size(40, 30);
            this.totalPrizeLabel.TabIndex = 18;
            this.totalPrizeLabel.Text = "0zł";
            // 
            // prizeTitleLabel
            // 
            this.prizeTitleLabel.AutoSize = true;
            this.prizeTitleLabel.Location = new System.Drawing.Point(542, 447);
            this.prizeTitleLabel.Name = "prizeTitleLabel";
            this.prizeTitleLabel.Size = new System.Drawing.Size(113, 30);
            this.prizeTitleLabel.TabIndex = 17;
            this.prizeTitleLabel.Text = "Total Prize:";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(271, 53);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(76, 30);
            this.detailsLabel.TabIndex = 19;
            this.detailsLabel.Text = "Details";
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteRichTextBox.Location = new System.Drawing.Point(271, 320);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.ReadOnly = true;
            this.noteRichTextBox.Size = new System.Drawing.Size(448, 124);
            this.noteRichTextBox.TabIndex = 20;
            this.noteRichTextBox.Text = "";
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Location = new System.Drawing.Point(12, 53);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(75, 30);
            this.ordersLabel.TabIndex = 21;
            this.ordersLabel.Text = "Orders";
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 513);
            this.Controls.Add(this.ordersLabel);
            this.Controls.Add(this.noteRichTextBox);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.totalPrizeLabel);
            this.Controls.Add(this.prizeTitleLabel);
            this.Controls.Add(this.orderDetailsListView);
            this.Controls.Add(this.orderHistoryListView);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.orderHistoryLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "OrderHistoryForm";
            this.Text = "Order History";
            this.Load += new System.EventHandler(this.OrderHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderHistoryLabel;
        private System.Windows.Forms.Button showDetailsButton;
        private System.Windows.Forms.ListView orderHistoryListView;
        private System.Windows.Forms.ColumnHeader orderHistoryId;
        private System.Windows.Forms.ListView orderDetailsListView;
        private System.Windows.Forms.ColumnHeader currentOrderName;
        private System.Windows.Forms.ColumnHeader currentOrderPrice;
        private System.Windows.Forms.Label totalPrizeLabel;
        private System.Windows.Forms.Label prizeTitleLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.RichTextBox noteRichTextBox;
        private System.Windows.Forms.Label ordersLabel;
    }
}