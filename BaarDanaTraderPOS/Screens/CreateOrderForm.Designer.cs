
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.tbOrderCustomerName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCOConfirm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCORemoveProduct = new System.Windows.Forms.Button();
            this.btnCOAddProduct = new System.Windows.Forms.Button();
            this.btnCOCancel = new System.Windows.Forms.Button();
            this.tbOrderProductQuantity = new System.Windows.Forms.TextBox();
            this.tbOrderProductPrice = new System.Windows.Forms.TextBox();
            this.tbOrderProductName = new System.Windows.Forms.TextBox();
            this.tbOrderProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(3, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(555, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(569, 167);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 62;
            this.dgvOrderItems.RowTemplate.Height = 28;
            this.dgvOrderItems.Size = new System.Drawing.Size(833, 343);
            this.dgvOrderItems.TabIndex = 6;
            // 
            // tbOrderCustomerName
            // 
            this.tbOrderCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbOrderCustomerName.Location = new System.Drawing.Point(217, 18);
            this.tbOrderCustomerName.Name = "tbOrderCustomerName";
            this.tbOrderCustomerName.Size = new System.Drawing.Size(319, 35);
            this.tbOrderCustomerName.TabIndex = 8;
            this.tbOrderCustomerName.TextChanged += new System.EventHandler(this.tbOrderCustomerName_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(715, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 35);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCOConfirm
            // 
            this.btnCOConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOConfirm.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCOConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCOConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOConfirm.ForeColor = System.Drawing.Color.White;
            this.btnCOConfirm.Location = new System.Drawing.Point(1772, 575);
            this.btnCOConfirm.Name = "btnCOConfirm";
            this.btnCOConfirm.Size = new System.Drawing.Size(186, 120);
            this.btnCOConfirm.TabIndex = 16;
            this.btnCOConfirm.Text = "Confirm and\r\nGenerate Reciept";
            this.btnCOConfirm.UseVisualStyleBackColor = false;
            this.btnCOConfirm.Click += new System.EventHandler(this.btnCOConfirm_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(861, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Grand Total (Rs):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGrandTotal.Location = new System.Drawing.Point(1099, 570);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(31, 32);
            this.lblGrandTotal.TabIndex = 18;
            this.lblGrandTotal.Text = "0";
            this.lblGrandTotal.Click += new System.EventHandler(this.lblGrandTotal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 40);
            this.label8.TabIndex = 19;
            this.label8.Text = "Create Order";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(38, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 113);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCORemoveProduct);
            this.panel2.Controls.Add(this.btnCOAddProduct);
            this.panel2.Controls.Add(this.btnCOCancel);
            this.panel2.Controls.Add(this.tbOrderProductQuantity);
            this.panel2.Controls.Add(this.tbOrderProductPrice);
            this.panel2.Controls.Add(this.tbOrderProductName);
            this.panel2.Controls.Add(this.tbOrderProductID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 479);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCORemoveProduct
            // 
            this.btnCORemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCORemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCORemoveProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCORemoveProduct.ForeColor = System.Drawing.Color.White;
            this.btnCORemoveProduct.Location = new System.Drawing.Point(153, 355);
            this.btnCORemoveProduct.Name = "btnCORemoveProduct";
            this.btnCORemoveProduct.Size = new System.Drawing.Size(120, 80);
            this.btnCORemoveProduct.TabIndex = 26;
            this.btnCORemoveProduct.Text = "Remove Product";
            this.btnCORemoveProduct.UseVisualStyleBackColor = false;
            // 
            // btnCOAddProduct
            // 
            this.btnCOAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCOAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCOAddProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnCOAddProduct.Location = new System.Drawing.Point(293, 355);
            this.btnCOAddProduct.Name = "btnCOAddProduct";
            this.btnCOAddProduct.Size = new System.Drawing.Size(120, 80);
            this.btnCOAddProduct.TabIndex = 25;
            this.btnCOAddProduct.Text = "Add Product";
            this.btnCOAddProduct.UseVisualStyleBackColor = false;
            // 
            // btnCOCancel
            // 
            this.btnCOCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCOCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCOCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOCancel.Location = new System.Drawing.Point(14, 355);
            this.btnCOCancel.Name = "btnCOCancel";
            this.btnCOCancel.Size = new System.Drawing.Size(120, 80);
            this.btnCOCancel.TabIndex = 24;
            this.btnCOCancel.Text = "Cancel";
            this.btnCOCancel.UseVisualStyleBackColor = false;
            // 
            // tbOrderProductQuantity
            // 
            this.tbOrderProductQuantity.Location = new System.Drawing.Point(187, 263);
            this.tbOrderProductQuantity.Name = "tbOrderProductQuantity";
            this.tbOrderProductQuantity.Size = new System.Drawing.Size(208, 26);
            this.tbOrderProductQuantity.TabIndex = 23;
            // 
            // tbOrderProductPrice
            // 
            this.tbOrderProductPrice.Location = new System.Drawing.Point(187, 186);
            this.tbOrderProductPrice.Name = "tbOrderProductPrice";
            this.tbOrderProductPrice.Size = new System.Drawing.Size(208, 26);
            this.tbOrderProductPrice.TabIndex = 22;
            // 
            // tbOrderProductName
            // 
            this.tbOrderProductName.Location = new System.Drawing.Point(187, 107);
            this.tbOrderProductName.Name = "tbOrderProductName";
            this.tbOrderProductName.Size = new System.Drawing.Size(208, 26);
            this.tbOrderProductName.TabIndex = 21;
            // 
            // tbOrderProductID
            // 
            this.tbOrderProductID.Location = new System.Drawing.Point(187, 35);
            this.tbOrderProductID.MaxLength = 4;
            this.tbOrderProductID.Name = "tbOrderProductID";
            this.tbOrderProductID.Size = new System.Drawing.Size(208, 26);
            this.tbOrderProductID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantity (Creates):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbOrderCustomerName);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(493, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 78);
            this.panel3.TabIndex = 21;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1187, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 99);
            this.button1.TabIndex = 27;
            this.button1.Text = "Generate Slip";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1620, 855);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCOConfirm);
            this.Controls.Add(this.dgvOrderItems);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.TextBox tbOrderCustomerName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCOConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCORemoveProduct;
        private System.Windows.Forms.Button btnCOAddProduct;
        private System.Windows.Forms.Button btnCOCancel;
        private System.Windows.Forms.TextBox tbOrderProductQuantity;
        private System.Windows.Forms.TextBox tbOrderProductPrice;
        private System.Windows.Forms.TextBox tbOrderProductName;
        private System.Windows.Forms.TextBox tbOrderProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}