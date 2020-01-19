namespace RMS.User_Controls
{
    partial class AllFoodItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllFoodItems));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForGridView = new System.Windows.Forms.Panel();
            this.foodGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSpecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopContainer = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuMetroSearchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelBorderLeft = new System.Windows.Forms.Panel();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.panelTopBorder = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelForGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).BeginInit();
            this.panelTopContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.panelForGridView);
            this.panelMain.Controls.Add(this.panelTopContainer);
            this.panelMain.Controls.Add(this.panelFooter);
            this.panelMain.Controls.Add(this.panelBorderLeft);
            this.panelMain.Controls.Add(this.panelBorderRight);
            this.panelMain.Controls.Add(this.panelTopBorder);
            this.panelMain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1314, 771);
            this.panelMain.TabIndex = 2;
            // 
            // panelForGridView
            // 
            this.panelForGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panelForGridView.Controls.Add(this.foodGridView);
            this.panelForGridView.Location = new System.Drawing.Point(10, 116);
            this.panelForGridView.Name = "panelForGridView";
            this.panelForGridView.Size = new System.Drawing.Size(1291, 648);
            this.panelForGridView.TabIndex = 6;
            // 
            // foodGridView
            // 
            this.foodGridView.AllowUserToAddRows = false;
            this.foodGridView.AllowUserToDeleteRows = false;
            this.foodGridView.AllowUserToResizeColumns = false;
            this.foodGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.foodGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.foodGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.foodGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.foodGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.foodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sn,
            this.InvoiceNumber,
            this.Date,
            this.Amount,
            this.Status,
            this.isSpecial,
            this.Discount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodGridView.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.foodGridView.Size = new System.Drawing.Size(1291, 648);
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
            // panelTopContainer
            // 
            this.panelTopContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panelTopContainer.Controls.Add(this.button3);
            this.panelTopContainer.Controls.Add(this.bunifuMetroSearchBox);
            this.panelTopContainer.Controls.Add(this.button2);
            this.panelTopContainer.Controls.Add(this.btnUpdate);
            this.panelTopContainer.Location = new System.Drawing.Point(10, 10);
            this.panelTopContainer.Name = "panelTopContainer";
            this.panelTopContainer.Size = new System.Drawing.Size(1291, 100);
            this.panelTopContainer.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(430, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 45);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuMetroSearchBox
            // 
            this.bunifuMetroSearchBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bunifuMetroSearchBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bunifuMetroSearchBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroSearchBox.BorderThickness = 3;
            this.bunifuMetroSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroSearchBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bunifuMetroSearchBox.isPassword = false;
            this.bunifuMetroSearchBox.Location = new System.Drawing.Point(36, 27);
            this.bunifuMetroSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroSearchBox.Name = "bunifuMetroSearchBox";
            this.bunifuMetroSearchBox.Size = new System.Drawing.Size(396, 49);
            this.bunifuMetroSearchBox.TabIndex = 9;
            this.bunifuMetroSearchBox.Text = "Please Search Food Item";
            this.bunifuMetroSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroSearchBox.OnValueChanged += new System.EventHandler(this.bunifuMetroSearchBox_OnValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1131, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(952, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 47);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(10, 761);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1294, 10);
            this.panelFooter.TabIndex = 3;
            // 
            // panelBorderLeft
            // 
            this.panelBorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBorderLeft.Location = new System.Drawing.Point(0, 10);
            this.panelBorderLeft.Name = "panelBorderLeft";
            this.panelBorderLeft.Size = new System.Drawing.Size(10, 761);
            this.panelBorderLeft.TabIndex = 2;
            // 
            // panelBorderRight
            // 
            this.panelBorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBorderRight.Location = new System.Drawing.Point(1304, 10);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(10, 761);
            this.panelBorderRight.TabIndex = 1;
            // 
            // panelTopBorder
            // 
            this.panelTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBorder.Location = new System.Drawing.Point(0, 0);
            this.panelTopBorder.Name = "panelTopBorder";
            this.panelTopBorder.Size = new System.Drawing.Size(1314, 10);
            this.panelTopBorder.TabIndex = 0;
            // 
            // AllFoodItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelMain);
            this.Name = "AllFoodItems";
            this.Size = new System.Drawing.Size(1320, 775);
            this.Load += new System.EventHandler(this.AllFoodItems_Load);
            this.panelMain.ResumeLayout(false);
            this.panelForGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).EndInit();
            this.panelTopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelForGridView;
        private System.Windows.Forms.Panel panelTopContainer;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroSearchBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBorderLeft;
        private System.Windows.Forms.Panel panelTopBorder;
        private Bunifu.Framework.UI.BunifuCustomDataGrid foodGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn isSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.Panel panelBorderRight;
    }
}
