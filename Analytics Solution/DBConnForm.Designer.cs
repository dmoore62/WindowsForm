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
            this.btnConnOpen = new System.Windows.Forms.Button();
            this.lblConnections = new System.Windows.Forms.Label();
            this.tbxConnInput = new System.Windows.Forms.TextBox();
            this.btnConnTest = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnOpen
            // 
            this.btnConnOpen.Location = new System.Drawing.Point(461, 61);
            this.btnConnOpen.Name = "btnConnOpen";
            this.btnConnOpen.Size = new System.Drawing.Size(157, 34);
            this.btnConnOpen.TabIndex = 0;
            this.btnConnOpen.Text = "Open Connection";
            this.btnConnOpen.UseVisualStyleBackColor = true;
            this.btnConnOpen.Click += new System.EventHandler(this.btnConnOpen_Click);
            // 
            // lblConnections
            // 
            this.lblConnections.AutoSize = true;
            this.lblConnections.Location = new System.Drawing.Point(13, 13);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(115, 16);
            this.lblConnections.TabIndex = 2;
            this.lblConnections.Text = "Connection Name";
            this.lblConnections.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxConnInput
            // 
            this.tbxConnInput.Location = new System.Drawing.Point(16, 33);
            this.tbxConnInput.Name = "tbxConnInput";
            this.tbxConnInput.Size = new System.Drawing.Size(602, 22);
            this.tbxConnInput.TabIndex = 3;
            // 
            // btnConnTest
            // 
            this.btnConnTest.Location = new System.Drawing.Point(320, 61);
            this.btnConnTest.Name = "btnConnTest";
            this.btnConnTest.Size = new System.Drawing.Size(135, 34);
            this.btnConnTest.TabIndex = 4;
            this.btnConnTest.Text = "Test Connection";
            this.btnConnTest.UseVisualStyleBackColor = true;
            this.btnConnTest.Click += new System.EventHandler(this.btnConnTest_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 78);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 5;
            // 
            // DBConnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 120);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnTest);
            this.Controls.Add(this.tbxConnInput);
            this.Controls.Add(this.lblConnections);
            this.Controls.Add(this.btnConnOpen);
            this.Name = "DBConnForm";
            this.Text = "DBConnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnOpen;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.TextBox tbxConnInput;
        private System.Windows.Forms.Button btnConnTest;
        private System.Windows.Forms.Label lblStatus;
    }
}