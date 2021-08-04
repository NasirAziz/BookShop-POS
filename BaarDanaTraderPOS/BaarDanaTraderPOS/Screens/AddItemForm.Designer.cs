
namespace BaarDanaTraderPOS.Screens
{
    partial class AddItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.tbItemQuantity = new System.Windows.Forms.TextBox();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnItemCancel = new System.Windows.Forms.Button();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.tbAISearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAISearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(42, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(42, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price (Rs): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(42, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(42, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 58);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity \r\n(Creates): ";
            // 
            // tbItemID
            // 
            this.tbItemID.BackColor = System.Drawing.Color.White;
            this.tbItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbItemID.Location = new System.Drawing.Point(212, 122);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(203, 35);
            this.tbItemID.TabIndex = 4;
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbItemName.Location = new System.Drawing.Point(212, 185);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(203, 35);
            this.tbItemName.TabIndex = 5;
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbItemPrice.Location = new System.Drawing.Point(212, 249);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(203, 35);
            this.tbItemPrice.TabIndex = 6;
            // 
            // tbItemQuantity
            // 
            this.tbItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbItemQuantity.Location = new System.Drawing.Point(212, 331);
            this.tbItemQuantity.Name = "tbItemQuantity";
            this.tbItemQuantity.Size = new System.Drawing.Size(203, 35);
            this.tbItemQuantity.TabIndex = 7;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnItemAdd.ForeColor = System.Drawing.Color.White;
            this.btnItemAdd.Location = new System.Drawing.Point(265, 485);
            this.btnItemAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(110, 70);
            this.btnItemAdd.TabIndex = 8;
            this.btnItemAdd.Text = "Add";
            this.btnItemAdd.UseVisualStyleBackColor = false;
            // 
            // btnItemCancel
            // 
            this.btnItemCancel.BackColor = System.Drawing.Color.White;
            this.btnItemCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnItemCancel.Location = new System.Drawing.Point(21, 485);
            this.btnItemCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnItemCancel.Name = "btnItemCancel";
            this.btnItemCancel.Size = new System.Drawing.Size(110, 70);
            this.btnItemCancel.TabIndex = 9;
            this.btnItemCancel.Text = "Cancel";
            this.btnItemCancel.UseVisualStyleBackColor = false;
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnItemUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnItemUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnItemUpdate.Location = new System.Drawing.Point(143, 485);
            this.btnItemUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(110, 70);
            this.btnItemUpdate.TabIndex = 10;
            this.btnItemUpdate.Text = "Update";
            this.btnItemUpdate.UseVisualStyleBackColor = false;
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnItemDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItemDelete.Location = new System.Drawing.Point(387, 485);
            this.btnItemDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(110, 70);
            this.btnItemDelete.TabIndex = 11;
            this.btnItemDelete.Text = "Delete";
            this.btnItemDelete.UseVisualStyleBackColor = false;
            // 
            // dgvItems
            // 
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(529, 122);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.RowTemplate.Height = 28;
            this.dgvItems.Size = new System.Drawing.Size(655, 535);
            this.dgvItems.TabIndex = 12;
            // 
            // tbAISearch
            // 
            this.tbAISearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAISearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAISearch.Location = new System.Drawing.Point(739, 57);
            this.tbAISearch.Name = "tbAISearch";
            this.tbAISearch.Size = new System.Drawing.Size(295, 30);
            this.tbAISearch.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search by Name:";
            // 
            // btnAISearch
            // 
            this.btnAISearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAISearch.Location = new System.Drawing.Point(1049, 57);
            this.btnAISearch.Name = "btnAISearch";
            this.btnAISearch.Size = new System.Drawing.Size(90, 35);
            this.btnAISearch.TabIndex = 16;
            this.btnAISearch.Text = "Search";
            this.btnAISearch.UseVisualStyleBackColor = true;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1209, 691);
            this.Controls.Add(this.tbAISearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAISearch);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnItemDelete);
            this.Controls.Add(this.btnItemUpdate);
            this.Controls.Add(this.btnItemCancel);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.tbItemQuantity);
            this.Controls.Add(this.tbItemPrice);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.tbItemID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbItemPrice;
        private System.Windows.Forms.TextBox tbItemQuantity;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnItemCancel;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox tbAISearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAISearch;
    }
}