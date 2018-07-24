namespace Client
{
    partial class ConnectTo
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
            this.IPlabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IpTextBox1 = new System.Windows.Forms.TextBox();
            this.NickNametextBox2 = new System.Windows.Forms.TextBox();
            this.ColorTextBox3 = new System.Windows.Forms.TextBox();
            this.PortUpDown = new System.Windows.Forms.NumericUpDown();
            this.OkButton1 = new System.Windows.Forms.Button();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PortUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // IPlabel1
            // 
            this.IPlabel1.AutoSize = true;
            this.IPlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IPlabel1.Location = new System.Drawing.Point(25, 39);
            this.IPlabel1.Name = "IPlabel1";
            this.IPlabel1.Size = new System.Drawing.Size(95, 24);
            this.IPlabel1.TabIndex = 0;
            this.IPlabel1.Text = "IP Adress:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nick Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(25, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color:";
            // 
            // IpTextBox1
            // 
            this.IpTextBox1.Location = new System.Drawing.Point(140, 39);
            this.IpTextBox1.Name = "IpTextBox1";
            this.IpTextBox1.Size = new System.Drawing.Size(100, 20);
            this.IpTextBox1.TabIndex = 4;
            this.IpTextBox1.Text = "127.0.0.1";
            this.IpTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IpTextBox1.TextChanged += new System.EventHandler(this.IpTextBox1_TextChanged);
            // 
            // NickNametextBox2
            // 
            this.NickNametextBox2.Location = new System.Drawing.Point(140, 124);
            this.NickNametextBox2.Name = "NickNametextBox2";
            this.NickNametextBox2.Size = new System.Drawing.Size(100, 20);
            this.NickNametextBox2.TabIndex = 5;
            this.NickNametextBox2.TextChanged += new System.EventHandler(this.NickNametextBox2_TextChanged);
            // 
            // ColorTextBox3
            // 
            this.ColorTextBox3.Location = new System.Drawing.Point(138, 165);
            this.ColorTextBox3.Name = "ColorTextBox3";
            this.ColorTextBox3.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox3.TabIndex = 6;
            this.ColorTextBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changeColor);
            // 
            // PortUpDown
            // 
            this.PortUpDown.Location = new System.Drawing.Point(140, 84);
            this.PortUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PortUpDown.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.PortUpDown.Name = "PortUpDown";
            this.PortUpDown.Size = new System.Drawing.Size(102, 20);
            this.PortUpDown.TabIndex = 7;
            this.PortUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortUpDown.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.PortUpDown.ValueChanged += new System.EventHandler(this.PortUpDown_ValueChanged);
            // 
            // OkButton1
            // 
            this.OkButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OkButton1.Location = new System.Drawing.Point(42, 214);
            this.OkButton1.Name = "OkButton1";
            this.OkButton1.Size = new System.Drawing.Size(91, 37);
            this.OkButton1.TabIndex = 8;
            this.OkButton1.Text = "OK";
            this.OkButton1.UseVisualStyleBackColor = true;
            this.OkButton1.Click += new System.EventHandler(this.OkButton1_Click);
            // 
            // CancelButton2
            // 
            this.CancelButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CancelButton2.Location = new System.Drawing.Point(149, 214);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(89, 37);
            this.CancelButton2.TabIndex = 9;
            this.CancelButton2.Text = "Cancel";
            this.CancelButton2.UseVisualStyleBackColor = true;
            this.CancelButton2.Click += new System.EventHandler(this.CancelButton2_Click);
            // 
            // ConnectTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.OkButton1);
            this.Controls.Add(this.PortUpDown);
            this.Controls.Add(this.ColorTextBox3);
            this.Controls.Add(this.NickNametextBox2);
            this.Controls.Add(this.IpTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPlabel1);
            this.Name = "ConnectTo";
            this.Text = "ConnectTo";
            this.Load += new System.EventHandler(this.ConnectTo_Load);
            this.MouseEnter += new System.EventHandler(this.changeColor);
            ((System.ComponentModel.ISupportInitialize)(this.PortUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPlabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IpTextBox1;
        private System.Windows.Forms.TextBox NickNametextBox2;
        private System.Windows.Forms.TextBox ColorTextBox3;
        private System.Windows.Forms.NumericUpDown PortUpDown;
        private System.Windows.Forms.Button OkButton1;
        private System.Windows.Forms.Button CancelButton2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}