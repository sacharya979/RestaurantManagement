namespace RMS.User_Controls
{
    partial class AllFoodCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllFoodCategory));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForGridView = new System.Windows.Forms.Panel();
            this.grdCategory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopContainer = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelBorderLeft = new System.Windows.Forms.Panel();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.panelTopBorder = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelForGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
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
            this.panelMain.Location = new System.Drawing.Point(3, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1317, 775);
            this.panelMain.TabIndex = 1;
            // 
            // panelForGridView
            // 
            this.panelForGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panelForGridView.Controls.Add(this.grdCategory);
            this.panelForGridView.Location = new System.Drawing.Point(10, 111);
            this.panelForGridView.Name = "panelForGridView";
            this.panelForGridView.Size = new System.Drawing.Size(1285, 653);
            this.panelForGridView.TabIndex = 6;
            // 
            // grdCategory
            // 
            this.grdCategory.AllowUserToAddRows = false;
            this.grdCategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCategory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grdCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CategoryAdded,
            this.AddedDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdCategory.DoubleBuffered = true;
            this.grdCategory.EnableHeadersVisualStyles = false;
            this.grdCategory.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.grdCategory.HeaderForeColor = System.Drawing.Color.White;
            this.grdCategory.Location = new System.Drawing.Point(0, 3);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdCategory.RowHeadersVisible = false;
            this.grdCategory.RowHeadersWidth = 51;
            this.grdCategory.RowTemplate.Height = 24;
            this.grdCategory.Size = new System.Drawing.Size(1293, 661);
            this.grdCategory.TabIndex = 8;
            this.grdCategory.Click += new System.EventHandler(this.grdCategory_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "      S.N";
            this.Id.MinimumWidth = 4;
            this.Id.Name = "Id";
            // 
            // CategoryAdded
            // 
            this.CategoryAdded.DataPropertyName = "CategoryName";
            this.CategoryAdded.HeaderText = "Category Added";
            this.CategoryAdded.MinimumWidth = 6;
            this.CategoryAdded.Name = "CategoryAdded";
            // 
            // AddedDate
            // 
            this.AddedDate.DataPropertyName = "AddedDate";
            this.AddedDate.HeaderText = "Added Date";
            this.AddedDate.MinimumWidth = 6;
            this.AddedDate.Name = "AddedDate";
            // 
            // panelTopContainer
            // 
            this.panelTopContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panelTopContainer.Controls.Add(this.cmbFilter);
            this.panelTopContainer.Controls.Add(this.button3);
            this.panelTopContainer.Controls.Add(this.bunifuMetroTextbox1);
            this.panelTopContainer.Controls.Add(this.button2);
            this.panelTopContainer.Controls.Add(this.button4);
            this.panelTopContainer.Controls.Add(this.button1);
            this.panelTopContainer.Location = new System.Drawing.Point(10, 10);
            this.panelTopContainer.Name = "panelTopContainer";
            this.panelTopContainer.Size = new System.Drawing.Size(1287, 100);
            this.panelTopContainer.TabIndex = 4;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(410, 38);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(382, 31);
            this.cmbFilter.TabIndex = 18;
            this.cmbFilter.SelectionChangeCommitted += new System.EventHandler(this.FilterList);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(355, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 45);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(36, 27);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(321, 49);
            this.bunifuMetroTextbox1.TabIndex = 9;
            this.bunifuMetroTextbox1.Text = "Please Search Food Category";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1138, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(843, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "New";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1000, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(10, 765);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1293, 10);
            this.panelFooter.TabIndex = 3;
            // 
            // panelBorderLeft
            // 
            this.panelBorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBorderLeft.Location = new System.Drawing.Point(0, 10);
            this.panelBorderLeft.Name = "panelBorderLeft";
            this.panelBorderLeft.Size = new System.Drawing.Size(10, 765);
            this.panelBorderLeft.TabIndex = 2;
            // 
            // panelBorderRight
            // 
            this.panelBorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBorderRight.Location = new System.Drawing.Point(1303, 10);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(14, 765);
            this.panelBorderRight.TabIndex = 1;
            // 
            // panelTopBorder
            // 
            this.panelTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBorder.Location = new System.Drawing.Point(0, 0);
            this.panelTopBorder.Name = "panelTopBorder";
            this.panelTopBorder.Size = new System.Drawing.Size(1317, 10);
            this.panelTopBorder.TabIndex = 0;
            // 
            // AllFoodCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AllFoodCategory";
            this.Size = new System.Drawing.Size(1320, 775);
            this.Load += new System.EventHandler(this.AllFoodCategory_Load);
            this.panelMain.ResumeLayout(false);
            this.panelForGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.panelTopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelForGridView;
        private System.Windows.Forms.Panel panelTopContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBorderLeft;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.Panel panelTopBorder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedDate;
        public Bunifu.Framework.UI.BunifuCustomDataGrid grdCategory;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}
