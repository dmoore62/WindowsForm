namespace Analytics_Solution
{
    partial class Form2
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
            this.lblAttrNameInput = new System.Windows.Forms.Label();
            this.lblAttrDescInput = new System.Windows.Forms.Label();
            this.tbxAttrName = new System.Windows.Forms.TextBox();
            this.tbxAttrDesc = new System.Windows.Forms.TextBox();
            this.dataGridViewExpressions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewChildren = new System.Windows.Forms.DataGridView();
            this.colChildrenAttr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChildrenTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewParents = new System.Windows.Forms.DataGridView();
            this.colParentAttr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAttrClear = new System.Windows.Forms.Button();
            this.btnAttrAdd = new System.Windows.Forms.Button();
            this.lblAttrNameError = new System.Windows.Forms.Label();
            this.lblAttrDescError = new System.Windows.Forms.Label();
            this.colExpForms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colExpTable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpressions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttrNameInput
            // 
            this.lblAttrNameInput.AutoSize = true;
            this.lblAttrNameInput.Location = new System.Drawing.Point(33, 28);
            this.lblAttrNameInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttrNameInput.Name = "lblAttrNameInput";
            this.lblAttrNameInput.Size = new System.Drawing.Size(77, 13);
            this.lblAttrNameInput.TabIndex = 0;
            this.lblAttrNameInput.Text = "Attribute Name";
            // 
            // lblAttrDescInput
            // 
            this.lblAttrDescInput.AutoSize = true;
            this.lblAttrDescInput.Location = new System.Drawing.Point(252, 28);
            this.lblAttrDescInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttrDescInput.Name = "lblAttrDescInput";
            this.lblAttrDescInput.Size = new System.Drawing.Size(102, 13);
            this.lblAttrDescInput.TabIndex = 1;
            this.lblAttrDescInput.Text = "Attribute Description";
            // 
            // tbxAttrName
            // 
            this.tbxAttrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAttrName.Location = new System.Drawing.Point(35, 45);
            this.tbxAttrName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAttrName.Name = "tbxAttrName";
            this.tbxAttrName.Size = new System.Drawing.Size(152, 26);
            this.tbxAttrName.TabIndex = 2;
            // 
            // tbxAttrDesc
            // 
            this.tbxAttrDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAttrDesc.Location = new System.Drawing.Point(254, 45);
            this.tbxAttrDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAttrDesc.Name = "tbxAttrDesc";
            this.tbxAttrDesc.Size = new System.Drawing.Size(152, 26);
            this.tbxAttrDesc.TabIndex = 3;
            // 
            // dataGridViewExpressions
            // 
            this.dataGridViewExpressions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpressions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpressions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpForms,
            this.colExpColumn,
            this.colExpTable});
            this.dataGridViewExpressions.Location = new System.Drawing.Point(35, 107);
            this.dataGridViewExpressions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewExpressions.Name = "dataGridViewExpressions";
            this.dataGridViewExpressions.RowHeadersVisible = false;
            this.dataGridViewExpressions.RowTemplate.Height = 24;
            this.dataGridViewExpressions.Size = new System.Drawing.Size(370, 122);
            this.dataGridViewExpressions.TabIndex = 4;
            this.dataGridViewExpressions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExpressions_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expressions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Children";
            // 
            // dataGridViewChildren
            // 
            this.dataGridViewChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChildren.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChildrenAttr,
            this.colChildrenTable});
            this.dataGridViewChildren.Location = new System.Drawing.Point(35, 265);
            this.dataGridViewChildren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewChildren.Name = "dataGridViewChildren";
            this.dataGridViewChildren.RowHeadersVisible = false;
            this.dataGridViewChildren.RowTemplate.Height = 24;
            this.dataGridViewChildren.Size = new System.Drawing.Size(180, 122);
            this.dataGridViewChildren.TabIndex = 7;
            // 
            // colChildrenAttr
            // 
            this.colChildrenAttr.HeaderText = "Attribute";
            this.colChildrenAttr.Name = "colChildrenAttr";
            this.colChildrenAttr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colChildrenAttr.Width = 78;
            // 
            // colChildrenTable
            // 
            this.colChildrenTable.HeaderText = "Reference Table";
            this.colChildrenTable.Name = "colChildrenTable";
            this.colChildrenTable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colChildrenTable.Width = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parents";
            // 
            // dataGridViewParents
            // 
            this.dataGridViewParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParentAttr,
            this.colParentTable});
            this.dataGridViewParents.Location = new System.Drawing.Point(225, 265);
            this.dataGridViewParents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewParents.Name = "dataGridViewParents";
            this.dataGridViewParents.RowHeadersVisible = false;
            this.dataGridViewParents.RowTemplate.Height = 24;
            this.dataGridViewParents.Size = new System.Drawing.Size(180, 122);
            this.dataGridViewParents.TabIndex = 9;
            // 
            // colParentAttr
            // 
            this.colParentAttr.HeaderText = "Attribute";
            this.colParentAttr.Name = "colParentAttr";
            this.colParentAttr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colParentAttr.Width = 78;
            // 
            // colParentTable
            // 
            this.colParentTable.HeaderText = "Reference Table";
            this.colParentTable.Name = "colParentTable";
            this.colParentTable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colParentTable.Width = 158;
            // 
            // btnAttrClear
            // 
            this.btnAttrClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAttrClear.Location = new System.Drawing.Point(72, 397);
            this.btnAttrClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAttrClear.Name = "btnAttrClear";
            this.btnAttrClear.Size = new System.Drawing.Size(123, 34);
            this.btnAttrClear.TabIndex = 10;
            this.btnAttrClear.Text = "Clear";
            this.btnAttrClear.UseVisualStyleBackColor = true;
            // 
            // btnAttrAdd
            // 
            this.btnAttrAdd.Location = new System.Drawing.Point(242, 397);
            this.btnAttrAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAttrAdd.Name = "btnAttrAdd";
            this.btnAttrAdd.Size = new System.Drawing.Size(132, 34);
            this.btnAttrAdd.TabIndex = 11;
            this.btnAttrAdd.Text = "Add";
            this.btnAttrAdd.UseVisualStyleBackColor = true;
            this.btnAttrAdd.Click += new System.EventHandler(this.btnAttrAdd_Click);
            // 
            // lblAttrNameError
            // 
            this.lblAttrNameError.AutoSize = true;
            this.lblAttrNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAttrNameError.Location = new System.Drawing.Point(142, 28);
            this.lblAttrNameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttrNameError.Name = "lblAttrNameError";
            this.lblAttrNameError.Size = new System.Drawing.Size(54, 13);
            this.lblAttrNameError.TabIndex = 12;
            this.lblAttrNameError.Text = "*Required";
            this.lblAttrNameError.Visible = false;
            // 
            // lblAttrDescError
            // 
            this.lblAttrDescError.AutoSize = true;
            this.lblAttrDescError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAttrDescError.Location = new System.Drawing.Point(358, 28);
            this.lblAttrDescError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttrDescError.Name = "lblAttrDescError";
            this.lblAttrDescError.Size = new System.Drawing.Size(54, 13);
            this.lblAttrDescError.TabIndex = 13;
            this.lblAttrDescError.Text = "*Required";
            this.lblAttrDescError.Visible = false;
            // 
            // colExpForms
            // 
            this.colExpForms.HeaderText = "Forms";
            this.colExpForms.Name = "colExpForms";
            // 
            // colExpColumn
            // 
            this.colExpColumn.HeaderText = "Columns";
            this.colExpColumn.Name = "colExpColumn";
            this.colExpColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExpColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colExpTable
            // 
            this.colExpTable.HeaderText = "Tables";
            this.colExpTable.Name = "colExpTable";
            this.colExpTable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExpTable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAttrClear;
            this.ClientSize = new System.Drawing.Size(448, 449);
            this.Controls.Add(this.lblAttrDescError);
            this.Controls.Add(this.lblAttrNameError);
            this.Controls.Add(this.btnAttrAdd);
            this.Controls.Add(this.btnAttrClear);
            this.Controls.Add(this.dataGridViewParents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewChildren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewExpressions);
            this.Controls.Add(this.tbxAttrDesc);
            this.Controls.Add(this.tbxAttrName);
            this.Controls.Add(this.lblAttrDescInput);
            this.Controls.Add(this.lblAttrNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "New Attribute";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpressions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttrNameInput;
        private System.Windows.Forms.Label lblAttrDescInput;
        private System.Windows.Forms.TextBox tbxAttrName;
        private System.Windows.Forms.TextBox tbxAttrDesc;
        private System.Windows.Forms.DataGridView dataGridViewExpressions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildrenAttr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChildrenTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewParents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentAttr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentTable;
        private System.Windows.Forms.Button btnAttrClear;
        private System.Windows.Forms.Button btnAttrAdd;
        private System.Windows.Forms.Label lblAttrNameError;
        private System.Windows.Forms.Label lblAttrDescError;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpForms;
        private System.Windows.Forms.DataGridViewComboBoxColumn colExpColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colExpTable;
    }
}