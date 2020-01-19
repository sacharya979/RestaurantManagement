namespace RMS.User_Controls
{
    partial class OrderUserControl
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
            this.panelTopContainer = new System.Windows.Forms.Panel();
            this.btnOngoingOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelTopContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopContainer
            // 
            this.panelTopContainer.BackColor = System.Drawing.Color.White;
            this.panelTopContainer.Controls.Add(this.btnOngoingOrder);
            this.panelTopContainer.Controls.Add(this.btnNewOrder);
            this.panelTopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopContainer.Location = new System.Drawing.Point(0, 0);
            this.panelTopContainer.Name = "panelTopContainer";
            this.panelTopContainer.Size = new System.Drawing.Size(1325, 83);
            this.panelTopContainer.TabIndex = 0;
            // 
            // btnOngoingOrder
            // 
            this.btnOngoingOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnOngoingOrder.ForeColor = System.Drawing.Color.White;
            this.btnOngoingOrder.Location = new System.Drawing.Point(238, 18);
            this.btnOngoingOrder.Name = "btnOngoingOrder";
            this.btnOngoingOrder.Size = new System.Drawing.Size(201, 49);
            this.btnOngoingOrder.TabIndex = 8;
            this.btnOngoingOrder.Text = "     Ongoing Order";
            this.btnOngoingOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOngoingOrder.UseVisualStyleBackColor = false;
            this.btnOngoingOrder.Click += new System.EventHandler(this.btnOngoingOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Location = new System.Drawing.Point(30, 18);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(179, 49);
            this.btnNewOrder.TabIndex = 9;
            this.btnNewOrder.Text = "     New Order";
            this.btnNewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 83);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1325, 652);
            this.panelMainContainer.TabIndex = 1;
            // 
            // OrderUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.panelTopContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(1325, 735);
            this.Load += new System.EventHandler(this.OrderUserControl_Load);
            this.panelTopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopContainer;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Button btnOngoingOrder;
        private System.Windows.Forms.Button btnNewOrder;
    }
}
