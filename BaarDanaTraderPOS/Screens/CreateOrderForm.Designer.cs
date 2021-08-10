
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
            this.cbCustomername = new System.Windows.Forms.ComboBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.tbPaidAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblChange = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "گاہک کا نام";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(927, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "موجودہ تاریخ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOrderItems.Location = new System.Drawing.Point(620, 169);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvOrderItems.RowHeadersWidth = 62;
            this.dgvOrderItems.RowTemplate.Height = 28;
            this.dgvOrderItems.Size = new System.Drawing.Size(1196, 478);
            this.dgvOrderItems.TabIndex = 6;
            this.dgvOrderItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderItems_CellContentClick);
            this.dgvOrderItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderItems_CellDoubleClick);
            this.dgvOrderItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderItems_CellValueChanged);
            this.dgvOrderItems.Validated += new System.EventHandler(this.dgvOrderItems_Validated);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(616, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 44);
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
            this.btnCOConfirm.Location = new System.Drawing.Point(4631, 575);
            this.btnCOConfirm.Name = "btnCOConfirm";
            this.btnCOConfirm.Size = new System.Drawing.Size(186, 120);
            this.btnCOConfirm.TabIndex = 16;
            this.btnCOConfirm.Text = "Confirm and\r\nGenerate Reciept";
            this.btnCOConfirm.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 37);
            this.label7.TabIndex = 17;
            this.label7.Text = "کل رقم۔";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGrandTotal.Location = new System.Drawing.Point(46, 23);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(35, 37);
            this.lblGrandTotal.TabIndex = 18;
            this.lblGrandTotal.Text = "0";
            this.lblGrandTotal.Click += new System.EventHandler(this.lblGrandTotal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 47);
            this.label8.TabIndex = 19;
            this.label8.Text = "آرڈر بنائیں۔";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(38, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 120);
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
            this.panel2.Location = new System.Drawing.Point(38, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 478);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCORemoveProduct
            // 
            this.btnCORemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCORemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCORemoveProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCORemoveProduct.ForeColor = System.Drawing.Color.White;
            this.btnCORemoveProduct.Location = new System.Drawing.Point(167, 354);
            this.btnCORemoveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnCORemoveProduct.Name = "btnCORemoveProduct";
            this.btnCORemoveProduct.Size = new System.Drawing.Size(140, 90);
            this.btnCORemoveProduct.TabIndex = 26;
            this.btnCORemoveProduct.Text = "آئٹم کو ہٹا دیں";
            this.btnCORemoveProduct.UseVisualStyleBackColor = false;
            this.btnCORemoveProduct.Click += new System.EventHandler(this.btnCORemoveProduct_Click_1);
            // 
            // btnCOAddProduct
            // 
            this.btnCOAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCOAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCOAddProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnCOAddProduct.Location = new System.Drawing.Point(315, 354);
            this.btnCOAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnCOAddProduct.Name = "btnCOAddProduct";
            this.btnCOAddProduct.Size = new System.Drawing.Size(140, 90);
            this.btnCOAddProduct.TabIndex = 5;
            this.btnCOAddProduct.Text = "آئٹم شامل کریں";
            this.btnCOAddProduct.UseVisualStyleBackColor = false;
            this.btnCOAddProduct.Click += new System.EventHandler(this.btnCOAddProduct_Click_1);
            // 
            // btnCOCancel
            // 
            this.btnCOCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCOCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCOCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOCancel.Location = new System.Drawing.Point(19, 354);
            this.btnCOCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCOCancel.Name = "btnCOCancel";
            this.btnCOCancel.Size = new System.Drawing.Size(140, 90);
            this.btnCOCancel.TabIndex = 24;
            this.btnCOCancel.Text = "منسوخ کریں";
            this.btnCOCancel.UseVisualStyleBackColor = false;
            this.btnCOCancel.Click += new System.EventHandler(this.btnCOCancel_Click_1);
            // 
            // tbOrderProductQuantity
            // 
            this.tbOrderProductQuantity.Enabled = false;
            this.tbOrderProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderProductQuantity.Location = new System.Drawing.Point(38, 255);
            this.tbOrderProductQuantity.Name = "tbOrderProductQuantity";
            this.tbOrderProductQuantity.Size = new System.Drawing.Size(208, 39);
            this.tbOrderProductQuantity.TabIndex = 23;
            // 
            // tbOrderProductPrice
            // 
            this.tbOrderProductPrice.Enabled = false;
            this.tbOrderProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderProductPrice.Location = new System.Drawing.Point(38, 180);
            this.tbOrderProductPrice.Name = "tbOrderProductPrice";
            this.tbOrderProductPrice.Size = new System.Drawing.Size(208, 39);
            this.tbOrderProductPrice.TabIndex = 22;
            // 
            // tbOrderProductName
            // 
            this.tbOrderProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderProductName.Location = new System.Drawing.Point(38, 108);
            this.tbOrderProductName.Name = "tbOrderProductName";
            this.tbOrderProductName.Size = new System.Drawing.Size(208, 39);
            this.tbOrderProductName.TabIndex = 21;
            // 
            // tbOrderProductID
            // 
            this.tbOrderProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderProductID.Location = new System.Drawing.Point(38, 32);
            this.tbOrderProductID.MaxLength = 4;
            this.tbOrderProductID.Name = "tbOrderProductID";
            this.tbOrderProductID.Size = new System.Drawing.Size(208, 39);
            this.tbOrderProductID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "آئٹم کی قیمت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = " مقدار (کریٹ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "آئٹم کا نام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID آئٹم";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.cbCustomername);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(620, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1196, 112);
            this.panel3.TabIndex = 21;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cbCustomername
            // 
            this.cbCustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomername.FormattingEnabled = true;
            this.cbCustomername.Location = new System.Drawing.Point(33, 49);
            this.cbCustomername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomername.Name = "cbCustomername";
            this.cbCustomername.Size = new System.Drawing.Size(366, 45);
            this.cbCustomername.TabIndex = 13;
            this.cbCustomername.SelectedIndexChanged += new System.EventHandler(this.cbCustomername_SelectedIndexChanged);
            this.cbCustomername.SelectedValueChanged += new System.EventHandler(this.cbCustomername_SelectedValueChanged);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Confirm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.White;
            this.btn_Confirm.Location = new System.Drawing.Point(1284, 817);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(434, 58);
            this.btn_Confirm.TabIndex = 27;
            this.btn_Confirm.Text = "رسید تیار کریں۔";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // tbPaidAmount
            // 
            this.tbPaidAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaidAmount.Location = new System.Drawing.Point(1284, 735);
            this.tbPaidAmount.MaxLength = 0;
            this.tbPaidAmount.Name = "tbPaidAmount";
            this.tbPaidAmount.Size = new System.Drawing.Size(295, 39);
            this.tbPaidAmount.TabIndex = 29;
            this.tbPaidAmount.TextChanged += new System.EventHandler(this.tbPaidAmount_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1597, 735);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 37);
            this.label9.TabIndex = 28;
            this.label9.Text = "ادا شدہ رقم";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.lblChange);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lblFinal);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblBalance);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblGrandTotal);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(732, 669);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 269);
            this.panel4.TabIndex = 30;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.Red;
            this.lblChange.Location = new System.Drawing.Point(46, 215);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(35, 37);
            this.lblChange.TabIndex = 35;
            this.lblChange.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(254, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 37);
            this.label14.TabIndex = 34;
            this.label14.Text = "رقم واپس کریں۔";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.ForeColor = System.Drawing.Color.Red;
            this.lblFinal.Location = new System.Drawing.Point(46, 149);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(35, 37);
            this.lblFinal.TabIndex = 33;
            this.lblFinal.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(310, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 37);
            this.label12.TabIndex = 32;
            this.label12.Text = "آخری کل۔";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Red;
            this.lblBalance.Location = new System.Drawing.Point(46, 86);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(35, 37);
            this.lblBalance.TabIndex = 31;
            this.lblBalance.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(341, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 37);
            this.label10.TabIndex = 30;
            this.label10.Text = "توازن۔";
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1884, 952);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCOConfirm);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPaidAmount);
            this.MinimumSize = new System.Drawing.Size(1906, 668);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOrderItems;
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
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.TextBox tbPaidAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCustomername;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label label12;
    }
}