
namespace BaarDanaTraderPOS.Screens
{
    partial class CreateOrderForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.tbOrderProductID = new System.Windows.Forms.TextBox();
            this.tbOrderCustomerName = new System.Windows.Forms.TextBox();
            this.tbOrderProductName = new System.Windows.Forms.TextBox();
            this.tbOrderProductPrice = new System.Windows.Forms.TextBox();
            this.tbOrderProductQuantity = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCOCancel = new System.Windows.Forms.Button();
            this.btnCOAddProduct = new System.Windows.Forms.Button();
            this.btnCORemoveProduct = new System.Windows.Forms.Button();
            this.btnCOConfirm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity (Creates):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current Date:";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(511, 12);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 62;
            this.dgvOrderItems.RowTemplate.Height = 28;
            this.dgvOrderItems.Size = new System.Drawing.Size(1196, 526);
            this.dgvOrderItems.TabIndex = 6;
            // 
            // tbOrderProductID
            // 
            this.tbOrderProductID.Location = new System.Drawing.Point(224, 77);
            this.tbOrderProductID.MaxLength = 4;
            this.tbOrderProductID.Name = "tbOrderProductID";
            this.tbOrderProductID.Size = new System.Drawing.Size(208, 26);
            this.tbOrderProductID.TabIndex = 7;
            // 
            // tbOrderCustomerName
            // 
            this.tbOrderCustomerName.Location = new System.Drawing.Point(172, 600);
            this.tbOrderCustomerName.Name = "tbOrderCustomerName";
            this.tbOrderCustomerName.Size = new System.Drawing.Size(260, 26);
            this.tbOrderCustomerName.TabIndex = 8;
            // 
            // tbOrderProductName
            // 
            this.tbOrderProductName.Location = new System.Drawing.Point(224, 149);
            this.tbOrderProductName.Name = "tbOrderProductName";
            this.tbOrderProductName.Size = new System.Drawing.Size(208, 26);
            this.tbOrderProductName.TabIndex = 9;
            // 
            // tbOrderProductPrice
            // 
            this.tbOrderProductPrice.Location = new System.Drawing.Point(224, 228);
            this.tbOrderProductPrice.Name = "tbOrderProductPrice";
            this.tbOrderProductPrice.Size = new System.Drawing.Size(208, 26);
            this.tbOrderProductPrice.TabIndex = 10;
            // 
            // tbOrderProductQuantity
            // 
            this.tbOrderProductQuantity.Location = new System.Drawing.Point(224, 304);
            this.tbOrderProductQuantity.Name = "tbOrderProductQuantity";
            this.tbOrderProductQuantity.Size = new System.Drawing.Size(208, 26);
            this.tbOrderProductQuantity.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 550);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnCOCancel
            // 
            this.btnCOCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCOCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCOCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOCancel.Location = new System.Drawing.Point(33, 399);
            this.btnCOCancel.Name = "btnCOCancel";
            this.btnCOCancel.Size = new System.Drawing.Size(120, 80);
            this.btnCOCancel.TabIndex = 13;
            this.btnCOCancel.Text = "Cancel";
            this.btnCOCancel.UseVisualStyleBackColor = false;
            this.btnCOCancel.Click += new System.EventHandler(this.btnCOCancel_Click);
            // 
            // btnCOAddProduct
            // 
            this.btnCOAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCOAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCOAddProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnCOAddProduct.Location = new System.Drawing.Point(312, 399);
            this.btnCOAddProduct.Name = "btnCOAddProduct";
            this.btnCOAddProduct.Size = new System.Drawing.Size(120, 80);
            this.btnCOAddProduct.TabIndex = 14;
            this.btnCOAddProduct.Text = "Add Product";
            this.btnCOAddProduct.UseVisualStyleBackColor = false;
            this.btnCOAddProduct.Click += new System.EventHandler(this.btnCOAddProduct_Click);
            // 
            // btnCORemoveProduct
            // 
            this.btnCORemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCORemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCORemoveProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCORemoveProduct.ForeColor = System.Drawing.Color.White;
            this.btnCORemoveProduct.Location = new System.Drawing.Point(172, 399);
            this.btnCORemoveProduct.Name = "btnCORemoveProduct";
            this.btnCORemoveProduct.Size = new System.Drawing.Size(120, 80);
            this.btnCORemoveProduct.TabIndex = 15;
            this.btnCORemoveProduct.Text = "Remove Product";
            this.btnCORemoveProduct.UseVisualStyleBackColor = false;
            this.btnCORemoveProduct.Click += new System.EventHandler(this.btnCORemoveProduct_Click);
            // 
            // btnCOConfirm
            // 
            this.btnCOConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOConfirm.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCOConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCOConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOConfirm.ForeColor = System.Drawing.Color.White;
            this.btnCOConfirm.Location = new System.Drawing.Point(1521, 575);
            this.btnCOConfirm.Name = "btnCOConfirm";
            this.btnCOConfirm.Size = new System.Drawing.Size(186, 120);
            this.btnCOConfirm.TabIndex = 16;
            this.btnCOConfirm.Text = "Confirm and\r\nGenerate Reciept";
            this.btnCOConfirm.UseVisualStyleBackColor = false;
            this.btnCOConfirm.Click += new System.EventHandler(this.btnCOConfirm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(505, 591);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Grand Total (Rs):";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGrandTotal.Location = new System.Drawing.Point(743, 591);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(31, 32);
            this.lblGrandTotal.TabIndex = 18;
            this.lblGrandTotal.Text = "0";
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 836);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCOConfirm);
            this.Controls.Add(this.btnCORemoveProduct);
            this.Controls.Add(this.btnCOAddProduct);
            this.Controls.Add(this.btnCOCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbOrderProductQuantity);
            this.Controls.Add(this.tbOrderProductPrice);
            this.Controls.Add(this.tbOrderProductName);
            this.Controls.Add(this.tbOrderCustomerName);
            this.Controls.Add(this.tbOrderProductID);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.TextBox tbOrderProductID;
        private System.Windows.Forms.TextBox tbOrderCustomerName;
        private System.Windows.Forms.TextBox tbOrderProductName;
        private System.Windows.Forms.TextBox tbOrderProductPrice;
        private System.Windows.Forms.TextBox tbOrderProductQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCOCancel;
        private System.Windows.Forms.Button btnCOAddProduct;
        private System.Windows.Forms.Button btnCORemoveProduct;
        private System.Windows.Forms.Button btnCOConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}