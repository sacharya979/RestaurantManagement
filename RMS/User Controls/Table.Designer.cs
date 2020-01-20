namespace RMS.User_Controls
{
    partial class Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelForGridView = new System.Windows.Forms.Panel();
            this.grdTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopContainer = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelBorderLeft = new System.Windows.Forms.Panel();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.panelTopBorder = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelForGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).BeginInit();
            this.panelTopContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1320, 775);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panelForGridView);
            this.panel1.Controls.Add(this.panelTopContainer);
            this.panel1.Controls.Add(this.panelFooter);
            this.panel1.Controls.Add(this.panelBorderLeft);
            this.panel1.Controls.Add(this.panelBorderRight);
            this.panel1.Controls.Add(this.panelTopBorder);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 775);
            this.panel1.TabIndex = 2;
            // 
            // panelForGridView
            // 
            this.panelForGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panelForGridView.Controls.Add(this.grdTable);
            this.panelForGridView.Location = new System.Drawing.Point(10, 111);
            this.panelForGridView.Name = "panelForGridView";
            this.panelForGridView.Size = new System.Drawing.Size(1285, 653);
            this.panelForGridView.TabIndex = 6;
            // 
            // grdTable
            // 
            this.grdTable.AllowUserToAddRows = false;
            this.grdTable.AllowUserToDeleteRows = false;
            this.grdTable.AllowUserToResizeColumns = false;
            this.grdTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grdTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TableNumber,
            this.AddedDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdTable.DoubleBuffered = true;
            this.grdTable.EnableHeadersVisualStyles = false;
            this.grdTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.grdTable.HeaderForeColor = System.Drawing.Color.White;
            this.grdTable.Location = new System.Drawing.Point(0, 3);
            this.grdTable.Name = "grdTable";
            this.grdTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdTable.RowHeadersVisible = false;
            this.grdTable.RowHeadersWidth = 51;
            this.grdTable.RowTemplate.Height = 24;
            this.grdTable.Size = new System.Drawing.Size(1293, 661);
            this.grdTable.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "      S.N";
            this.Id.MinimumWidth = 4;
            this.Id.Name = "Id";
            // 
            // TableNumber
            // 
            this.TableNumber.DataPropertyName = "TableNumber";
            this.TableNumber.HeaderText = "Table Number";
            this.TableNumber.MinimumWidth = 6;
            this.TableNumber.Name = "TableNumber";
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
            this.panelTopContainer.Controls.Add(this.button3);
            this.panelTopContainer.Controls.Add(this.bunifuMetroTextbox1);
            this.panelTopContainer.Controls.Add(this.button2);
            this.panelTopContainer.Controls.Add(this.btnNew);
            this.panelTopContainer.Controls.Add(this.button1);
            this.panelTopContainer.Location = new System.Drawing.Point(10, 10);
            this.panelTopContainer.Name = "panelTopContainer";
            this.panelTopContainer.Size = new System.Drawing.Size(1287, 100);
            this.panelTopContainer.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(379, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 31);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
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
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(396, 49);
            this.bunifuMetroTextbox1.TabIndex = 9;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1138, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(843, 29);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 47);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // Table
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelMain);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(1320, 775);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelForGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).EndInit();
            this.panelTopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelForGridView;
        public Bunifu.Framework.UI.BunifuCustomDataGrid grdTable;
        private System.Windows.Forms.Panel panelTopContainer;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBorderLeft;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.Panel panelTopBorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedDate;
    }
}
