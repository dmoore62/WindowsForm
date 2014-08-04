namespace Analytics_Solution
{
    partial class NewProjectForm
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
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.tbxProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(271, 61);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(175, 43);
            this.btnCreateProject.TabIndex = 0;
            this.btnCreateProject.Text = "Create New";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // tbxProjectName
            // 
            this.tbxProjectName.Location = new System.Drawing.Point(13, 33);
            this.tbxProjectName.Name = "tbxProjectName";
            this.tbxProjectName.Size = new System.Drawing.Size(433, 22);
            this.tbxProjectName.TabIndex = 1;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(13, 13);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(93, 17);
            this.lblProjectName.TabIndex = 2;
            this.lblProjectName.Text = "Project Name";
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 142);
            this.ControlBox = false;
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.tbxProjectName);
            this.Controls.Add(this.btnCreateProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewProjectForm";
            this.Text = "Create New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.TextBox tbxProjectName;
        private System.Windows.Forms.Label lblProjectName;
    }
}