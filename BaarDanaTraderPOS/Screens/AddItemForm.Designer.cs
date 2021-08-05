
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
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(32, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price (Rs): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(32, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity \r\n(Creates): ";
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbItemName.Location = new System.Drawing.Point(145, 92);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(2);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(137, 26);
            this.tbItemName.TabIndex = 5;
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbItemPrice.Location = new System.Drawing.Point(145, 134);
            this.tbItemPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(137, 26);
            this.tbItemPrice.TabIndex = 6;
            // 
            // tbItemQuantity
            // 
            this.tbItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbItemQuantity.Location = new System.Drawing.Point(145, 187);
            this.tbItemQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.tbItemQuantity.Name = "tbItemQuantity";
            this.tbItemQuantity.Size = new System.Drawing.Size(137, 26);
            this.tbItemQuantity.TabIndex = 7;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnItemAdd.ForeColor = System.Drawing.Color.White;
            this.btnItemAdd.Location = new System.Drawing.Point(177, 315);
            this.btnItemAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(73, 45);
            this.btnItemAdd.TabIndex = 8;
            this.btnItemAdd.Text = "Add";
            this.btnItemAdd.UseVisualStyleBackColor = false;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnItemCancel
            // 
            this.btnItemCancel.BackColor = System.Drawing.Color.White;
            this.btnItemCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnItemCancel.Location = new System.Drawing.Point(14, 315);
            this.btnItemCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemCancel.Name = "btnItemCancel";
            this.btnItemCancel.Size = new System.Drawing.Size(73, 45);
            this.btnItemCancel.TabIndex = 9;
            this.btnItemCancel.Text = "Cancel";
            this.btnItemCancel.UseVisualStyleBackColor = false;
            this.btnItemCancel.Click += new System.EventHandler(this.btnItemCancel_Click);
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnItemUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnItemUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnItemUpdate.Location = new System.Drawing.Point(95, 315);
            this.btnItemUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(73, 45);
            this.btnItemUpdate.TabIndex = 10;
            this.btnItemUpdate.Text = "Update";
            this.btnItemUpdate.UseVisualStyleBackColor = false;
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnItemDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItemDelete.Location = new System.Drawing.Point(258, 315);
            this.btnItemDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(73, 45);
            this.btnItemDelete.TabIndex = 11;
            this.btnItemDelete.Text = "Delete";
            this.btnItemDelete.UseVisualStyleBackColor = false;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(353, 79);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.RowTemplate.Height = 28;
            this.dgvItems.Size = new System.Drawing.Size(569, 348);
            this.dgvItems.TabIndex = 12;
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            // 
            // tbAISearch
            // 
            this.tbAISearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAISearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAISearch.Location = new System.Drawing.Point(493, 37);
            this.tbAISearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbAISearch.Name = "tbAISearch";
            this.tbAISearch.Size = new System.Drawing.Size(330, 23);
            this.tbAISearch.TabIndex = 18;
            this.tbAISearch.TextChanged += new System.EventHandler(this.tbAISearch_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search by Name:";
            // 
            // btnAISearch
            // 
            this.btnAISearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAISearch.Location = new System.Drawing.Point(831, 37);
            this.btnAISearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAISearch.Name = "btnAISearch";
            this.btnAISearch.Size = new System.Drawing.Size(60, 23);
            this.btnAISearch.TabIndex = 16;
            this.btnAISearch.Text = "Search";
            this.btnAISearch.UseVisualStyleBackColor = true;
            this.btnAISearch.Click += new System.EventHandler(this.btnAISearch_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(938, 449);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
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