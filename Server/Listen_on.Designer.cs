namespace Server
{
    partial class Listen_on
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.IpTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(172, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(12, 96);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 20);
            this.lblPort.TabIndex = 15;
            this.lblPort.Text = "Port:";
            // 
            // textPort
            // 
            this.textPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPort.Location = new System.Drawing.Point(121, 96);
            this.textPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(150, 20);
            this.textPort.TabIndex = 14;
            this.textPort.Text = "8000";
            this.textPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(16, 140);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 31);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(12, 52);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(81, 20);
            this.lblIPAddress.TabIndex = 12;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // IpTextBox1
            // 
            this.IpTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IpTextBox1.Location = new System.Drawing.Point(121, 52);
            this.IpTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IpTextBox1.Name = "IpTextBox1";
            this.IpTextBox1.Size = new System.Drawing.Size(150, 20);
            this.IpTextBox1.TabIndex = 11;
            this.IpTextBox1.Text = "127.0.0.1";
            this.IpTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Listen_on
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 199);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.IpTextBox1);
            this.Name = "Listen_on";
            this.Text = "Listen_on";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Listen_on_FormClosed);
            this.Load += new System.EventHandler(this.Listen_on_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox IpTextBox1;
    }
}