
namespace BaarDanaTraderPOS.Screens
{
    partial class ViewHistoryForm
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
            this.tbCustomerSearch = new System.Windows.Forms.TextBox();
            this.dgvViewHistory = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.Show_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Customer Name:";
            // 
            // tbCustomerSearch
            // 
            this.tbCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCustomerSearch.Location = new System.Drawing.Point(223, 37);
            this.tbCustomerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerSearch.Name = "tbCustomerSearch";
            this.tbCustomerSearch.Size = new System.Drawing.Size(188, 23);
            this.tbCustomerSearch.TabIndex = 1;
            // 
            // dgvViewHistory
            // 
            this.dgvViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewHistory.Location = new System.Drawing.Point(120, 108);
            this.dgvViewHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvViewHistory.Name = "dgvViewHistory";
            this.dgvViewHistory.RowHeadersWidth = 62;
            this.dgvViewHistory.RowTemplate.Height = 28;
            this.dgvViewHistory.Size = new System.Drawing.Size(850, 397);
            this.dgvViewHistory.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_search.Location = new System.Drawing.Point(429, 34);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(67, 25);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_print.Location = new System.Drawing.Point(818, 510);
            this.btn_print.Margin = new System.Windows.Forms.Padding(2);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(93, 25);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "Print ";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.to);
            this.panel1.Controls.Add(this.from);
            this.panel1.Controls.Add(this.Show_All);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbCustomerSearch);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Location = new System.Drawing.Point(120, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 86);
            this.panel1.TabIndex = 5;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(684, 61);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(144, 20);
            this.to.TabIndex = 7;
            this.to.ValueChanged += new System.EventHandler(this.to_ValueChanged);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(684, 3);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(144, 20);
            this.from.TabIndex = 6;
            this.from.ValueChanged += new System.EventHandler(this.from_ValueChanged);
            // 
            // Show_All
            // 
            this.Show_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Show_All.Location = new System.Drawing.Point(513, 34);
            this.Show_All.Margin = new System.Windows.Forms.Padding(2);
            this.Show_All.Name = "Show_All";
            this.Show_All.Size = new System.Drawing.Size(112, 25);
            this.Show_All.TabIndex = 5;
            this.Show_All.Text = "Show All";
            this.Show_All.UseVisualStyleBackColor = true;
            // 
            // ViewHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvViewHistory);
            this.Controls.Add(this.btn_print);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewHistoryForm";
            this.Text = "ViewHistoryForm";
            this.Load += new System.EventHandler(this.ViewHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerSearch;
        private System.Windows.Forms.DataGridView dgvViewHistory;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Show_All;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.DateTimePicker from;
    }
}