namespace Analytics_Solution
{
    partial class DBConnForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbxConnections = new System.Windows.Forms.ComboBox();
            this.lblConnections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Connection";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbxConnections
            // 
            this.cmbxConnections.FormattingEnabled = true;
            this.cmbxConnections.Location = new System.Drawing.Point(12, 39);
            this.cmbxConnections.Name = "cmbxConnections";
            this.cmbxConnections.Size = new System.Drawing.Size(606, 24);
            this.cmbxConnections.TabIndex = 1;
            // 
            // lblConnections
            // 
            this.lblConnections.AutoSize = true;
            this.lblConnections.Location = new System.Drawing.Point(13, 13);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(142, 16);
            this.lblConnections.TabIndex = 2;
            this.lblConnections.Text = "Available Connections";
            this.lblConnections.Click += new System.EventHandler(this.label1_Click);
            // 
            // DBConnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 120);
            this.Controls.Add(this.lblConnections);
            this.Controls.Add(this.cmbxConnections);
            this.Controls.Add(this.button1);
            this.Name = "DBConnForm";
            this.Text = "DBConnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbxConnections;
        private System.Windows.Forms.Label lblConnections;
    }
}