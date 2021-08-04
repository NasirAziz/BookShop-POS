
namespace BaarDanaTraderPOS.Screens
{
    partial class AddCustomerForm
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
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.dgvAddCustomers = new System.Windows.Forms.DataGridView();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnACSearch = new System.Windows.Forms.Button();
            this.tbACSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCustomerAdd.ForeColor = System.Drawing.Color.White;
            this.btnCustomerAdd.Location = new System.Drawing.Point(284, 449);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(110, 70);
            this.btnCustomerAdd.TabIndex = 0;
            this.btnCustomerAdd.Text = "Add";
            this.btnCustomerAdd.UseVisualStyleBackColor = false;
            // 
            // btnCustomerCancel
            // 
            this.btnCustomerCancel.BackColor = System.Drawing.Color.White;
            this.btnCustomerCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCustomerCancel.Location = new System.Drawing.Point(52, 449);
            this.btnCustomerCancel.Name = "btnCustomerCancel";
            this.btnCustomerCancel.Size = new System.Drawing.Size(110, 70);
            this.btnCustomerCancel.TabIndex = 1;
            this.btnCustomerCancel.Text = "Cancel";
            this.btnCustomerCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Location:";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerID.Location = new System.Drawing.Point(194, 91);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(230, 30);
            this.tbCustomerID.TabIndex = 6;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(194, 169);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(230, 30);
            this.tbCustomerName.TabIndex = 7;
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerPhone.Location = new System.Drawing.Point(194, 247);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(230, 30);
            this.tbCustomerPhone.TabIndex = 8;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(194, 320);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(230, 30);
            this.tbCustomer.TabIndex = 9;
            // 
            // dgvAddCustomers
            // 
            this.dgvAddCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAddCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddCustomers.Location = new System.Drawing.Point(550, 145);
            this.dgvAddCustomers.Name = "dgvAddCustomers";
            this.dgvAddCustomers.RowHeadersWidth = 62;
            this.dgvAddCustomers.RowTemplate.Height = 28;
            this.dgvAddCustomers.Size = new System.Drawing.Size(734, 502);
            this.dgvAddCustomers.TabIndex = 10;
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCustomerUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCustomerUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(168, 449);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(110, 70);
            this.btnCustomerUpdate.TabIndex = 11;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCustomerDelete.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDelete.Location = new System.Drawing.Point(400, 449);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(110, 70);
            this.btnCustomerDelete.TabIndex = 12;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            // 
            // btnACSearch
            // 
            this.btnACSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnACSearch.Location = new System.Drawing.Point(1131, 85);
            this.btnACSearch.Name = "btnACSearch";
            this.btnACSearch.Size = new System.Drawing.Size(90, 35);
            this.btnACSearch.TabIndex = 13;
            this.btnACSearch.Text = "Search";
            this.btnACSearch.UseVisualStyleBackColor = true;
            // 
            // tbACSearch
            // 
            this.tbACSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbACSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbACSearch.Location = new System.Drawing.Point(764, 88);
            this.tbACSearch.Name = "tbACSearch";
            this.tbACSearch.Size = new System.Drawing.Size(352, 30);
            this.tbACSearch.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(594, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Search by Name:";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 689);
            this.Controls.Add(this.tbACSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnACSearch);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.dgvAddCustomers);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.tbCustomerPhone);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerCancel);
            this.Controls.Add(this.btnCustomerAdd);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerPhone;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.DataGridView dgvAddCustomers;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnACSearch;
        private System.Windows.Forms.TextBox tbACSearch;
        private System.Windows.Forms.Label label5;
    }
}