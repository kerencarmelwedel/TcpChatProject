namespace Server
{
    partial class ConnectedClients
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
            this.tabControlViews = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.listConnected = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.tabControlViews.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlViews
            // 
            this.tabControlViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlViews.Controls.Add(this.tabUsers);
            this.tabControlViews.Controls.Add(this.tabHistory);
            this.tabControlViews.Location = new System.Drawing.Point(5, 10);
            this.tabControlViews.Name = "tabControlViews";
            this.tabControlViews.SelectedIndex = 0;
            this.tabControlViews.Size = new System.Drawing.Size(521, 301);
            this.tabControlViews.TabIndex = 5;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.listConnected);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(513, 275);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Conneced Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // listConnected
            // 
            this.listConnected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listConnected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listConnected.FullRowSelect = true;
            this.listConnected.GridLines = true;
            this.listConnected.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listConnected.Location = new System.Drawing.Point(6, 6);
            this.listConnected.Name = "listConnected";
            this.listConnected.Size = new System.Drawing.Size(501, 263);
            this.listConnected.TabIndex = 1;
            this.listConnected.UseCompatibleStateImageBehavior = false;
            this.listConnected.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nick name";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 160;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.txtHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(513, 275);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(6, 6);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(501, 254);
            this.txtHistory.TabIndex = 0;
            // 
            // ConnectedClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 321);
            this.Controls.Add(this.tabControlViews);
            this.Name = "ConnectedClients";
            this.Text = "ConnectedClients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectedClients_FormClosed);
            this.Load += new System.EventHandler(this.ConnectedClients_Load);
            this.tabControlViews.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlViews;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.ListView listConnected;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TextBox txtHistory;
    }
}