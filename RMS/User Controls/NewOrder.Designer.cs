namespace RMS.User_Controls
{
    partial class NewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.cmbWaiter = new System.Windows.Forms.ComboBox();
            this.checkBoxTakeAway = new System.Windows.Forms.CheckBox();
            this.checkBoxDineIn = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelLeftFoodItems = new System.Windows.Forms.Panel();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelLeftFoodItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTable
            // 
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(867, 149);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(151, 28);
            this.cmbTable.TabIndex = 18;
            // 
            // cmbWaiter
            // 
            this.cmbWaiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaiter.FormattingEnabled = true;
            this.cmbWaiter.Location = new System.Drawing.Point(867, 98);
            this.cmbWaiter.Name = "cmbWaiter";
            this.cmbWaiter.Size = new System.Drawing.Size(382, 28);
            this.cmbWaiter.TabIndex = 17;
            this.cmbWaiter.SelectedIndexChanged += new System.EventHandler(this.cmbWaiter_SelectedIndexChanged);
            // 
            // checkBoxTakeAway
            // 
            this.checkBoxTakeAway.AutoSize = true;
            this.checkBoxTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTakeAway.Location = new System.Drawing.Point(1005, 54);
            this.checkBoxTakeAway.Name = "checkBoxTakeAway";
            this.checkBoxTakeAway.Size = new System.Drawing.Size(105, 24);
            this.checkBoxTakeAway.TabIndex = 16;
            this.checkBoxTakeAway.Text = "Take Away";
            this.checkBoxTakeAway.UseVisualStyleBackColor = true;
            // 
            // checkBoxDineIn
            // 
            this.checkBoxDineIn.AutoSize = true;
            this.checkBoxDineIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDineIn.Location = new System.Drawing.Point(867, 54);
            this.checkBoxDineIn.Name = "checkBoxDineIn";
            this.checkBoxDineIn.Size = new System.Drawing.Size(83, 24);
            this.checkBoxDineIn.TabIndex = 15;
            this.checkBoxDineIn.Text = " Dine In";
            this.checkBoxDineIn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1152, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 26);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(867, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 26);
            this.textBox1.TabIndex = 14;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(1024, 149);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(81, 20);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Order No :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(670, 149);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(62, 20);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Table* :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(670, 98);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(69, 20);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Waiter* :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(670, 54);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(130, 20);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "Customer Type* :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(670, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(138, 20);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Customer Name* :";
            // 
            // panelLeftFoodItems
            // 
            this.panelLeftFoodItems.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeftFoodItems.Controls.Add(this.cmbCategoryName);
            this.panelLeftFoodItems.Controls.Add(this.bunifuTextbox1);
            this.panelLeftFoodItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftFoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeftFoodItems.Location = new System.Drawing.Point(0, 0);
            this.panelLeftFoodItems.Name = "panelLeftFoodItems";
            this.panelLeftFoodItems.Size = new System.Drawing.Size(664, 695);
            this.panelLeftFoodItems.TabIndex = 19;
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.BackColor = System.Drawing.Color.White;
            this.cmbCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(383, 24);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(255, 28);
            this.cmbCategoryName.TabIndex = 1;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Green;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(6, 9);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(652, 69);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "";
            this.bunifuTextbox1.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnValueChange);
            // 
            // NewOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelLeftFoodItems);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.cmbWaiter);
            this.Controls.Add(this.checkBoxTakeAway);
            this.Controls.Add(this.checkBoxDineIn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewOrder";
            this.Size = new System.Drawing.Size(1258, 695);
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.panelLeftFoodItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.ComboBox cmbWaiter;
        private System.Windows.Forms.CheckBox checkBoxTakeAway;
        private System.Windows.Forms.CheckBox checkBoxDineIn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelLeftFoodItems;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.ComboBox cmbCategoryName;
    }
}
