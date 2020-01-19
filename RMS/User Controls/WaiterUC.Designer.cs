namespace RMS.User_Controls
{
    partial class WaiterUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddNewWaiter = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.WaiterList = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grdWaiterList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.WaiterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaiterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaiterContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaiterAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSpecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWaiterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(106)))), ((int)(((byte)(2)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 658);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(106)))), ((int)(((byte)(2)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1325, 10);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(106)))), ((int)(((byte)(2)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1315, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 658);
            this.panel4.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(106)))), ((int)(((byte)(2)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 725);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 10);
            this.panel1.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(106)))), ((int)(((byte)(2)))));
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.btnAddNewWaiter);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1325, 67);
            this.panel5.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(403, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(224, 67);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "   Update Data";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(233, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "   Delete";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddNewWaiter
            // 
            this.btnAddNewWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewWaiter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewWaiter.FlatAppearance.BorderSize = 0;
            this.btnAddNewWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewWaiter.ForeColor = System.Drawing.Color.White;
            this.btnAddNewWaiter.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewWaiter.Image")));
            this.btnAddNewWaiter.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewWaiter.Name = "btnAddNewWaiter";
            this.btnAddNewWaiter.Size = new System.Drawing.Size(233, 67);
            this.btnAddNewWaiter.TabIndex = 0;
            this.btnAddNewWaiter.Text = "   Add New Waiter";
            this.btnAddNewWaiter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewWaiter.UseVisualStyleBackColor = true;
            this.btnAddNewWaiter.Click += new System.EventHandler(this.btnAddNewWaiter_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.WaiterList);
            this.panel6.Controls.Add(this.grdWaiterList);
            this.panel6.Controls.Add(this.foodGridView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1325, 735);
            this.panel6.TabIndex = 16;
            // 
            // WaiterList
            // 
            this.WaiterList.AutoSize = true;
            this.WaiterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaiterList.Location = new System.Drawing.Point(587, 88);
            this.WaiterList.Name = "WaiterList";
            this.WaiterList.Size = new System.Drawing.Size(178, 29);
            this.WaiterList.TabIndex = 11;
            this.WaiterList.Text = "List of Waiters";
            // 
            // grdWaiterList
            // 
            this.grdWaiterList.AllowUserToAddRows = false;
            this.grdWaiterList.AllowUserToDeleteRows = false;
            this.grdWaiterList.AllowUserToResizeColumns = false;
            this.grdWaiterList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdWaiterList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdWaiterList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdWaiterList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdWaiterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdWaiterList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grdWaiterList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdWaiterList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdWaiterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWaiterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WaiterID,
            this.WaiterName,
            this.WaiterContact,
            this.WaiterAddress});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdWaiterList.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdWaiterList.DoubleBuffered = true;
            this.grdWaiterList.EnableHeadersVisualStyles = false;
            this.grdWaiterList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.grdWaiterList.HeaderForeColor = System.Drawing.Color.White;
            this.grdWaiterList.Location = new System.Drawing.Point(7, 119);
            this.grdWaiterList.Name = "grdWaiterList";
            this.grdWaiterList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdWaiterList.RowHeadersVisible = false;
            this.grdWaiterList.RowHeadersWidth = 51;
            this.grdWaiterList.RowTemplate.Height = 24;
            this.grdWaiterList.Size = new System.Drawing.Size(1315, 613);
            this.grdWaiterList.TabIndex = 10;
            // 
            // WaiterID
            // 
            this.WaiterID.DataPropertyName = "WaiterID";
            this.WaiterID.HeaderText = "  Waiter ID";
            this.WaiterID.MinimumWidth = 6;
            this.WaiterID.Name = "WaiterID";
            // 
            // WaiterName
            // 
            this.WaiterName.DataPropertyName = "WaiterName";
            this.WaiterName.HeaderText = "Waiter Name";
            this.WaiterName.MinimumWidth = 6;
            this.WaiterName.Name = "WaiterName";
            // 
            // WaiterContact
            // 
            this.WaiterContact.DataPropertyName = "WaiterContact";
            this.WaiterContact.HeaderText = "Waiter Contact";
            this.WaiterContact.MinimumWidth = 6;
            this.WaiterContact.Name = "WaiterContact";
            // 
            // WaiterAddress
            // 
            this.WaiterAddress.DataPropertyName = "WaiterAddress";
            this.WaiterAddress.HeaderText = "Waiter Address";
            this.WaiterAddress.MinimumWidth = 6;
            this.WaiterAddress.Name = "WaiterAddress";
            // 
            // foodGridView
            // 
            this.foodGridView.AllowUserToAddRows = false;
            this.foodGridView.AllowUserToDeleteRows = false;
            this.foodGridView.AllowUserToResizeColumns = false;
            this.foodGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.foodGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.foodGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.foodGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.foodGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.foodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sn,
            this.InvoiceNumber,
            this.Date,
            this.Amount,
            this.Status,
            this.isSpecial,
            this.Discount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.foodGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodGridView.DoubleBuffered = true;
            this.foodGridView.EnableHeadersVisualStyles = false;
            this.foodGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.foodGridView.HeaderForeColor = System.Drawing.Color.White;
            this.foodGridView.Location = new System.Drawing.Point(0, 0);
            this.foodGridView.Name = "foodGridView";
            this.foodGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.foodGridView.RowHeadersVisible = false;
            this.foodGridView.RowHeadersWidth = 51;
            this.foodGridView.RowTemplate.Height = 24;
            this.foodGridView.Size = new System.Drawing.Size(1325, 735);
            this.foodGridView.TabIndex = 9;
            // 
            // Sn
            // 
            this.Sn.DataPropertyName = "Id";
            this.Sn.HeaderText = "      S.N";
            this.Sn.MinimumWidth = 6;
            this.Sn.Name = "Sn";
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DataPropertyName = "CategoryName";
            this.InvoiceNumber.HeaderText = "Category Name";
            this.InvoiceNumber.MinimumWidth = 6;
            this.InvoiceNumber.Name = "InvoiceNumber";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "FoodName";
            this.Date.HeaderText = "Food Name";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Price";
            this.Amount.HeaderText = "Price";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // isSpecial
            // 
            this.isSpecial.DataPropertyName = "isSpecial";
            this.isSpecial.HeaderText = "Is Special?";
            this.isSpecial.MinimumWidth = 6;
            this.isSpecial.Name = "isSpecial";
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // WaiterUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "WaiterUC";
            this.Size = new System.Drawing.Size(1325, 735);
            this.Load += new System.EventHandler(this.WaiterUC_Load_1);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWaiterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddNewWaiter;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuCustomDataGrid foodGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn isSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grdWaiterList;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaiterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaiterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaiterContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaiterAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel WaiterList;
    }
}
